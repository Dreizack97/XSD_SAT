using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using QRCoder;
using XSD.Comprobante.V40;
using XSD.Nomina;
using static iText.Layout.Properties.TextAlignment;
using Image = iText.Layout.Element.Image;

namespace CFDI_Reader
{
    public static class Test
    {
        public static void GeneratePdf(string path, Comprobante comprobante)
        {
            using PdfDocument pdf = new PdfDocument(new PdfWriter(path.ToUpper().Replace(".XML", ".pdf")));
            using Document document = new Document(pdf);

            // Fuentes y colores
            PdfFont bold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont normal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            DeviceRgb gris = new DeviceRgb(220, 221, 226);
            DeviceRgb fontColor = new DeviceRgb(85, 85, 85);

            // Tabla principal
            Table tableBody = CreateMainTable(comprobante, bold, normal, gris, fontColor);

            // Tabla fiscal
            Table tablaFiscal = CreateFiscalTable(comprobante, gris);

            // Agregar tablas al documento
            document.Add(tableBody);
            document.Add(tablaFiscal.SetFixedPosition(36, 36, pdf.GetDefaultPageSize().GetWidth() - 72));
        }

        private static Table CreateMainTable(Comprobante comprobante, PdfFont bold, PdfFont normal, DeviceRgb gris, DeviceRgb fontColor)
        {
            Table tableBody = new Table(UnitValue.CreatePercentArray(new float[] { 49.5F, 1, 49.5F })).UseAllAvailableWidth();
            tableBody.SetFontColor(fontColor);

            AddHeader(tableBody, bold, gris);
            AddBasicInfo(tableBody, comprobante, bold, normal);
            AddEntityData(tableBody, comprobante, bold, normal, gris);
            AddPerceptionsAndDeductions(tableBody, comprobante, bold, normal, gris);
            AddSummary(tableBody, comprobante, bold, normal, gris);

            return tableBody;
        }

        private static void AddHeader(Table table, PdfFont bold, DeviceRgb gris)
        {
            table.AddCell(CreateEmptyCell());
            table.AddCell(CreateEmptyCell());
            table.AddCell(new Cell().Add(new Paragraph("CFDI de Nómina"))
                .SetBorder(Border.NO_BORDER)
                .SetFont(bold)
                .SetFontSize(9)
                .SetTextAlignment(CENTER)
                .SetBackgroundColor(gris)
                .SetBorderRadius(new BorderRadius(5)));
        }

        private static void AddBasicInfo(Table table, Comprobante comprobante, PdfFont bold, PdfFont normal)
        {
            Table tableInfo = new Table(UnitValue.CreatePercentArray(new float[] { 15, 15, 15, 55 })).UseAllAvailableWidth();

            AddTableCells(tableInfo, new[] { "Serie", "Folio", "Lugar", "Fecha y hora" }, normal, fontSize: 8, isBold: false);
            AddTableCells(tableInfo, new[] {
                comprobante.Serie,
                comprobante.Folio,
                comprobante.LugarExpedicion.ToString(),
                comprobante.Fecha.ToString()
            }, bold, fontSize: 8, isBold: true);

            table.AddCell(CreateEmptyCell());
            table.AddCell(CreateEmptyCell());
            table.AddCell(new Cell().Add(tableInfo).SetBorder(Border.NO_BORDER));
        }

        private static void AddEntityData(Table table, Comprobante comprobante, PdfFont bold, PdfFont normal, DeviceRgb gris)
        {
            table.AddCell(new Cell().Add(new Paragraph("Datos del emisor"))
                .SetBorder(Border.NO_BORDER)
                .SetPaddingLeft(5)
                .SetFont(bold)
                .SetFontSize(9)
                .SetBackgroundColor(gris)
                .SetBorderRadius(new BorderRadius(5)));
            table.AddCell(CreateEmptyCell());
            table.AddCell(new Cell().Add(new Paragraph("Datos del receptor"))
                .SetBorder(Border.NO_BORDER)
                .SetPaddingLeft(5)
                .SetFont(bold)
                .SetFontSize(9)
                .SetBackgroundColor(gris)
                .SetBorderRadius(new BorderRadius(5)));

            // Emisor y receptor
            AddEntityDetail(table, "RFC ", comprobante.Emisor.Rfc, comprobante.Receptor.Rfc, bold, normal);
            AddEntityDetail(table, "Régimen fiscal ", RegimenFiscal(comprobante.Emisor.RegimenFiscal), RegimenFiscal(comprobante.Receptor.RegimenFiscalReceptor), bold, normal);
        }

        private static void AddPerceptionsAndDeductions(Table table, Comprobante comprobante, PdfFont bold, PdfFont normal, DeviceRgb gris)
        {
            // Percepciones
            Table tablaPercepciones = CreatePerceptionTable(comprobante, bold, normal, gris);
            table.AddCell(new Cell().Add(tablaPercepciones).SetBorder(Border.NO_BORDER));

            // Espaciado
            table.AddCell(CreateEmptyCell());

            // Deducciones
            Table tablaDeducciones = CreateDeductionTable(comprobante, bold, normal, gris);
            table.AddCell(new Cell().Add(tablaDeducciones).SetBorder(Border.NO_BORDER));
        }

        private static Table CreatePerceptionTable(Comprobante comprobante, PdfFont bold, PdfFont normal, DeviceRgb gris)
        {
            Table tabla = new Table(UnitValue.CreatePercentArray(new float[] { 10, 55, 17.5F, 17.5F })).UseAllAvailableWidth();
            AddTableCells(tabla, new[] { "Tipo", "Concepto", "Exento", "Gravado" }, bold, fontSize: 6);

            foreach (var percepcion in comprobante.Nomina.Percepciones.Percepcion)
            {
                AddTableCells(tabla, new[] {
                    percepcion.TipoPercepcion,
                    percepcion.Concepto,
                    "$" + percepcion.ImporteExento,
                    "$" + percepcion.ImporteGravado
                }, normal, fontSize: 8);
            }

            AddTableCells(tabla, new[] { "", "Total",
                "$" + comprobante.Nomina.Percepciones.TotalExento,
                "$" + comprobante.Nomina.Percepciones.TotalGravado }, normal, fontSize: 8);
            return tabla;
        }

        private static Table CreateDeductionTable(Comprobante comprobante, PdfFont bold, PdfFont normal, DeviceRgb gris)
        {
            Table tabla = new Table(UnitValue.CreatePercentArray(new float[] { 10, 75, 15 })).UseAllAvailableWidth();
            AddTableCells(tabla, new[] { "Tipo", "Descripción", "Importe" }, bold, fontSize: 6);

            foreach (var deduccion in comprobante.Nomina.Deducciones.Deduccion)
            {
                AddTableCells(tabla, new[] {
                    deduccion.TipoDeduccion,
                    deduccion.Concepto,
                    "$" + deduccion.Importe
                }, normal, fontSize: 8);
            }

            AddTableCells(tabla, new[] { "", "Total", "$" + comprobante.Descuento }, normal, fontSize: 8);
            return tabla;
        }

        private static Table CreateFiscalTable(Comprobante comprobante, DeviceRgb gris)
        {
            Table tablaFiscal = new Table(UnitValue.CreatePercentArray(new float[] { 11, 1, 39, 1, 23, 1, 23 })).UseAllAvailableWidth();
            tablaFiscal.AddCell(new Cell(1, 7).Add(new Paragraph("")).SetBorder(Border.NO_BORDER).SetBorderTop(new SolidBorder(gris, 0.8F)).SetPadding(2));

            string qrCodeUrl = GenerateQrCodeUrl(comprobante);
            Image qrImage = GenerateQrImage(qrCodeUrl);

            tablaFiscal.AddCell(new Cell(7, 1).Add(qrImage.ScaleToFit(95, 95)).SetBorder(Border.NO_BORDER).SetPadding(0));

            AddTableCells(tablaFiscal, new[] { "Folio fiscal", "Número de certificado SAT", "Fecha y hora de certificación" }, null, 8, gris, isHeader: true);
            AddTableCells(tablaFiscal, new[] {
                comprobante.TimbreFiscalDigital.UUID,
                comprobante.TimbreFiscalDigital.NoCertificadoSAT,
                comprobante.TimbreFiscalDigital.FechaTimbrado.ToString()
            }, null, 8);

            return tablaFiscal;
        }

        private static string RegimenFiscal(int regimen)
        {
            // Agrega aquí las definiciones de régimen fiscal.
            return regimen switch
            {
                601 => $"{regimen} - General de Ley Personas Morales",
                // Otros casos...
                _ => regimen.ToString(),
            };
        }

        private static Image GenerateQrImage(string texto)
        {
            using var qrGenerator = new QRCodeGenerator();
            using var qrCodeData = qrGenerator.CreateQrCode(texto, QRCodeGenerator.ECCLevel.Q);
            using var qrCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeImage = qrCode.GetGraphic(20);
            return new Image(ImageDataFactory.Create(qrCodeImage));
        }

        private static string GenerateQrCodeUrl(Comprobante comprobante)
        {
            return $"https://verificacfdi.facturaelectronica.sat.gob.mx/default.aspx?id={comprobante.TimbreFiscalDigital.UUID}&re={comprobante.Emisor.Rfc}&rr={comprobante.Receptor.Rfc}&tt={comprobante.Total}&fe={comprobante.TimbreFiscalDigital.SelloCFD?.Substring(336)}";
        }

        private static void AddTableCells(Table table, string[] texts, PdfFont font, float fontSize, DeviceRgb backgroundColor = null, bool isHeader = false)
        {
            foreach (var text in texts)
            {
                Cell cell = new Cell().Add(new Paragraph(text))
                    .SetFont(font)
                    .SetFontSize(fontSize)
                    .SetBorder(Border.NO_BORDER);

                if (backgroundColor != null)
                    cell.SetBackgroundColor(backgroundColor);

                if (isHeader)
                    cell.SetFontColor(ColorConstants.WHITE);

                table.AddCell(cell);
            }
        }

        private static void AddEntityDetail(Table table, string label, string emisorDetail, string receptorDetail, PdfFont bold, PdfFont normal)
        {
            table.AddCell(new Cell().Add(new Paragraph(label + emisorDetail))
                .SetBorder(Border.NO_BORDER)
                .SetFont(normal)
                .SetFontSize(8));
            table.AddCell(CreateEmptyCell());
            table.AddCell(new Cell().Add(new Paragraph(label + receptorDetail))
                .SetBorder(Border.NO_BORDER)
                .SetFont(normal)
                .SetFontSize(8));
        }

        private static Cell CreateEmptyCell()
        {
            return new Cell().Add(new Paragraph("")).SetBorder(Border.NO_BORDER);
        }
    }
}
