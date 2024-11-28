using System.Xml.Serialization;

[Serializable()]
[XmlType(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
public enum c_TipoDeComprobante
{
    I,
    E,
    T,
    N,
    P,
}
