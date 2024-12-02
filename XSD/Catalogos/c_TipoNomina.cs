using System.Xml.Serialization;

namespace XSD.Catalogos
{
    [Serializable()]
    [XmlType(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
    public enum c_TipoNomina
    {
        O,
        E,
    }
}
