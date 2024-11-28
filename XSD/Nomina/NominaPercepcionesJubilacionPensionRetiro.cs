using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
public partial class NominaPercepcionesJubilacionPensionRetiro
{
    private decimal totalUnaExhibicionField;

    private bool totalUnaExhibicionFieldSpecified;

    private decimal totalParcialidadField;

    private bool totalParcialidadFieldSpecified;

    private decimal montoDiarioField;

    private bool montoDiarioFieldSpecified;

    private decimal ingresoAcumulableField;

    private decimal ingresoNoAcumulableField;

    [XmlAttributeAttribute()]
    public decimal TotalUnaExhibicion
    {
        get
        {
            return this.totalUnaExhibicionField;
        }
        set
        {
            this.totalUnaExhibicionField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool TotalUnaExhibicionSpecified
    {
        get
        {
            return this.totalUnaExhibicionFieldSpecified;
        }
        set
        {
            this.totalUnaExhibicionFieldSpecified = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal TotalParcialidad
    {
        get
        {
            return this.totalParcialidadField;
        }
        set
        {
            this.totalParcialidadField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool TotalParcialidadSpecified
    {
        get
        {
            return this.totalParcialidadFieldSpecified;
        }
        set
        {
            this.totalParcialidadFieldSpecified = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal MontoDiario
    {
        get
        {
            return this.montoDiarioField;
        }
        set
        {
            this.montoDiarioField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool MontoDiarioSpecified
    {
        get
        {
            return this.montoDiarioFieldSpecified;
        }
        set
        {
            this.montoDiarioFieldSpecified = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal IngresoAcumulable
    {
        get
        {
            return this.ingresoAcumulableField;
        }
        set
        {
            this.ingresoAcumulableField = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal IngresoNoAcumulable
    {
        get
        {
            return this.ingresoNoAcumulableField;
        }
        set
        {
            this.ingresoNoAcumulableField = value;
        }
    }
}
