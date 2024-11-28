using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
public partial class NominaDeducciones
{
    private NominaDeduccionesDeduccion[] deduccionField;

    private decimal totalOtrasDeduccionesField;

    private bool totalOtrasDeduccionesFieldSpecified;

    private decimal totalImpuestosRetenidosField;

    private bool totalImpuestosRetenidosFieldSpecified;

    [XmlElementAttribute("Deduccion")]
    public NominaDeduccionesDeduccion[] Deduccion
    {
        get
        {
            return this.deduccionField;
        }
        set
        {
            this.deduccionField = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal TotalOtrasDeducciones
    {
        get
        {
            return this.totalOtrasDeduccionesField;
        }
        set
        {
            this.totalOtrasDeduccionesField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool TotalOtrasDeduccionesSpecified
    {
        get
        {
            return this.totalOtrasDeduccionesFieldSpecified;
        }
        set
        {
            this.totalOtrasDeduccionesFieldSpecified = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal TotalImpuestosRetenidos
    {
        get
        {
            return this.totalImpuestosRetenidosField;
        }
        set
        {
            this.totalImpuestosRetenidosField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool TotalImpuestosRetenidosSpecified
    {
        get
        {
            return this.totalImpuestosRetenidosFieldSpecified;
        }
        set
        {
            this.totalImpuestosRetenidosFieldSpecified = value;
        }
    }
}
