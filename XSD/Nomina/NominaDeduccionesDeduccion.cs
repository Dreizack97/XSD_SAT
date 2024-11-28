using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
public partial class NominaDeduccionesDeduccion
{
    private c_TipoDeduccion tipoDeduccionField;

    private string claveField;

    private string conceptoField;

    private decimal importeField;

    [XmlAttributeAttribute()]
    public c_TipoDeduccion TipoDeduccion
    {
        get
        {
            return this.tipoDeduccionField;
        }
        set
        {
            this.tipoDeduccionField = value;
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
    public decimal Importe
    {
        get
        {
            return this.importeField;
        }
        set
        {
            this.importeField = value;
        }
    }
}
