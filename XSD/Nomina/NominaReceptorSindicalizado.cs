using System.Xml.Serialization;

[SerializableAttribute()]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
public enum NominaReceptorSindicalizado
{
    Sí,

    No,
}
