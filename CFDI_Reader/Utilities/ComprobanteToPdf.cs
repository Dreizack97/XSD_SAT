using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using QRCoder;
using XSD.Comprobante.V40;
using static iText.Layout.Borders.Border;
using static iText.Layout.Properties.TextAlignment;
using Image = iText.Layout.Element.Image;

namespace CFDI_Reader.Utilities
{
    public static class ComprobanteToPdf
    {
        public static void GeneratePdf(string path, Comprobante comprobante)
        {
            using (PdfDocument pdfDocument = new PdfDocument(new PdfWriter(path.Replace(".xml", ".pdf"))))
            {
                using (Document document = new Document(pdfDocument))
                {
                    PageSize letterSize = PageSize.LETTER;
                    pdfDocument.SetDefaultPageSize(letterSize);

                    document.SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA));
                    document.SetFontColor(new DeviceRgb(85, 85, 85));

                    Table bodyTable = new Table(UnitValue.CreatePercentArray([49.5F, 1F, 49.5F])).UseAllAvailableWidth();

                    bodyTable.AddCell(EmptyCell());
                    bodyTable.AddCell(EmptyCell());
                    bodyTable.AddCell(new Cell().Add(AddHeaderSection(comprobante)).SetPadding(0).SetBorder(NO_BORDER));

                    bodyTable.AddCell(new Cell().Add(AddCompanySection(comprobante)).SetPadding(0).SetBorder(NO_BORDER));
                    bodyTable.AddCell(EmptyCell());
                    bodyTable.AddCell(new Cell().Add(AddEmployeeSection(comprobante)).SetPadding(0).SetBorder(NO_BORDER));

                    bodyTable.AddCell(new Cell().Add(AddPerceptionsSection(comprobante)).SetPadding(0).SetBorder(NO_BORDER));
                    bodyTable.AddCell(EmptyCell());
                    bodyTable.AddCell(new Cell().Add(AddDeductionsSection(comprobante)).SetPadding(0).SetBorder(NO_BORDER));

                    bodyTable.AddCell(EmptyCell(colspan: 3));
                    bodyTable.AddCell(new Cell(1, 3).Add(AddSummarySection(comprobante)).SetPadding(0).SetBorder(NO_BORDER));

                    document.Add(bodyTable);
                    document.Add(AddFiscalSection(comprobante).SetFixedPosition(36, 36, pdfDocument.GetDefaultPageSize().GetWidth() - 72));
                }
            }
        }

        private static Table AddHeaderSection(Comprobante comprobante)
        {
            Table headerTable = new Table(UnitValue.CreatePercentArray([20, 20, 20, 40])).UseAllAvailableWidth();
            headerTable.AddCell(CreateCell("CFDI de Nómina", true, 9, CENTER, isTitle: true, colspan: 4));
            headerTable.AddCell(CreateCell("Serie", alignment: CENTER));
            headerTable.AddCell(CreateCell("Folio", alignment: CENTER));
            headerTable.AddCell(CreateCell("Lugar", alignment: CENTER));
            headerTable.AddCell(CreateCell("Expedición", alignment: CENTER));
            headerTable.AddCell(CreateCell(comprobante.Serie, true, alignment: CENTER));
            headerTable.AddCell(CreateCell(comprobante.Folio, true, alignment: CENTER));
            headerTable.AddCell(CreateCell(comprobante.LugarExpedicion, true, alignment: CENTER));
            headerTable.AddCell(CreateCell(comprobante.Fecha.ToString("yyyy-MM-ddTHH:mm:ss"), true, alignment: CENTER));

            return headerTable;
        }

        private static Table AddCompanySection(Comprobante comprobante)
        {
            Table companyTable = new Table(1).UseAllAvailableWidth();
            companyTable.AddCell(CreateCell("Datos del emisor", true, 9, CENTER, true));
            companyTable.AddCell(CreateCell(comprobante.Emisor.Nombre, true));
            companyTable.AddCell(CreateCell("RFC " + comprobante.Emisor.Rfc));
            companyTable.AddCell(CreateCell("Régimen fiscal " + RegimenFiscal(comprobante.Emisor.RegimenFiscal)));
            companyTable.AddCell(CreateCell("Registro patronal " + comprobante.Nomina.Emisor.RegistroPatronal));
            companyTable.AddCell(CreateCell("Tipo de nómina " + comprobante.Nomina.TipoNomina));

            return companyTable;
        }

        private static Table AddEmployeeSection(Comprobante comprobante)
        {
            Table employeeTable = new Table(1).UseAllAvailableWidth();
            employeeTable.AddCell(CreateCell("Datos del receptor", true, 9, CENTER, true));
            employeeTable.AddCell(CreateCell(comprobante.Receptor.Nombre, true));
            employeeTable.AddCell(CreateCell($"RFC {comprobante.Receptor.Rfc} CURP {comprobante.Nomina.Receptor.Curp}"));
            employeeTable.AddCell(CreateCell("Régimen " + RegimenFiscal(comprobante.Receptor.RegimenFiscalReceptor)));
            employeeTable.AddCell(CreateCell($"Domicilio {comprobante.Receptor.DomicilioFiscalReceptor} Entidad federativa {comprobante.Nomina.Receptor.ClaveEntFed}"));
            employeeTable.AddCell(CreateCell($"NSS {comprobante.Nomina.Receptor.NumSeguridadSocial} N° de empleado {comprobante.Nomina.Receptor.NumEmpleado}"));
            employeeTable.AddCell(CreateCell($"Departamento {comprobante.Nomina.Receptor.Departamento}"));
            employeeTable.AddCell(CreateCell($"Puesto {comprobante.Nomina.Receptor.Puesto}"));
            employeeTable.AddCell(CreateCell($"Inicio laboral {comprobante.Nomina.Receptor.FechaInicioRelLaboral:yyyy-MM-dd} Antigüedad {comprobante.Nomina.Receptor.Antigüedad}"));

            return employeeTable;
        }

        private static Table AddPerceptionsSection(Comprobante comprobante)
        {
            Table perceptionsTable = new Table(UnitValue.CreatePercentArray([10, 55, 17.5F, 17.5F])).UseAllAvailableWidth();
            perceptionsTable.AddCell(CreateCell("Percepciones", true, 9, CENTER, true, colspan: 4));

            perceptionsTable.AddCell(CreateCell("Tipo", true, 6).SetBorderBottom(new SolidBorder(ColorConstants.GRAY, 0.75F)));
            perceptionsTable.AddCell(CreateCell("Concepto", true, 6).SetBorderBottom(new SolidBorder(ColorConstants.GRAY, 0.75F)));
            perceptionsTable.AddCell(CreateCell("Exento", true, 6).SetBorderBottom(new SolidBorder(ColorConstants.GRAY, 0.75F)));
            perceptionsTable.AddCell(CreateCell("Gravado", true, 6).SetBorderBottom(new SolidBorder(ColorConstants.GRAY, 0.75F)));

            foreach (var percepcion in comprobante.Nomina.Percepciones.Percepcion)
            {
                perceptionsTable.AddCell(CreateCell(percepcion.TipoPercepcion).SetBorderBottom(new SolidBorder(ColorConstants.LIGHT_GRAY, 0.6F)));
                perceptionsTable.AddCell(CreateCell(percepcion.Concepto).SetBorderBottom(new SolidBorder(ColorConstants.LIGHT_GRAY, 0.6F)));
                perceptionsTable.AddCell(CreateCell("$" + percepcion.ImporteExento).SetBorderBottom(new SolidBorder(ColorConstants.LIGHT_GRAY, 0.6F)));
                perceptionsTable.AddCell(CreateCell("$" + percepcion.ImporteGravado).SetBorderBottom(new SolidBorder(ColorConstants.LIGHT_GRAY, 0.6F)));
            }

            perceptionsTable.AddCell(EmptyCell());
            perceptionsTable.AddCell(CreateCell("Total", true, alignment: RIGHT).SetPaddingRight(5));
            perceptionsTable.AddCell(CreateCell("$" + comprobante.Nomina.Percepciones.TotalExento, true));
            perceptionsTable.AddCell(CreateCell("$" + comprobante.Nomina.Percepciones.TotalGravado, true));

            return perceptionsTable;
        }

        private static Table AddDeductionsSection(Comprobante comprobante)
        {
            Table deductionsTable = new Table(UnitValue.CreatePercentArray([10, 75, 15])).UseAllAvailableWidth();
            deductionsTable.AddCell(CreateCell("Deducciones", true, 9, CENTER, true, colspan: 4));

            deductionsTable.AddCell(CreateCell("Tipo", true, 6).SetBorderBottom(new SolidBorder(ColorConstants.GRAY, 0.75F)));
            deductionsTable.AddCell(CreateCell("Concepto", true, 6).SetBorderBottom(new SolidBorder(ColorConstants.GRAY, 0.75F)));
            deductionsTable.AddCell(CreateCell("Importe", true, 6).SetBorderBottom(new SolidBorder(ColorConstants.GRAY, 0.75F)));

            foreach (var deduccion in comprobante.Nomina.Deducciones.Deduccion)
            {
                deductionsTable.AddCell(CreateCell(deduccion.TipoDeduccion).SetBorderBottom(new SolidBorder(ColorConstants.LIGHT_GRAY, 0.6F)));
                deductionsTable.AddCell(CreateCell(deduccion.Concepto).SetBorderBottom(new SolidBorder(ColorConstants.LIGHT_GRAY, 0.6F)));
                deductionsTable.AddCell(CreateCell("$" + deduccion.Importe).SetBorderBottom(new SolidBorder(ColorConstants.LIGHT_GRAY, 0.6F)));
            }

            deductionsTable.AddCell(EmptyCell());
            deductionsTable.AddCell(CreateCell("Total", true, alignment: RIGHT).SetPaddingRight(5));
            deductionsTable.AddCell(CreateCell("$" + comprobante.Descuento, true));

            return deductionsTable;
        }

        private static Table AddSummarySection(Comprobante comprobante)
        {
            Table summaryTable = new Table(UnitValue.CreatePercentArray([16.66F, 16.66F, 16.66F, 16.66F, 16.66F, 16.66F])).UseAllAvailableWidth();
            summaryTable.AddCell(CreateCell("Fecha inicial", true, alignment: CENTER));
            summaryTable.AddCell(CreateCell("Fecha final", true, alignment: CENTER));
            summaryTable.AddCell(CreateCell("Fecha de pago", true, alignment: CENTER));
            summaryTable.AddCell(CreateCell("Días pagados", true, alignment: CENTER));
            summaryTable.AddCell(CreateCell("Salario base", true, alignment: CENTER));
            summaryTable.AddCell(CreateCell("Salario integrado", true, alignment: CENTER));

            summaryTable.AddCell(CreateCell(comprobante.Nomina.FechaInicialPago, alignment: CENTER));
            summaryTable.AddCell(CreateCell(comprobante.Nomina.FechaFinalPago, alignment: CENTER));
            summaryTable.AddCell(CreateCell(comprobante.Nomina.FechaPago, alignment: CENTER));
            summaryTable.AddCell(CreateCell(comprobante.Nomina.NumDiasPagados, alignment: CENTER));
            summaryTable.AddCell(CreateCell("$" + comprobante.Nomina.Receptor.SalarioBaseCotApor, alignment: CENTER));
            summaryTable.AddCell(CreateCell("$" + comprobante.Nomina.Receptor.SalarioDiarioIntegrado, alignment: CENTER));

            summaryTable.AddCell(EmptyCell(colspan: 6));

            summaryTable.AddCell(CreateCell("Subtotal", alignment: RIGHT).SetPaddingRight(5));
            summaryTable.AddCell(CreateCell("$" + comprobante.SubTotal, true));
            summaryTable.AddCell(CreateCell("Descuento", alignment: RIGHT).SetPaddingRight(5));
            summaryTable.AddCell(CreateCell("$" + comprobante.Descuento, true));
            summaryTable.AddCell(CreateCell("Total", fontSize: 10, alignment: RIGHT, isTitle: true).SetPaddingRight(5).SetBorderTopRightRadius(new BorderRadius(0)).SetBorderBottomRightRadius(new BorderRadius(0)));
            summaryTable.AddCell(CreateCell($"${comprobante.Total} {comprobante.Moneda}", true, 10, isTitle: true).SetBorderTopLeftRadius(new BorderRadius(0)).SetBorderBottomLeftRadius(new BorderRadius(0)));

            summaryTable.AddCell(EmptyCell(colspan: 6));

            string leyend = $"Por la presente, hago constar que he recibido de la empresa {comprobante.Emisor.Nombre} la cantidad de ${comprobante.Total} {comprobante.Moneda}, " +
                $"correspondiente a las percepciones que me corresponden por el periodo indicado. Declaro que no existe ningún adeudo pendiente por parte de la empresa " +
                $"hacia mi persona, ya que he recibido la totalidad de los salarios y prestaciones devengados hasta la fecha.";

            summaryTable.AddCell(CreateCell(leyend, fontSize: 6, alignment: JUSTIFIED, colspan: 4));
            summaryTable.AddCell(EmptyCell(colspan: 2));
            summaryTable.AddCell(EmptyCell(colspan: 4));
            summaryTable.AddCell(CreateCell("FIRMA DEL EMPLEADO", true, alignment: CENTER, colspan: 2).SetVerticalAlignment(VerticalAlignment.BOTTOM).SetBorderTop(new SolidBorder(ColorConstants.DARK_GRAY, 0.8F)));

            return summaryTable;
        }

        private static Table AddFiscalSection(Comprobante comprobante)
        {
            Table fiscalTable = new Table(UnitValue.CreatePercentArray([11, 1, 39, 1, 23.5F, 1, 23.5F])).UseAllAvailableWidth();

            string url = $"https://verificacfdi.facturaelectronica.sat.gob.mx/default.aspx?id={comprobante.TimbreFiscalDigital.UUID}&re={comprobante.Emisor.Rfc}" +
                $"&rr={comprobante.Receptor.Rfc}&tt={comprobante.Total}&fe={comprobante.TimbreFiscalDigital.SelloCFD?.Substring(336)}";
            Image qrCode = GenerateQrImage(url);

            fiscalTable.AddCell(new Cell(7, 1).Add(qrCode.ScaleToFit(95, 95)).SetBorder(NO_BORDER).SetPadding(0));
            fiscalTable.AddCell(EmptyCell());
            fiscalTable.AddCell(CreateCell("Folio fiscal", isTitle: true).SetPaddingLeft(5));
            fiscalTable.AddCell(EmptyCell());
            fiscalTable.AddCell(CreateCell("Número de certificado", isTitle: true).SetPaddingLeft(5));
            fiscalTable.AddCell(EmptyCell());
            fiscalTable.AddCell(CreateCell("Timbrado", isTitle: true).SetPaddingLeft(5));

            fiscalTable.AddCell(EmptyCell());
            fiscalTable.AddCell(CreateCell(comprobante.TimbreFiscalDigital.UUID, true));
            fiscalTable.AddCell(EmptyCell());
            fiscalTable.AddCell(CreateCell(comprobante.TimbreFiscalDigital.NoCertificadoSAT));
            fiscalTable.AddCell(EmptyCell());
            fiscalTable.AddCell(CreateCell(comprobante.TimbreFiscalDigital.FechaTimbrado.ToString("yyyy-MM-ddTHH:mm:ss")));

            fiscalTable.AddCell(EmptyCell());
            fiscalTable.AddCell(CreateCell("RFC proveedor de certificación", isTitle: true).SetPaddingLeft(5));
            fiscalTable.AddCell(EmptyCell());
            fiscalTable.AddCell(CreateCell("Sello digital del SAT", isTitle: true).SetPaddingLeft(5));
            fiscalTable.AddCell(EmptyCell());
            fiscalTable.AddCell(CreateCell("Sello digital del CFDI", isTitle: true).SetPaddingLeft(5));

            fiscalTable.AddCell(EmptyCell(rowspan: 3));
            fiscalTable.AddCell(CreateCell(comprobante.TimbreFiscalDigital.RfcProvCertif ?? ""));
            fiscalTable.AddCell(EmptyCell(rowspan: 3));
            fiscalTable.AddCell(CreateCell(comprobante.TimbreFiscalDigital.SelloSAT ?? "", fontSize: 4, rowspan: 3).SetMaxWidth(23F));
            fiscalTable.AddCell(EmptyCell(rowspan: 3));
            fiscalTable.AddCell(CreateCell(comprobante.TimbreFiscalDigital.SelloCFD ?? "", fontSize: 4, rowspan: 3).SetMaxWidth(23F));

            string CadenaTimbre = $"||{comprobante.TimbreFiscalDigital.Version}|{comprobante.TimbreFiscalDigital.UUID}|{comprobante.TimbreFiscalDigital.FechaTimbrado.ToString("yyyy-MM-ddTHH:mm:ss")}|" +
                $"{comprobante.TimbreFiscalDigital.RfcProvCertif}|{comprobante.TimbreFiscalDigital.SelloCFD}|{comprobante.TimbreFiscalDigital.NoCertificadoSAT}||";

            fiscalTable.AddCell(CreateCell("Cadena original del timbre", isTitle: true).SetPaddingLeft(5));
            fiscalTable.AddCell(CreateCell(CadenaTimbre ?? "", fontSize: 4, alignment: JUSTIFIED, rowspan: 3).SetMaxWidth(39F));

            fiscalTable.AddCell(EmptyCell(colspan: 7));

            fiscalTable.AddCell(CreateCell($"Este documento es una representación impresa de un CFDI versión {comprobante.Version}", fontSize: 5, alignment: CENTER, colspan: 7));

            return fiscalTable;
        }

        private static Cell CreateCell(object text, bool isBold = false, float fontSize = 8, TextAlignment alignment = LEFT, bool isTitle = false, int rowspan = 1, int colspan = 1)
        {
            string data = text.ToString()!;

            if (text is DateTime dateTime)
                data = dateTime.ToString("yyyy-MM-dd");

            Cell cell = new Cell(rowspan, colspan).Add(new Paragraph(data)).SetFontSize(fontSize).SetTextAlignment(alignment).SetBorder(NO_BORDER).SetPadding(0);

            if (isBold)
                cell.SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD));

            if (isTitle)
            {
                cell.SetBackgroundColor(new DeviceRgb(220, 221, 226));
                cell.SetBorderRadius(new BorderRadius(2));
            }

            return cell;
        }

        private static Cell EmptyCell(int rowspan = 1, int colspan = 1)
        {
            Cell cell = new Cell(rowspan, colspan).Add(new Paragraph("")).SetBorder(NO_BORDER);
            return cell;
        }

        private static string RegimenFiscal(int regimen)
        {
            return regimen switch
            {
                601 => regimen + " - General de Ley Personas Morales",
                603 => regimen + " - Personas Morales con Fines no Lucrativos",
                605 => regimen + " - Sueldos y Salarios e Ingresos Asimilados a Salarios",
                606 => regimen + " - Arrendamiento",
                607 => regimen + " - Régimen de Enajenación o Adquisición de Bienes",
                608 => regimen + " - Demás ingresos",
                609 => regimen + " - Consolidación",
                610 => regimen + " - Residentes en el Extranjero sin Establecimiento Permanente en México",
                611 => regimen + " - Ingresos por Dividendos (socios y accionistas)",
                612 => regimen + " - Personas Físicas con Actividades Empresariales y Profesionales",
                614 => regimen + " - Ingresos por intereses",
                615 => regimen + " - Régimen de los ingresos por obtención de premios",
                616 => regimen + " - Sin obligaciones fiscales",
                620 => regimen + " - Sociedades Cooperativas de Producción que optan por diferir sus ingresos",
                621 => regimen + " - Incorporación Fiscal",
                622 => regimen + " - Actividades Agrícolas, Ganaderas, Silvícolas y Pesqueras",
                623 => regimen + " - Opcional para Grupos de Sociedades",
                624 => regimen + " - Coordinados",
                625 => regimen + " - Régimen de las Actividades Empresariales con ingresos a través de Plataformas Tecnológicas",
                626 => regimen + " - Régimen Simplificado de Confianza",
                628 => regimen + " - Hidrocarburos",
                629 => regimen + " - De los Regímenes Fiscales Preferentes y de las Empresas Multinacionales",
                630 => regimen + " - Enajenación de acciones en bolsa de valores",
                _ => regimen.ToString(),
            };
        }

        private static Image GenerateQrImage(string texto)
        {
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                using (QRCodeData qRCodeData = qrGenerator.CreateQrCode(texto, QRCodeGenerator.ECCLevel.Q))
                {
                    using (PngByteQRCode qrCode = new PngByteQRCode(qRCodeData))
                    {
                        byte[] qrCodeImage = qrCode.GetGraphic(20, false);
                        ImageData imageData = ImageDataFactory.Create(qrCodeImage.ToArray());
                        return new Image(imageData);
                    }
                }
            }
        }
    }
}
