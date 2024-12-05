using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace XSD.Comprobante.V33
{
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteConceptoImpuestos
    {
        [XmlArrayItem("Traslado", IsNullable = false)]
        public ComprobanteConceptoImpuestosTraslado[] Traslados { get; set; } = Array.Empty<ComprobanteConceptoImpuestosTraslado>();

        [XmlArrayItem("Retencion", IsNullable = false)]
        public ComprobanteConceptoImpuestosRetencion[] Retenciones { get; set; } = Array.Empty<ComprobanteConceptoImpuestosRetencion>();
    }
}
