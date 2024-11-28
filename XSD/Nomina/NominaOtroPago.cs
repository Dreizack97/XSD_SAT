using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[Serializable()]
[DebuggerStepThrough()]
[DesignerCategory("code")]
[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
public partial class NominaOtroPago
{
    public NominaOtroPagoSubsidioAlEmpleo SubsidioAlEmpleo { get; set; }

    public NominaOtroPagoCompensacionSaldosAFavor CompensacionSaldosAFavor { get; set; }

    [XmlAttribute]
    public c_TipoOtroPago TipoOtroPago { get; set; }

    [XmlAttribute]
    public string Clave { get; set; }

    [XmlAttribute]
    public string Concepto { get; set; }

    [XmlAttribute]
    public decimal Importe { get; set; }
}
