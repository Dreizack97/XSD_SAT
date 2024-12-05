using System.Xml;
using CFDI_Reader.Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            string xmlFilePath = @"C:\Users\Jorge Silva\Downloads\Semanal047\CFDI_Semanal047001467.xml";

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlFilePath);

            XmlNode versionNode = xmlDocument.SelectSingleNode("//*[local-name() = 'Comprobante']/@Version");

            if (versionNode != null)
            {
                if (versionNode.Value.Equals("3.3"))
                {
                    var comprobante = XmlToComprobante.ComprobanteFromXml<XSD.Comprobante.V33.Comprobante>(xmlFilePath);
                    Console.WriteLine(comprobante.Total);
                    ComprobanteToPdf.GeneratePdf33(xmlFilePath, comprobante);
                }
                else if (versionNode.Value.Equals("4.0"))
                {
                    var comprobante = XmlToComprobante.ComprobanteFromXml<XSD.Comprobante.V40.Comprobante>(xmlFilePath);
                    Console.WriteLine(comprobante.Total);
                    ComprobanteToPdf.GeneratePdf40(xmlFilePath, comprobante);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.InnerException);
        }

        Console.Write("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
