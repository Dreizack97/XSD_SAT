using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteEmisor
{
    private string rfcField;

    private string nombreField;

    private c_RegimenFiscal regimenFiscalField;

    private string facAtrAdquirenteField;

    [XmlAttributeAttribute()]
    public string Rfc
    {
        get
        {
            return this.rfcField;
        }
        set
        {
            this.rfcField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string Nombre
    {
        get
        {
            return this.nombreField;
        }
        set
        {
            this.nombreField = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_RegimenFiscal RegimenFiscal
    {
        get
        {
            return this.regimenFiscalField;
        }
        set
        {
            this.regimenFiscalField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string FacAtrAdquirente
    {
        get
        {
            return this.facAtrAdquirenteField;
        }
        set
        {
            this.facAtrAdquirenteField = value;
        }
    }
}
