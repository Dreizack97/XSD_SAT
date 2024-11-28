using System.Xml.Serialization;

[Serializable()]
[XmlType(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
public enum c_TipoOtroPago
{
    [XmlEnum("001")]
    Item001,
    [XmlEnum("002")]
    Item002,
    [XmlEnum("003")]
    Item003,
    [XmlEnum("004")]
    Item004,
    [XmlEnum("005")]
    Item005,
    [XmlEnum("006")]
    Item006,
    [XmlEnum("007")]
    Item007,
    [XmlEnum("008")]
    Item008,
    [XmlEnum("009")]
    Item009,
    [XmlEnum("999")]
    Item999,
}
