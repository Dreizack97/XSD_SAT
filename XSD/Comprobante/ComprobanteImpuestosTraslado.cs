using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[Serializable()]
[DebuggerStepThrough()]
[DesignerCategory("code")]
[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteImpuestosTraslado
{
    [XmlAttribute]
    public decimal Base { get; set; }

    [XmlAttribute]
    public c_Impuesto Impuesto { get; set; }

    [XmlAttribute]
    public c_TipoFactor TipoFactor { get; set; }

    [XmlAttribute]
    public decimal TasaOCuota { get; set; }

    [XmlIgnore]
    public bool TasaOCuotaSpecified { get; set; }

    [XmlAttribute]
    public decimal Importe { get; set; }

    [XmlIgnore]
    public bool ImporteSpecified { get; set; }
}
