using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
public partial class NominaPercepciones
{
    private NominaPercepcionesPercepcion[] percepcionField;

    private NominaPercepcionesJubilacionPensionRetiro jubilacionPensionRetiroField;

    private NominaPercepcionesSeparacionIndemnizacion separacionIndemnizacionField;

    private decimal totalSueldosField;

    private bool totalSueldosFieldSpecified;

    private decimal totalSeparacionIndemnizacionField;

    private bool totalSeparacionIndemnizacionFieldSpecified;

    private decimal totalJubilacionPensionRetiroField;

    private bool totalJubilacionPensionRetiroFieldSpecified;

    private decimal totalGravadoField;

    private decimal totalExentoField;

    [XmlElementAttribute("Percepcion")]
    public NominaPercepcionesPercepcion[] Percepcion
    {
        get
        {
            return this.percepcionField;
        }
        set
        {
            this.percepcionField = value;
        }
    }

    public NominaPercepcionesJubilacionPensionRetiro JubilacionPensionRetiro
    {
        get
        {
            return this.jubilacionPensionRetiroField;
        }
        set
        {
            this.jubilacionPensionRetiroField = value;
        }
    }

    public NominaPercepcionesSeparacionIndemnizacion SeparacionIndemnizacion
    {
        get
        {
            return this.separacionIndemnizacionField;
        }
        set
        {
            this.separacionIndemnizacionField = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal TotalSueldos
    {
        get
        {
            return this.totalSueldosField;
        }
        set
        {
            this.totalSueldosField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool TotalSueldosSpecified
    {
        get
        {
            return this.totalSueldosFieldSpecified;
        }
        set
        {
            this.totalSueldosFieldSpecified = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal TotalSeparacionIndemnizacion
    {
        get
        {
            return this.totalSeparacionIndemnizacionField;
        }
        set
        {
            this.totalSeparacionIndemnizacionField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool TotalSeparacionIndemnizacionSpecified
    {
        get
        {
            return this.totalSeparacionIndemnizacionFieldSpecified;
        }
        set
        {
            this.totalSeparacionIndemnizacionFieldSpecified = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal TotalJubilacionPensionRetiro
    {
        get
        {
            return this.totalJubilacionPensionRetiroField;
        }
        set
        {
            this.totalJubilacionPensionRetiroField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool TotalJubilacionPensionRetiroSpecified
    {
        get
        {
            return this.totalJubilacionPensionRetiroFieldSpecified;
        }
        set
        {
            this.totalJubilacionPensionRetiroFieldSpecified = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal TotalGravado
    {
        get
        {
            return this.totalGravadoField;
        }
        set
        {
            this.totalGravadoField = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal TotalExento
    {
        get
        {
            return this.totalExentoField;
        }
        set
        {
            this.totalExentoField = value;
        }
    }
}
