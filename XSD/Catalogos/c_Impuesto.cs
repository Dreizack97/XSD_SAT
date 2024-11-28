using System.Xml.Serialization;

[SerializableAttribute()]
[XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
public enum c_Impuesto
{
    [XmlEnumAttribute("001")]
    Item001,
    [XmlEnumAttribute("002")]
    Item002,
    [XmlEnumAttribute("003")]
    Item003,
}
