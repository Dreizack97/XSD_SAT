using System.Xml.Serialization;

[Serializable()]
[XmlType(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
public enum c_TipoFactor
{
    Tasa,
    Cuota,
    Exento,
}
