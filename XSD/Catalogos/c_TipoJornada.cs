using System.Xml.Serialization;

[SerializableAttribute()]
[XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
public enum c_TipoJornada
{
    [XmlEnumAttribute("01")]
    Item01,
    [XmlEnumAttribute("02")]
    Item02,
    [XmlEnumAttribute("03")]
    Item03,
    [XmlEnumAttribute("04")]
    Item04,
    [XmlEnumAttribute("05")]
    Item05,
    [XmlEnumAttribute("06")]
    Item06,
    [XmlEnumAttribute("07")]
    Item07,
    [XmlEnumAttribute("08")]
    Item08,
    [XmlEnumAttribute("99")]
    Item99,
}
