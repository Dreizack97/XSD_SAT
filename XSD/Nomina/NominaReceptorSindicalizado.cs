using System.Xml.Serialization;

namespace XSD.Nomina
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
    public enum NominaReceptorSindicalizado
    {
        Sí,

        No,
    }
}
