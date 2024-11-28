using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
public partial class NominaIncapacidad
{
    private int diasIncapacidadField;

    private c_TipoIncapacidad tipoIncapacidadField;

    private decimal importeMonetarioField;

    private bool importeMonetarioFieldSpecified;

    [XmlAttributeAttribute()]
    public int DiasIncapacidad
    {
        get
        {
            return this.diasIncapacidadField;
        }
        set
        {
            this.diasIncapacidadField = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_TipoIncapacidad TipoIncapacidad
    {
        get
        {
            return this.tipoIncapacidadField;
        }
        set
        {
            this.tipoIncapacidadField = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal ImporteMonetario
    {
        get
        {
            return this.importeMonetarioField;
        }
        set
        {
            this.importeMonetarioField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool ImporteMonetarioSpecified
    {
        get
        {
            return this.importeMonetarioFieldSpecified;
        }
        set
        {
            this.importeMonetarioFieldSpecified = value;
        }
    }
}
