using System.Reflection;
using System.Xml;
using System.Xml.Serialization;
using XSD.Complemento;
using XSD.Nomina;

namespace CFDI_Reader.Utilities
{
    public static class XmlToComprobante
    {
        public static T ComprobanteFromXml<T>(string xmlFilePath) where T : class
        {
            T comprobante;
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (StreamReader streamReader = new StreamReader(xmlFilePath))
            {
                comprobante = (T)serializer.Deserialize(streamReader);

                PropertyInfo complementoProperty = comprobante.GetType().GetProperty("Complemento");
                var complementoValue = complementoProperty?.GetValue(comprobante) as dynamic;

                if (complementoValue?.Any != null)
                {
                    foreach (XmlElement complementoInterior in complementoValue.Any)
                    {
                        if (complementoInterior.Name.Contains("Nomina"))
                        {
                            DeserializeAndAssignComplemento(comprobante, complementoInterior, typeof(Nomina), "Nomina");
                        }

                        if (complementoInterior.Name.Contains("TimbreFiscalDigital"))
                        {
                            DeserializeAndAssignComplemento(comprobante, complementoInterior, typeof(TimbreFiscalDigital), "TimbreFiscalDigital");
                        }
                    }
                }
            }

            return comprobante;
        }

        private static void DeserializeAndAssignComplemento(object comprobante, XmlElement complementoInterior, Type complementoType, string propertyName)
        {
            XmlSerializer serializerComplemento = new XmlSerializer(complementoType);

            using (StringReader complemento = new StringReader(complementoInterior.OuterXml))
            {
                var complementoObject = serializerComplemento.Deserialize(complemento);

                var property = comprobante.GetType().GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(comprobante, complementoObject);
                }
            }
        }
    }
}
