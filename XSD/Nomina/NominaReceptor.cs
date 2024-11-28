using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
public partial class NominaReceptor
{
    private NominaReceptorSubContratacion[] subContratacionField;

    private string curpField;

    private string numSeguridadSocialField;

    private System.DateTime fechaInicioRelLaboralField;

    private bool fechaInicioRelLaboralFieldSpecified;

    private string antigüedadField;

    private c_TipoContrato tipoContratoField;

    private NominaReceptorSindicalizado sindicalizadoField;

    private bool sindicalizadoFieldSpecified;

    private c_TipoJornada tipoJornadaField;

    private bool tipoJornadaFieldSpecified;

    private c_TipoRegimen tipoRegimenField;

    private string numEmpleadoField;

    private string departamentoField;

    private string puestoField;

    private c_RiesgoPuesto riesgoPuestoField;

    private bool riesgoPuestoFieldSpecified;

    private c_PeriodicidadPago periodicidadPagoField;

    private c_Banco bancoField;

    private bool bancoFieldSpecified;

    private string cuentaBancariaField;

    private decimal salarioBaseCotAporField;

    private bool salarioBaseCotAporFieldSpecified;

    private decimal salarioDiarioIntegradoField;

    private bool salarioDiarioIntegradoFieldSpecified;

    private c_Estado claveEntFedField;

    [XmlElementAttribute("SubContratacion")]
    public NominaReceptorSubContratacion[] SubContratacion
    {
        get
        {
            return this.subContratacionField;
        }
        set
        {
            this.subContratacionField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string Curp
    {
        get
        {
            return this.curpField;
        }
        set
        {
            this.curpField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string NumSeguridadSocial
    {
        get
        {
            return this.numSeguridadSocialField;
        }
        set
        {
            this.numSeguridadSocialField = value;
        }
    }

    [XmlAttributeAttribute(DataType = "date")]
    public System.DateTime FechaInicioRelLaboral
    {
        get
        {
            return this.fechaInicioRelLaboralField;
        }
        set
        {
            this.fechaInicioRelLaboralField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool FechaInicioRelLaboralSpecified
    {
        get
        {
            return this.fechaInicioRelLaboralFieldSpecified;
        }
        set
        {
            this.fechaInicioRelLaboralFieldSpecified = value;
        }
    }

    [XmlAttributeAttribute()]
    public string Antigüedad
    {
        get
        {
            return this.antigüedadField;
        }
        set
        {
            this.antigüedadField = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_TipoContrato TipoContrato
    {
        get
        {
            return this.tipoContratoField;
        }
        set
        {
            this.tipoContratoField = value;
        }
    }

    [XmlAttributeAttribute()]
    public NominaReceptorSindicalizado Sindicalizado
    {
        get
        {
            return this.sindicalizadoField;
        }
        set
        {
            this.sindicalizadoField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool SindicalizadoSpecified
    {
        get
        {
            return this.sindicalizadoFieldSpecified;
        }
        set
        {
            this.sindicalizadoFieldSpecified = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_TipoJornada TipoJornada
    {
        get
        {
            return this.tipoJornadaField;
        }
        set
        {
            this.tipoJornadaField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool TipoJornadaSpecified
    {
        get
        {
            return this.tipoJornadaFieldSpecified;
        }
        set
        {
            this.tipoJornadaFieldSpecified = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_TipoRegimen TipoRegimen
    {
        get
        {
            return this.tipoRegimenField;
        }
        set
        {
            this.tipoRegimenField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string NumEmpleado
    {
        get
        {
            return this.numEmpleadoField;
        }
        set
        {
            this.numEmpleadoField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string Departamento
    {
        get
        {
            return this.departamentoField;
        }
        set
        {
            this.departamentoField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string Puesto
    {
        get
        {
            return this.puestoField;
        }
        set
        {
            this.puestoField = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_RiesgoPuesto RiesgoPuesto
    {
        get
        {
            return this.riesgoPuestoField;
        }
        set
        {
            this.riesgoPuestoField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool RiesgoPuestoSpecified
    {
        get
        {
            return this.riesgoPuestoFieldSpecified;
        }
        set
        {
            this.riesgoPuestoFieldSpecified = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_PeriodicidadPago PeriodicidadPago
    {
        get
        {
            return this.periodicidadPagoField;
        }
        set
        {
            this.periodicidadPagoField = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_Banco Banco
    {
        get
        {
            return this.bancoField;
        }
        set
        {
            this.bancoField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool BancoSpecified
    {
        get
        {
            return this.bancoFieldSpecified;
        }
        set
        {
            this.bancoFieldSpecified = value;
        }
    }

    [XmlAttributeAttribute(DataType = "integer")]
    public string CuentaBancaria
    {
        get
        {
            return this.cuentaBancariaField;
        }
        set
        {
            this.cuentaBancariaField = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal SalarioBaseCotApor
    {
        get
        {
            return this.salarioBaseCotAporField;
        }
        set
        {
            this.salarioBaseCotAporField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool SalarioBaseCotAporSpecified
    {
        get
        {
            return this.salarioBaseCotAporFieldSpecified;
        }
        set
        {
            this.salarioBaseCotAporFieldSpecified = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal SalarioDiarioIntegrado
    {
        get
        {
            return this.salarioDiarioIntegradoField;
        }
        set
        {
            this.salarioDiarioIntegradoField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool SalarioDiarioIntegradoSpecified
    {
        get
        {
            return this.salarioDiarioIntegradoFieldSpecified;
        }
        set
        {
            this.salarioDiarioIntegradoFieldSpecified = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_Estado ClaveEntFed
    {
        get
        {
            return this.claveEntFedField;
        }
        set
        {
            this.claveEntFedField = value;
        }
    }
}
