using System.Xml;
using System.Xml.Serialization;
using XSD.Complemento;
using XSD.Comprobante;
using XSD.Nomina;

namespace CFDI_Reader
{
    public static class XmlToComprobante
    {
        public static Comprobante Read_CFDI(string xmlFilePath)
        {
            Comprobante comprobante = new Comprobante();
            XmlSerializer serializer = new XmlSerializer(typeof(Comprobante));

            using (StreamReader streamReader = new StreamReader(xmlFilePath))
            {
                comprobante = (Comprobante)serializer.Deserialize(streamReader);

                if (comprobante?.Complemento?.Any != null)
                {
                    foreach (XmlElement complementoInterior in comprobante.Complemento.Any)
                    {
                        if (complementoInterior.Name.Contains("Nomina"))
                        {
                            XmlSerializer serializerComplemento = new XmlSerializer(typeof(Nomina));

                            using (StringReader complemento = new StringReader(complementoInterior.OuterXml))
                            {
                                comprobante.Nomina = (Nomina)serializerComplemento.Deserialize(complemento);
                            }
                        }

                        if (complementoInterior.Name.Contains("TimbreFiscalDigital"))
                        {
                            XmlSerializer serializerComplemento = new XmlSerializer(typeof(TimbreFiscalDigital));

                            using (StringReader complemento = new StringReader(complementoInterior.OuterXml))
                            {
                                comprobante.TimbreFiscalDigital = (TimbreFiscalDigital)serializerComplemento.Deserialize(complemento);
                            }
                        }
                    }
                }
            }

            return comprobante;
        }
    }
}
