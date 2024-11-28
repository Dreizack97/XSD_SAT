using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
public partial class NominaEmisor
{
    private NominaEmisorEntidadSNCF entidadSNCFField;

    private string curpField;

    private string registroPatronalField;

    private string rfcPatronOrigenField;

    public NominaEmisorEntidadSNCF EntidadSNCF
    {
        get
        {
            return this.entidadSNCFField;
        }
        set
        {
            this.entidadSNCFField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string Curp
    {
        get
        {
            return this.curpField;
        }
        set
        {
            this.curpField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string RegistroPatronal
    {
        get
        {
            return this.registroPatronalField;
        }
        set
        {
            this.registroPatronalField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string RfcPatronOrigen
    {
        get
        {
            return this.rfcPatronOrigenField;
        }
        set
        {
            this.rfcPatronOrigenField = value;
        }
    }
}
