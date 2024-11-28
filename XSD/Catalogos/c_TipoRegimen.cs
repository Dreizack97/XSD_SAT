using System.Xml.Serialization;

[SerializableAttribute()]
[XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
public enum c_TipoRegimen
{
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
    [XmlEnumAttribute("09")]
    Item09,
    [XmlEnumAttribute("10")]
    Item10,
    [XmlEnumAttribute("11")]
    Item11,
    [XmlEnumAttribute("12")]
    Item12,
    [XmlEnumAttribute("13")]
    Item13,
    [XmlEnumAttribute("99")]
    Item99,
}
