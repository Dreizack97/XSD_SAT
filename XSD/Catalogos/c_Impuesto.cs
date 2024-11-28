using System.Xml.Serialization;

[Serializable()]
[XmlType(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
public enum c_Impuesto
{
    [XmlEnum("001")]
    Item001,
    [XmlEnum("002")]
    Item002,
    [XmlEnum("003")]
    Item003,
}
