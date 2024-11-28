using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteConceptoImpuestos
{
    private ComprobanteConceptoImpuestosTraslado[] trasladosField;

    private ComprobanteConceptoImpuestosRetencion[] retencionesField;

    [XmlArrayItemAttribute("Traslado", IsNullable = false)]
    public ComprobanteConceptoImpuestosTraslado[] Traslados
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

    [XmlArrayItemAttribute("Retencion", IsNullable = false)]
    public ComprobanteConceptoImpuestosRetencion[] Retenciones
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
}
