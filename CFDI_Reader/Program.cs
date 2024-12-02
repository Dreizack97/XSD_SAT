using System.Xml;
using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            string xmlFilePath = @"C:\Users\Jorge Silva\Downloads\Semanal047\CFDI_Semanal047001467.xml";

            // Usar este procedimiento para leer XML de facturas de compras.
            //XSD.Comprobante.Comprobante comprobante = Read_CFDI(xmlFilePath);

            // Usar este procedimiento para leer XML de recibos de nómina
            XSD.Nomina.Comprobante comprobante = Read_CFDI_Nomina(xmlFilePath);

            // Manipula el comprobante
            Console.WriteLine(comprobante.Total);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.InnerException);
        }

        Console.Write("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }

    public static XSD.Comprobante.Comprobante Read_CFDI(string xmlFilePath)
    {
        XSD.Comprobante.Comprobante comprobante = new XSD.Comprobante.Comprobante();
        XmlSerializer serializer = new XmlSerializer(typeof(XSD.Comprobante.Comprobante));

        using (StreamReader streamReader = new StreamReader(xmlFilePath))
        {
            comprobante = (XSD.Comprobante.Comprobante?)serializer.Deserialize(streamReader);

            if (comprobante?.Complemento?.Any != null)
            {
                foreach (XmlElement complementoInterior in comprobante.Complemento.Any)
                {
                    if (complementoInterior.Name.Contains("TimbreFiscalDigital"))
                    {
                        XmlSerializer serializerComplemento = new XmlSerializer(typeof(XSD.Complemento.TimbreFiscalDigital));

                        using (StringReader complemento = new StringReader(complementoInterior.OuterXml))
                        {
                            comprobante.TimbreFiscalDigital = (XSD.Complemento.TimbreFiscalDigital)serializerComplemento.Deserialize(complemento);
                        }
                    }
                }
            }
        }

        return comprobante;
    }

    public static XSD.Nomina.Comprobante Read_CFDI_Nomina(string xmlFilePath)
    {
        XSD.Nomina.Comprobante comprobante = new XSD.Nomina.Comprobante();
        XmlSerializer serializer = new XmlSerializer(typeof(XSD.Nomina.Comprobante));

        using (StreamReader streamReader = new StreamReader(xmlFilePath))
        {
            comprobante = (XSD.Nomina.Comprobante)serializer.Deserialize(streamReader);

            if (comprobante?.Complemento?.Any != null)
            {
                foreach (XmlElement complementoInterior in comprobante.Complemento.Any)
                {
                    if (complementoInterior.Name.Contains("Nomina"))
                    {
                        XmlSerializer serializerComplemento = new XmlSerializer(typeof(XSD.Nomina.Nomina));

                        using (StringReader complemento = new StringReader(complementoInterior.OuterXml))
                        {
                            comprobante.Nomina = (XSD.Nomina.Nomina)serializerComplemento.Deserialize(complemento);
                        }
                    }

                    if (complementoInterior.Name.Contains("TimbreFiscalDigital"))
                    {
                        XmlSerializer serializerComplemento = new XmlSerializer(typeof(XSD.Complemento.TimbreFiscalDigital));

                        using (StringReader complemento = new StringReader(complementoInterior.OuterXml))
                        {
                            comprobante.TimbreFiscalDigital = (XSD.Complemento.TimbreFiscalDigital)serializerComplemento.Deserialize(complemento);
                        }
                    }
                }
            }
        }

        return comprobante;
    }
}