using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
public partial class NominaPercepcionesPercepcion
{
    private NominaPercepcionesPercepcionAccionesOTitulos accionesOTitulosField;

    private NominaPercepcionesPercepcionHorasExtra[] horasExtraField;

    private c_TipoPercepcion tipoPercepcionField;

    private string claveField;

    private string conceptoField;

    private decimal importeGravadoField;

    private decimal importeExentoField;

    public NominaPercepcionesPercepcionAccionesOTitulos AccionesOTitulos
    {
        get
        {
            return this.accionesOTitulosField;
        }
        set
        {
            this.accionesOTitulosField = value;
        }
    }

    [XmlElementAttribute("HorasExtra")]
    public NominaPercepcionesPercepcionHorasExtra[] HorasExtra
    {
        get
        {
            return this.horasExtraField;
        }
        set
        {
            this.horasExtraField = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_TipoPercepcion TipoPercepcion
    {
        get
        {
            return this.tipoPercepcionField;
        }
        set
        {
            this.tipoPercepcionField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string Clave
    {
        get
        {
            return this.claveField;
        }
        set
        {
            this.claveField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string Concepto
    {
        get
        {
            return this.conceptoField;
        }
        set
        {
            this.conceptoField = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal ImporteGravado
    {
        get
        {
            return this.importeGravadoField;
        }
        set
        {
            this.importeGravadoField = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal ImporteExento
    {
        get
        {
            return this.importeExentoField;
        }
        set
        {
            this.importeExentoField = value;
        }
    }
}
