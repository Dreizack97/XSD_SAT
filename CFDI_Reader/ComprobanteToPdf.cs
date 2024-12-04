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
using XSD.Comprobante;
using XSD.Nomina;
using static iText.Layout.Borders.Border;
using static iText.Layout.Properties.TextAlignment;
using Image = iText.Layout.Element.Image;

namespace CFDI_Reader
{
    public static class ComprobanteToPdf
    {
        public static void GeneratePdf(string path, Comprobante comprobante)
        {
            PdfDocument pdf = new PdfDocument(new PdfWriter(path.ToUpper().Replace(".XML", ".pdf")));
            Document document = new Document(pdf);

            PdfFont bold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont normal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            DeviceRgb gris = new DeviceRgb(220, 221, 226);
            DeviceRgb fontColor = new DeviceRgb(85, 85, 85);

            Table tableBody = new Table(UnitValue.CreatePercentArray(new float[] { 49.5F, 1, 49.5F })).UseAllAvailableWidth();
            tableBody.SetFontColor(fontColor);

            tableBody.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER));
            tableBody.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER));
            tableBody.AddCell(new Cell().Add(new Paragraph("CFDI de Nómina")).SetBorder(NO_BORDER).SetFont(bold).SetFontSize(9).SetTextAlignment(CENTER).SetBackgroundColor(gris).SetBorderRadius(new BorderRadius(5)));

            Table tableInfo = new Table(UnitValue.CreatePercentArray(new float[] { 15, 15, 15, 55 })).UseAllAvailableWidth();

            tableInfo.AddCell(new Cell().Add(new Paragraph("Serie")).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(8).SetPadding(0));
            tableInfo.AddCell(new Cell().Add(new Paragraph("Folio")).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(8).SetPadding(0));
            tableInfo.AddCell(new Cell().Add(new Paragraph("Lugar")).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(8).SetPadding(0));
            tableInfo.AddCell(new Cell().Add(new Paragraph("Fecha y hora")).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(8).SetPadding(0));

            tableInfo.AddCell(new Cell().Add(new Paragraph(comprobante.Serie)).SetBorder(NO_BORDER).SetFont(bold).SetFontSize(8).SetPadding(0));
            tableInfo.AddCell(new Cell().Add(new Paragraph(comprobante.Folio)).SetBorder(NO_BORDER).SetFont(bold).SetFontSize(8).SetPadding(0));
            tableInfo.AddCell(new Cell().Add(new Paragraph(comprobante.LugarExpedicion.ToString())).SetBorder(NO_BORDER).SetFont(bold).SetFontSize(8).SetPadding(0));
            tableInfo.AddCell(new Cell().Add(new Paragraph(comprobante.Fecha.ToString())).SetBorder(NO_BORDER).SetFont(bold).SetFontSize(8).SetPadding(0));

            tableBody.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER));
            tableBody.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER));
            tableBody.AddCell(new Cell().Add(tableInfo).SetBorder(NO_BORDER));

            tableBody.AddCell(new Cell().Add(new Paragraph("Datos del emisor")).SetBorder(NO_BORDER).SetPaddingLeft(5).SetFont(bold).SetFontSize(9).SetBackgroundColor(gris).SetBorderRadius(new BorderRadius(5)));
            tableBody.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER));
            tableBody.AddCell(new Cell().Add(new Paragraph("Datos del receptor")).SetBorder(NO_BORDER).SetPaddingLeft(5).SetFont(bold).SetFontSize(9).SetBackgroundColor(gris).SetBorderRadius(new BorderRadius(5)));

            tableBody.AddCell(new Cell().Add(new Paragraph(comprobante.Emisor.Nombre)).SetBorder(NO_BORDER).SetFont(bold).SetFontSize(8).SetPadding(0));
            tableBody.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tableBody.AddCell(new Cell().Add(new Paragraph(comprobante.Receptor.Nombre)).SetBorder(NO_BORDER).SetFont(bold).SetFontSize(8).SetPadding(0));

            tableBody.AddCell(new Cell().Add(new Paragraph("RFC " + comprobante.Emisor.Rfc)).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(8).SetPadding(0));
            tableBody.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tableBody.AddCell(new Cell().Add(new Paragraph("RFC " + comprobante.Receptor.Rfc + " CURP " + comprobante.Nomina.Receptor.Curp)).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(8).SetPadding(0));

            tableBody.AddCell(new Cell().Add(new Paragraph("Régimen fiscal " + RegimenFiscal(comprobante.Emisor.RegimenFiscal))).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(8).SetPadding(0));
            tableBody.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tableBody.AddCell(new Cell().Add(new Paragraph("Régimen " + RegimenFiscal(comprobante.Receptor.RegimenFiscalReceptor))).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(8).SetPadding(0));

            tableBody.AddCell(new Cell().Add(new Paragraph("Registro patronal " + comprobante.Nomina.Emisor.RegistroPatronal)).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(8).SetPadding(0));
            tableBody.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tableBody.AddCell(new Cell().Add(new Paragraph("Domicilio " + comprobante.Receptor.DomicilioFiscalReceptor + " Entidad Federativa " + comprobante.Nomina.Receptor.ClaveEntFed)).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(8).SetPadding(0));

            tableBody.AddCell(new Cell().Add(new Paragraph("Nómina " + comprobante.Nomina.TipoNomina)).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(8).SetPadding(0));
            tableBody.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tableBody.AddCell(new Cell().Add(new Paragraph("NSS " + comprobante.Nomina.Receptor.NumSeguridadSocial + " N° de empleado " + comprobante.Nomina.Receptor.NumEmpleado)).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(8).SetPadding(0));

            tableBody.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tableBody.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tableBody.AddCell(new Cell().Add(new Paragraph("Departamento " + comprobante.Nomina.Receptor.Departamento)).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(8).SetPadding(0));

            tableBody.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tableBody.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tableBody.AddCell(new Cell().Add(new Paragraph("Puesto " + comprobante.Nomina.Receptor.Puesto)).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(8).SetPadding(0));

            tableBody.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tableBody.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tableBody.AddCell(new Cell().Add(new Paragraph("Inicio laboral " + comprobante.Nomina.Receptor.FechaInicioRelLaboral.ToShortDateString() + " Antigüedad " + comprobante.Nomina.Receptor.Antigüedad)).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(8).SetPadding(0));

            tableBody.AddCell(new Cell().Add(new Paragraph("Percepciones")).SetBorder(NO_BORDER).SetFont(bold).SetFontSize(9).SetBackgroundColor(gris).SetBorderRadius(new BorderRadius(5)).SetTextAlignment(CENTER));
            tableBody.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER));
            tableBody.AddCell(new Cell().Add(new Paragraph("Deducciones")).SetBorder(NO_BORDER).SetFont(bold).SetFontSize(9).SetBackgroundColor(gris).SetBorderRadius(new BorderRadius(5)).SetTextAlignment(CENTER));

            Table tablaPercepciones = new Table(UnitValue.CreatePercentArray(new float[] { 10, 55, 17.5F, 17.5F })).UseAllAvailableWidth();

            tablaPercepciones.AddCell(new Cell().Add(new Paragraph("Tipo")).SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(ColorConstants.BLACK, 1)).SetFont(bold).SetFontSize(6));
            tablaPercepciones.AddCell(new Cell().Add(new Paragraph("Concepto")).SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(ColorConstants.BLACK, 1)).SetFont(bold).SetFontSize(6));
            tablaPercepciones.AddCell(new Cell().Add(new Paragraph("Exento")).SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(ColorConstants.BLACK, 1)).SetFont(bold).SetFontSize(6));
            tablaPercepciones.AddCell(new Cell().Add(new Paragraph("Gravado")).SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(ColorConstants.BLACK, 1)).SetFont(bold).SetFontSize(6));

            foreach (NominaPercepcionesPercepcion percepcion in comprobante.Nomina.Percepciones.Percepcion)
            {
                tablaPercepciones.AddCell(new Cell().Add(new Paragraph(percepcion.TipoPercepcion)).SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(gris, 0.8F)).SetFont(normal).SetFontSize(8));
                tablaPercepciones.AddCell(new Cell().Add(new Paragraph(percepcion.Concepto)).SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(gris, 0.8F)).SetFont(normal).SetFontSize(8));
                tablaPercepciones.AddCell(new Cell().Add(new Paragraph("$" + percepcion.ImporteExento)).SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(gris, 0.8F)).SetFont(normal).SetFontSize(8));
                tablaPercepciones.AddCell(new Cell().Add(new Paragraph("$" + percepcion.ImporteGravado)).SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(gris, 0.8F)).SetFont(normal).SetFontSize(8));
            }

            tablaPercepciones.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(gris, 0.8F)));
            tablaPercepciones.AddCell(new Cell().Add(new Paragraph("Total")).SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(gris, 0.8F)).SetTextAlignment(RIGHT).SetFont(normal).SetFontSize(8));
            tablaPercepciones.AddCell(new Cell().Add(new Paragraph("$" + comprobante.Nomina.Percepciones.TotalExento)).SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(gris, 0.8F)).SetFont(normal).SetFontSize(8));
            tablaPercepciones.AddCell(new Cell().Add(new Paragraph("$" + comprobante.Nomina.Percepciones.TotalGravado)).SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(gris, 0.8F)).SetFont(normal).SetFontSize(8));

            tableBody.AddCell(new Cell().Add(tablaPercepciones).SetBorder(NO_BORDER));
            tableBody.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER));

            Table tablaDeducciones = new Table(UnitValue.CreatePercentArray(new float[] { 10, 75, 15 })).UseAllAvailableWidth();

            tablaDeducciones.AddCell(new Cell().Add(new Paragraph("Tipo")).SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(ColorConstants.BLACK, 1)).SetFont(bold).SetFontSize(6));
            tablaDeducciones.AddCell(new Cell().Add(new Paragraph("Descripción")).SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(ColorConstants.BLACK, 1)).SetFont(bold).SetFontSize(6));
            tablaDeducciones.AddCell(new Cell().Add(new Paragraph("Importe")).SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(ColorConstants.BLACK, 1)).SetFont(bold).SetFontSize(6));

            foreach (NominaDeduccionesDeduccion deduccion in comprobante.Nomina.Deducciones.Deduccion)
            {
                tablaDeducciones.AddCell(new Cell().Add(new Paragraph(deduccion.TipoDeduccion)).SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(gris, 0.8F)).SetFont(normal).SetFontSize(8));
                tablaDeducciones.AddCell(new Cell().Add(new Paragraph(deduccion.Concepto)).SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(gris, 0.8F)).SetFont(normal).SetFontSize(8));
                tablaDeducciones.AddCell(new Cell().Add(new Paragraph("$" + deduccion.Importe)).SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(gris, 0.8F)).SetFont(normal).SetFontSize(8));
            }

            tablaDeducciones.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(gris, 0.8F)));
            tablaDeducciones.AddCell(new Cell().Add(new Paragraph("Total")).SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(gris, 0.8F)).SetTextAlignment(RIGHT).SetFont(normal).SetFontSize(8));
            tablaDeducciones.AddCell(new Cell().Add(new Paragraph("$" + comprobante.Descuento)).SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(gris, 0.8F)).SetFont(normal).SetFontSize(8));

            tableBody.AddCell(new Cell().Add(tablaDeducciones).SetBorder(NO_BORDER));

            Table tablaResumen = new Table(UnitValue.CreatePercentArray(new float[] { 16.66F, 16.66F, 16.66F, 25, 25 })).UseAllAvailableWidth();

            tablaResumen.AddCell(new Cell(1, 5).Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(10));

            tablaResumen.AddCell(new Cell().Add(new Paragraph("Fecha Inicial")).SetBorder(NO_BORDER).SetFont(bold).SetFontSize(8).SetPadding(0));
            tablaResumen.AddCell(new Cell().Add(new Paragraph("Fecha Final")).SetBorder(NO_BORDER).SetFont(bold).SetFontSize(8).SetPadding(0));
            tablaResumen.AddCell(new Cell().Add(new Paragraph("Fecha de Pago")).SetBorder(NO_BORDER).SetFont(bold).SetFontSize(8).SetPadding(0));
            tablaResumen.AddCell(new Cell().Add(new Paragraph("SubTotal")).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(8).SetTextAlignment(RIGHT).SetPadding(0));
            tablaResumen.AddCell(new Cell().Add(new Paragraph("$" + comprobante.SubTotal)).SetBorder(NO_BORDER).SetFont(bold).SetFontSize(8).SetTextAlignment(RIGHT).SetPadding(0));

            tablaResumen.AddCell(new Cell().Add(new Paragraph(comprobante.Nomina.FechaInicialPago.ToShortDateString())).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(8).SetPadding(0));
            tablaResumen.AddCell(new Cell().Add(new Paragraph(comprobante.Nomina.FechaFinalPago.ToShortDateString())).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(8).SetPadding(0));
            tablaResumen.AddCell(new Cell().Add(new Paragraph(comprobante.Nomina.FechaPago.ToShortDateString())).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(8)).SetPadding(0);
            tablaResumen.AddCell(new Cell().Add(new Paragraph("Descuento")).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(8).SetTextAlignment(RIGHT).SetPadding(0));
            tablaResumen.AddCell(new Cell().Add(new Paragraph("$" + comprobante.Descuento)).SetBorder(NO_BORDER).SetFont(bold).SetFontSize(8).SetTextAlignment(RIGHT).SetPadding(0));

            tablaResumen.AddCell(new Cell().Add(new Paragraph("Días Pagados")).SetBorder(NO_BORDER).SetFont(bold).SetFontSize(8).SetPadding(0));
            tablaResumen.AddCell(new Cell().Add(new Paragraph("Salario Base")).SetBorder(NO_BORDER).SetFont(bold).SetFontSize(8).SetPadding(0));
            tablaResumen.AddCell(new Cell().Add(new Paragraph("Salario Integrado")).SetBorder(NO_BORDER).SetFont(bold).SetFontSize(8).SetPadding(0));
            tablaResumen.AddCell(new Cell(2, 1).Add(new Paragraph("Total")).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(14).SetBackgroundColor(gris).SetBorderTopLeftRadius(new BorderRadius(5)).SetBorderBottomLeftRadius(new BorderRadius(5)).SetPadding(0).SetTextAlignment(RIGHT).SetVerticalAlignment(VerticalAlignment.MIDDLE));
            tablaResumen.AddCell(new Cell(2, 1).Add(new Paragraph(comprobante.Moneda + " " + comprobante.Total)).SetBorder(NO_BORDER).SetFont(bold).SetFontSize(14).SetBackgroundColor(gris).SetBorderTopRightRadius(new BorderRadius(5)).SetBorderBottomRightRadius(new BorderRadius(5)).SetPadding(0).SetPaddingRight(10).SetTextAlignment(RIGHT).SetVerticalAlignment(VerticalAlignment.MIDDLE));

            tablaResumen.AddCell(new Cell().Add(new Paragraph(comprobante.Nomina.NumDiasPagados.ToString())).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(8).SetPadding(0));
            tablaResumen.AddCell(new Cell().Add(new Paragraph(comprobante.Nomina.Receptor.SalarioBaseCotApor.ToString())).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(8).SetPadding(0));
            tablaResumen.AddCell(new Cell().Add(new Paragraph(comprobante.Nomina.Receptor.SalarioDiarioIntegrado.ToString())).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(8)).SetPadding(0);

            tablaResumen.AddCell(new Cell(1, 5).Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(10));

            tablaResumen.AddCell(new Cell(1, 4).Add(new Paragraph("RECIBÍ DE LA EMPRESA " + comprobante.Emisor.Nombre + " LA CANTIDAD DE " + comprobante.Moneda + " $" + comprobante.Total + " MISMA QUE CUBREN LAS PERCEPCIONES " +
                "QUE ME CORRESPONDEN EN EL PERIODO INDICADO, NO EXISTIENDO NINGÚN ADEUDO POR PARTE DE LA EMPRESA PARA EL SUSCRITO, PUES ESTOY TOTALMENTE PAGADO DE MIS SALARIOS Y " +
                "PRESTACIONES DEVENGADAS HASTA LA FECHA.")).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(6).SetTextAlignment(JUSTIFIED).SetPadding(0));
            tablaResumen.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tablaResumen.AddCell(new Cell(1, 4).Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tablaResumen.AddCell(new Cell().Add(new Paragraph("FIRMA DEL EMPLEADO")).SetBorder(NO_BORDER).SetFont(bold).SetFontSize(8).SetTextAlignment(CENTER).SetBorderTop(new SolidBorder(ColorConstants.DARK_GRAY, 0.8F)));

            tableBody.AddCell(new Cell(1, 3).Add(tablaResumen).SetBorder(NO_BORDER).SetPadding(0));

            string QR = "https://verificacfdi.facturaelectronica.sat.gob.mx/default.aspx?id=" + comprobante.TimbreFiscalDigital.UUID + "&re=" + comprobante.Emisor.Rfc + "&rr=" + comprobante.Receptor.Rfc + "&tt=" + comprobante.Total + "&fe=" + comprobante.TimbreFiscalDigital.SelloCFD?.Substring(336);

            Image QRImage = GenerarQR(QR);

            Table tablaFiscal = new Table(UnitValue.CreatePercentArray(new float[] { 11, 1, 39, 1, 23, 1, 23 })).UseAllAvailableWidth();

            tablaFiscal.AddCell(new Cell(1, 7).Add(new Paragraph("")).SetBorder(NO_BORDER).SetBorderTop(new SolidBorder(gris, 0.8F)).SetPadding(2));

            tablaFiscal.AddCell(new Cell(7, 1).Add(QRImage.ScaleToFit(95, 95)).SetBorder(NO_BORDER).SetPadding(0));
            tablaFiscal.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tablaFiscal.AddCell(new Cell().Add(new Paragraph("Folio fiscal")).SetBorder(NO_BORDER).SetPadding(0).SetPaddingLeft(5).SetFont(normal).SetFontSize(8).SetBackgroundColor(gris).SetBorderRadius(new BorderRadius(2)));
            tablaFiscal.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tablaFiscal.AddCell(new Cell().Add(new Paragraph("Número de certificado SAT")).SetBorder(NO_BORDER).SetPadding(0).SetPaddingLeft(5).SetFont(normal).SetFontSize(8).SetBackgroundColor(gris).SetBorderRadius(new BorderRadius(2)));
            tablaFiscal.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tablaFiscal.AddCell(new Cell().Add(new Paragraph("Fecha y hora de certificación")).SetBorder(NO_BORDER).SetPadding(0).SetPaddingLeft(5).SetFont(normal).SetFontSize(8).SetBackgroundColor(gris).SetBorderRadius(new BorderRadius(2)));

            tablaFiscal.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tablaFiscal.AddCell(new Cell().Add(new Paragraph(comprobante.TimbreFiscalDigital.UUID ?? "")).SetBorder(NO_BORDER).SetPadding(0).SetFont(bold).SetFontSize(8));
            tablaFiscal.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tablaFiscal.AddCell(new Cell().Add(new Paragraph(comprobante.TimbreFiscalDigital.NoCertificadoSAT ?? "")).SetBorder(NO_BORDER).SetPadding(0).SetFont(normal).SetFontSize(8));
            tablaFiscal.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tablaFiscal.AddCell(new Cell().Add(new Paragraph(comprobante.TimbreFiscalDigital.FechaTimbrado.ToString() ?? "")).SetBorder(NO_BORDER).SetPadding(0).SetFont(normal).SetFontSize(8));

            tablaFiscal.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tablaFiscal.AddCell(new Cell().Add(new Paragraph("RFC proveedor de certificación")).SetBorder(NO_BORDER).SetPadding(0).SetPaddingLeft(5).SetFont(normal).SetFontSize(8).SetBackgroundColor(gris).SetBorderRadius(new BorderRadius(2)));
            tablaFiscal.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tablaFiscal.AddCell(new Cell().Add(new Paragraph("Sello digital del SAT")).SetBorder(NO_BORDER).SetPadding(0).SetPaddingLeft(5).SetFont(normal).SetFontSize(8).SetBackgroundColor(gris).SetBorderRadius(new BorderRadius(2)));
            tablaFiscal.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tablaFiscal.AddCell(new Cell().Add(new Paragraph("Sello digital del CFDI")).SetBorder(NO_BORDER).SetPadding(0).SetPaddingLeft(5).SetFont(normal).SetFontSize(8).SetBackgroundColor(gris).SetBorderRadius(new BorderRadius(2)));

            tablaFiscal.AddCell(new Cell(3, 1).Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tablaFiscal.AddCell(new Cell().Add(new Paragraph(comprobante.TimbreFiscalDigital.RfcProvCertif ?? "")).SetBorder(NO_BORDER).SetPadding(0).SetFont(normal).SetFontSize(8));
            tablaFiscal.AddCell(new Cell(3, 1).Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tablaFiscal.AddCell(new Cell(3, 1).Add(new Paragraph(comprobante.TimbreFiscalDigital.SelloSAT ?? "")).SetBorder(NO_BORDER).SetPadding(0).SetFont(normal).SetFontSize(4).SetMaxWidth(23F).SetTextAlignment(JUSTIFIED));
            tablaFiscal.AddCell(new Cell(3, 1).Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tablaFiscal.AddCell(new Cell(3, 1).Add(new Paragraph(comprobante.TimbreFiscalDigital.SelloCFD ?? "")).SetBorder(NO_BORDER).SetPadding(0).SetFont(normal).SetFontSize(4).SetMaxWidth(23F).SetTextAlignment(JUSTIFIED));

            string CadenaTimbre = "||" + comprobante.TimbreFiscalDigital.Version + "|" + comprobante.TimbreFiscalDigital.UUID + "|" + comprobante.TimbreFiscalDigital.FechaTimbrado + "|" + comprobante.TimbreFiscalDigital.RfcProvCertif + "|" + comprobante.TimbreFiscalDigital.SelloCFD + "|" + comprobante.TimbreFiscalDigital.NoCertificadoSAT + "||";

            tablaFiscal.AddCell(new Cell().Add(new Paragraph("Cadena original del timbre")).SetBorder(NO_BORDER).SetPadding(0).SetPaddingLeft(5).SetFont(normal).SetFontSize(8).SetBackgroundColor(gris).SetBorderRadius(new BorderRadius(2)));
            tablaFiscal.AddCell(new Cell(3, 1).Add(new Paragraph(CadenaTimbre ?? "")).SetBorder(NO_BORDER).SetPadding(0).SetFont(normal).SetFontSize(4).SetMaxWidth(39F).SetTextAlignment(JUSTIFIED));
            tablaFiscal.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tablaFiscal.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tablaFiscal.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tablaFiscal.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));
            tablaFiscal.AddCell(new Cell().Add(new Paragraph("")).SetBorder(NO_BORDER).SetPadding(0));

            tablaFiscal.AddCell(new Cell(1, 7).Add(new Paragraph("Este documento es una representación impresa de un CFDI versión 4.0")).SetBorder(NO_BORDER).SetFont(normal).SetFontSize(6).SetTextAlignment(CENTER));

            document.Add(tableBody);

            document.Add(tablaFiscal.SetFixedPosition(36, 36, pdf.GetDefaultPageSize().GetWidth() - 72));

            document.Close();
        }

        private static string RegimenFiscal(int regimen)
        {
            switch (regimen)
            {
                case 601:
                    return regimen + " - General de Ley Personas Morales";
                case 603:
                    return regimen + " - Personas Morales con Fines no Lucrativos";
                case 605:
                    return regimen + " - Sueldos y Salarios e Ingresos Asimilados a Salarios";
                case 606:
                    return regimen + " - Arrendamiento";
                case 607:
                    return regimen + " - Régimen de Enajenación o Adquisición de Bienes";
                case 608:
                    return regimen + " - Demás ingresos";
                case 609:
                    return regimen + " - Consolidación";
                case 610:
                    return regimen + " - Residentes en el Extranjero sin Establecimiento Permanente en México";
                case 611:
                    return regimen + " - Ingresos por Dividendos (socios y accionistas)";
                case 612:
                    return regimen + " - Personas Físicas con Actividades Empresariales y Profesionales";
                case 614:
                    return regimen + " - Ingresos por intereses";
                case 615:
                    return regimen + " - Régimen de los ingresos por obtención de premios";
                case 616:
                    return regimen + " - Sin obligaciones fiscales";
                case 620:
                    return regimen + " - Sociedades Cooperativas de Producción que optan por diferir sus ingresos";
                case 621:
                    return regimen + " - Incorporación Fiscal";
                case 622:
                    return regimen + " - Actividades Agrícolas, Ganaderas, Silvícolas y Pesqueras";
                case 623:
                    return regimen + " - Opcional para Grupos de Sociedades";
                case 624:
                    return regimen + " - Coordinados";
                case 625:
                    return regimen + " - Régimen de las Actividades Empresariales con ingresos a través de Plataformas Tecnológicas";
                case 626:
                    return regimen + " - Régimen Simplificado de Confianza";
                case 628:
                    return regimen + " - Hidrocarburos";
                case 629:
                    return regimen + " - De los Regímenes Fiscales Preferentes y de las Empresas Multinacionales";
                case 630:
                    return regimen + " - Enajenación de acciones en bolsa de valores";
                default:
                    return regimen.ToString();
            }
        }

        private static Image GenerarQR(string texto)
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
