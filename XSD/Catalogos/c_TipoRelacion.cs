using System.Xml.Serialization;

[Serializable()]
[XmlType(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
public enum c_TipoRelacion
{
    [XmlEnum("01")]
    Item01,
    [XmlEnum("02")]
    Item02,
    [XmlEnum("03")]
    Item03,
    [XmlEnum("04")]
    Item04,
    [XmlEnum("05")]
    Item05,
    [XmlEnum("06")]
    Item06,
    [XmlEnum("07")]
    Item07,
    [XmlEnum("08")]
    Item08,
    [XmlEnum("09")]
    Item09,
}
