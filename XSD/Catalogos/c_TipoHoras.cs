using System.Xml.Serialization;

[Serializable()]
[XmlType(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
public enum c_TipoHoras
{
    [XmlEnum("01")]
    Item01,
    [XmlEnum("02")]
    Item02,
    [XmlEnum("03")]
    Item03,
}
