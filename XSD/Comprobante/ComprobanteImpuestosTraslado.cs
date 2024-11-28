using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteImpuestosTraslado
{
    private decimal baseField;

    private c_Impuesto impuestoField;

    private c_TipoFactor tipoFactorField;

    private decimal tasaOCuotaField;

    private bool tasaOCuotaFieldSpecified;

    private decimal importeField;

    private bool importeFieldSpecified;

    [XmlAttributeAttribute()]
    public decimal Base
    {
        get
        {
            return this.baseField;
        }
        set
        {
            this.baseField = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_Impuesto Impuesto
    {
        get
        {
            return this.impuestoField;
        }
        set
        {
            this.impuestoField = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_TipoFactor TipoFactor
    {
        get
        {
            return this.tipoFactorField;
        }
        set
        {
            this.tipoFactorField = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal TasaOCuota
    {
        get
        {
            return this.tasaOCuotaField;
        }
        set
        {
            this.tasaOCuotaField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool TasaOCuotaSpecified
    {
        get
        {
            return this.tasaOCuotaFieldSpecified;
        }
        set
        {
            this.tasaOCuotaFieldSpecified = value;
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

    [XmlIgnoreAttribute()]
    public bool ImporteSpecified
    {
        get
        {
            return this.importeFieldSpecified;
        }
        set
        {
            this.importeFieldSpecified = value;
        }
    }
}
