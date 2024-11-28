using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
public partial class NominaPercepcionesSeparacionIndemnizacion
{
    private decimal totalPagadoField;

    private int numAñosServicioField;

    private decimal ultimoSueldoMensOrdField;

    private decimal ingresoAcumulableField;

    private decimal ingresoNoAcumulableField;

    [XmlAttributeAttribute()]
    public decimal TotalPagado
    {
        get
        {
            return this.totalPagadoField;
        }
        set
        {
            this.totalPagadoField = value;
        }
    }

    [XmlAttributeAttribute()]
    public int NumAñosServicio
    {
        get
        {
            return this.numAñosServicioField;
        }
        set
        {
            this.numAñosServicioField = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal UltimoSueldoMensOrd
    {
        get
        {
            return this.ultimoSueldoMensOrdField;
        }
        set
        {
            this.ultimoSueldoMensOrdField = value;
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
