using System.Xml.Serialization;

namespace XSD.Catalogos
{
    [Serializable()]
    [XmlType(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
    public enum c_RiesgoPuesto
    {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
        [XmlEnum("3")]
        Item3,
        [XmlEnum("4")]
        Item4,
        [XmlEnum("5")]
        Item5,
        [XmlEnum("99")]
        Item99,
    }
}