using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteImpuestos
{
    private ComprobanteImpuestosRetencion[] retencionesField;

    private ComprobanteImpuestosTraslado[] trasladosField;

    private decimal totalImpuestosRetenidosField;

    private bool totalImpuestosRetenidosFieldSpecified;

    private decimal totalImpuestosTrasladadosField;

    private bool totalImpuestosTrasladadosFieldSpecified;

    [XmlArrayItemAttribute("Retencion", IsNullable = false)]
    public ComprobanteImpuestosRetencion[] Retenciones
    {
        get
        {
            return this.retencionesField;
        }
        set
        {
            this.retencionesField = value;
        }
    }

    [XmlArrayItemAttribute("Traslado", IsNullable = false)]
    public ComprobanteImpuestosTraslado[] Traslados
    {
        get
        {
            return this.trasladosField;
        }
        set
        {
            this.trasladosField = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal TotalImpuestosRetenidos
    {
        get
        {
            return this.totalImpuestosRetenidosField;
        }
        set
        {
            this.totalImpuestosRetenidosField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool TotalImpuestosRetenidosSpecified
    {
        get
        {
            return this.totalImpuestosRetenidosFieldSpecified;
        }
        set
        {
            this.totalImpuestosRetenidosFieldSpecified = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal TotalImpuestosTrasladados
    {
        get
        {
            return this.totalImpuestosTrasladadosField;
        }
        set
        {
            this.totalImpuestosTrasladadosField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool TotalImpuestosTrasladadosSpecified
    {
        get
        {
            return this.totalImpuestosTrasladadosFieldSpecified;
        }
        set
        {
            this.totalImpuestosTrasladadosFieldSpecified = value;
        }
    }
}
