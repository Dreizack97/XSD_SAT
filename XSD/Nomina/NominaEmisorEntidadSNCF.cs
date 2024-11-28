using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
public partial class NominaEmisorEntidadSNCF
{
    private c_OrigenRecurso origenRecursoField;

    private decimal montoRecursoPropioField;

    private bool montoRecursoPropioFieldSpecified;

    [XmlAttributeAttribute()]
    public c_OrigenRecurso OrigenRecurso
    {
        get
        {
            return this.origenRecursoField;
        }
        set
        {
            this.origenRecursoField = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal MontoRecursoPropio
    {
        get
        {
            return this.montoRecursoPropioField;
        }
        set
        {
            this.montoRecursoPropioField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool MontoRecursoPropioSpecified
    {
        get
        {
            return this.montoRecursoPropioFieldSpecified;
        }
        set
        {
            this.montoRecursoPropioFieldSpecified = value;
        }
    }
}
