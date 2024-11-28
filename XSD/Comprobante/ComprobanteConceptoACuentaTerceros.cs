using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteConceptoACuentaTerceros
{
    private string rfcACuentaTercerosField;

    private string nombreACuentaTercerosField;

    private c_RegimenFiscal regimenFiscalACuentaTercerosField;

    private string domicilioFiscalACuentaTercerosField;

    [XmlAttributeAttribute()]
    public string RfcACuentaTerceros
    {
        get
        {
            return this.rfcACuentaTercerosField;
        }
        set
        {
            this.rfcACuentaTercerosField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string NombreACuentaTerceros
    {
        get
        {
            return this.nombreACuentaTercerosField;
        }
        set
        {
            this.nombreACuentaTercerosField = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_RegimenFiscal RegimenFiscalACuentaTerceros
    {
        get
        {
            return this.regimenFiscalACuentaTercerosField;
        }
        set
        {
            this.regimenFiscalACuentaTercerosField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string DomicilioFiscalACuentaTerceros
    {
        get
        {
            return this.domicilioFiscalACuentaTercerosField;
        }
        set
        {
            this.domicilioFiscalACuentaTercerosField = value;
        }
    }
}
