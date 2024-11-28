using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
public partial class NominaReceptorSubContratacion
{
    private string rfcLaboraField;

    private decimal porcentajeTiempoField;

    [XmlAttributeAttribute()]
    public string RfcLabora
    {
        get
        {
            return this.rfcLaboraField;
        }
        set
        {
            this.rfcLaboraField = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal PorcentajeTiempo
    {
        get
        {
            return this.porcentajeTiempoField;
        }
        set
        {
            this.porcentajeTiempoField = value;
        }
    }
}
