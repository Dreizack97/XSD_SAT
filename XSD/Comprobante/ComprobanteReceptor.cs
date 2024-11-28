using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteReceptor
{
    private string rfcField;

    private string nombreField;

    private string domicilioFiscalReceptorField;

    private c_Pais residenciaFiscalField;

    private bool residenciaFiscalFieldSpecified;

    private string numRegIdTribField;

    private c_RegimenFiscal regimenFiscalReceptorField;

    private c_UsoCFDI usoCFDIField;

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
    public string DomicilioFiscalReceptor
    {
        get
        {
            return this.domicilioFiscalReceptorField;
        }
        set
        {
            this.domicilioFiscalReceptorField = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_Pais ResidenciaFiscal
    {
        get
        {
            return this.residenciaFiscalField;
        }
        set
        {
            this.residenciaFiscalField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool ResidenciaFiscalSpecified
    {
        get
        {
            return this.residenciaFiscalFieldSpecified;
        }
        set
        {
            this.residenciaFiscalFieldSpecified = value;
        }
    }

    [XmlAttributeAttribute()]
    public string NumRegIdTrib
    {
        get
        {
            return this.numRegIdTribField;
        }
        set
        {
            this.numRegIdTribField = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_RegimenFiscal RegimenFiscalReceptor
    {
        get
        {
            return this.regimenFiscalReceptorField;
        }
        set
        {
            this.regimenFiscalReceptorField = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_UsoCFDI UsoCFDI
    {
        get
        {
            return this.usoCFDIField;
        }
        set
        {
            this.usoCFDIField = value;
        }
    }
}
