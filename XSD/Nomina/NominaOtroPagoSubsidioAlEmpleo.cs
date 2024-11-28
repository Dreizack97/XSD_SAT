using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
public partial class NominaOtroPagoSubsidioAlEmpleo
{
    private decimal subsidioCausadoField;

    [XmlAttributeAttribute()]
    public decimal SubsidioCausado
    {
        get
        {
            return this.subsidioCausadoField;
        }
        set
        {
            this.subsidioCausadoField = value;
        }
    }
}
