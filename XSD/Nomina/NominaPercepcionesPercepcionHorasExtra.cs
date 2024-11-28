using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
public partial class NominaPercepcionesPercepcionHorasExtra
{
    private int diasField;

    private c_TipoHoras tipoHorasField;

    private int horasExtraField;

    private decimal importePagadoField;

    [XmlAttributeAttribute()]
    public int Dias
    {
        get
        {
            return this.diasField;
        }
        set
        {
            this.diasField = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_TipoHoras TipoHoras
    {
        get
        {
            return this.tipoHorasField;
        }
        set
        {
            this.tipoHorasField = value;
        }
    }

    [XmlAttributeAttribute()]
    public int HorasExtra
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
    public decimal ImportePagado
    {
        get
        {
            return this.importePagadoField;
        }
        set
        {
            this.importePagadoField = value;
        }
    }
}
