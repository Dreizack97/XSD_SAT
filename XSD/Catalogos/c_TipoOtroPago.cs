using System.Xml.Serialization;

[SerializableAttribute()]
[XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
public enum c_TipoOtroPago
{
    [XmlEnumAttribute("001")]
    Item001,
    [XmlEnumAttribute("002")]
    Item002,
    [XmlEnumAttribute("003")]
    Item003,
    [XmlEnumAttribute("004")]
    Item004,
    [XmlEnumAttribute("005")]
    Item005,
    [XmlEnumAttribute("006")]
    Item006,
    [XmlEnumAttribute("007")]
    Item007,
    [XmlEnumAttribute("008")]
    Item008,
    [XmlEnumAttribute("009")]
    Item009,
    [XmlEnumAttribute("999")]
    Item999,
}
