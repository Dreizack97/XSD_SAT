using System.Xml.Serialization;

[SerializableAttribute()]
[XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
public enum c_TipoDeComprobante
{
    I,
    E,
    T,
    N,
    P,
}
