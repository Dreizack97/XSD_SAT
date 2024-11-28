using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[Serializable()]
[DebuggerStepThrough()]
[DesignerCategory("code")]
[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
public partial class NominaReceptor
{
    [XmlElement("SubContratacion")]
    public NominaReceptorSubContratacion[] SubContratacion { get; set; }

    [XmlAttribute]
    public string Curp { get; set; }

    [XmlAttribute]
    public string NumSeguridadSocial { get; set; }

    [XmlAttribute(DataType = "date")]
    public DateTime FechaInicioRelLaboral { get; set; }

    [XmlIgnore]
    public bool FechaInicioRelLaboralSpecified { get; set; }

    [XmlAttribute]
    public string Antigüedad { get; set; }

    [XmlAttribute]
    public c_TipoContrato TipoContrato { get; set; }

    [XmlAttribute]
    public NominaReceptorSindicalizado Sindicalizado { get; set; }

    [XmlIgnore]
    public bool SindicalizadoSpecified { get; set; }

    [XmlAttribute]
    public c_TipoJornada TipoJornada { get; set; }

    [XmlIgnore]
    public bool TipoJornadaSpecified { get; set; }

    [XmlAttribute]
    public c_TipoRegimen TipoRegimen { get; set; }

    [XmlAttribute]
    public string NumEmpleado { get; set; }

    [XmlAttribute]
    public string Departamento { get; set; }

    [XmlAttribute]
    public string Puesto { get; set; }

    [XmlAttribute]
    public c_RiesgoPuesto RiesgoPuesto { get; set; }

    [XmlIgnore]
    public bool RiesgoPuestoSpecified { get; set; }

    [XmlAttribute]
    public c_PeriodicidadPago PeriodicidadPago { get; set; }

    [XmlAttribute]
    public c_Banco Banco { get; set; }

    [XmlIgnore]
    public bool BancoSpecified { get; set; }

    [XmlAttribute(DataType = "integer")]
    public string CuentaBancaria { get; set; }

    [XmlAttribute]
    public decimal SalarioBaseCotApor { get; set; }

    [XmlIgnore]
    public bool SalarioBaseCotAporSpecified { get; set; }

    [XmlAttribute]
    public decimal SalarioDiarioIntegrado { get; set; }

    [XmlIgnore]
    public bool SalarioDiarioIntegradoSpecified { get; set; }

    [XmlAttribute]
    public c_Estado ClaveEntFed { get; set; }
}
