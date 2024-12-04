using CFDI_Reader;
using XSD.Comprobante;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            string xmlFilePath = @"C:\Users\Jorge Silva\Downloads\Semanal047\CFDI_Semanal047001467.xml";
            Comprobante comprobante = XmlToComprobante.Read_CFDI(xmlFilePath);

            // Lee el comprobante
            Console.WriteLine(comprobante.Total);

            // Convertir comprobante a PDF
            ComprobanteToPdf.GeneratePdf(xmlFilePath, comprobante);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.InnerException);
        }

        Console.Write("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
