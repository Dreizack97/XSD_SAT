using System.Xml.Serialization;

[SerializableAttribute()]
[XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
public enum c_RiesgoPuesto
{
    [XmlEnumAttribute("1")]
    Item1,
    [XmlEnumAttribute("2")]
    Item2,
    [XmlEnumAttribute("3")]
    Item3,
    [XmlEnumAttribute("4")]
    Item4,
    [XmlEnumAttribute("5")]
    Item5,
    [XmlEnumAttribute("99")]
    Item99,
}
