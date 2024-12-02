using System.Xml.Serialization;

namespace XSD.Catalogos
{
    [Serializable()]
    [XmlType(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
    public enum c_ObjetoImp
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
    }
}
