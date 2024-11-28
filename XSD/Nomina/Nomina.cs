using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
[XmlRootAttribute(Namespace = "http://www.sat.gob.mx/nomina12", IsNullable = false)]
public partial class Nomina
{
    private NominaEmisor emisorField;

    private NominaReceptor receptorField;

    private NominaPercepciones percepcionesField;

    private NominaDeducciones deduccionesField;

    private NominaOtroPago[] otrosPagosField;

    private NominaIncapacidad[] incapacidadesField;

    private string versionField;

    private c_TipoNomina tipoNominaField;

    private System.DateTime fechaPagoField;

    private System.DateTime fechaInicialPagoField;

    private System.DateTime fechaFinalPagoField;

    private decimal numDiasPagadosField;

    private decimal totalPercepcionesField;

    private bool totalPercepcionesFieldSpecified;

    private decimal totalDeduccionesField;

    private bool totalDeduccionesFieldSpecified;

    private decimal totalOtrosPagosField;

    private bool totalOtrosPagosFieldSpecified;

    public Nomina()
    {
        this.versionField = "1.2";
    }

    public NominaEmisor Emisor
    {
        get
        {
            return this.emisorField;
        }
        set
        {
            this.emisorField = value;
        }
    }

    public NominaReceptor Receptor
    {
        get
        {
            return this.receptorField;
        }
        set
        {
            this.receptorField = value;
        }
    }

    public NominaPercepciones Percepciones
    {
        get
        {
            return this.percepcionesField;
        }
        set
        {
            this.percepcionesField = value;
        }
    }

    public NominaDeducciones Deducciones
    {
        get
        {
            return this.deduccionesField;
        }
        set
        {
            this.deduccionesField = value;
        }
    }

    [XmlArrayItemAttribute("OtroPago", IsNullable = false)]
    public NominaOtroPago[] OtrosPagos
    {
        get
        {
            return this.otrosPagosField;
        }
        set
        {
            this.otrosPagosField = value;
        }
    }

    [XmlArrayItemAttribute("Incapacidad", IsNullable = false)]
    public NominaIncapacidad[] Incapacidades
    {
        get
        {
            return this.incapacidadesField;
        }
        set
        {
            this.incapacidadesField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string Version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_TipoNomina TipoNomina
    {
        get
        {
            return this.tipoNominaField;
        }
        set
        {
            this.tipoNominaField = value;
        }
    }

    [XmlAttributeAttribute(DataType = "date")]
    public System.DateTime FechaPago
    {
        get
        {
            return this.fechaPagoField;
        }
        set
        {
            this.fechaPagoField = value;
        }
    }

    [XmlAttributeAttribute(DataType = "date")]
    public System.DateTime FechaInicialPago
    {
        get
        {
            return this.fechaInicialPagoField;
        }
        set
        {
            this.fechaInicialPagoField = value;
        }
    }

    [XmlAttributeAttribute(DataType = "date")]
    public System.DateTime FechaFinalPago
    {
        get
        {
            return this.fechaFinalPagoField;
        }
        set
        {
            this.fechaFinalPagoField = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal NumDiasPagados
    {
        get
        {
            return this.numDiasPagadosField;
        }
        set
        {
            this.numDiasPagadosField = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal TotalPercepciones
    {
        get
        {
            return this.totalPercepcionesField;
        }
        set
        {
            this.totalPercepcionesField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool TotalPercepcionesSpecified
    {
        get
        {
            return this.totalPercepcionesFieldSpecified;
        }
        set
        {
            this.totalPercepcionesFieldSpecified = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal TotalDeducciones
    {
        get
        {
            return this.totalDeduccionesField;
        }
        set
        {
            this.totalDeduccionesField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool TotalDeduccionesSpecified
    {
        get
        {
            return this.totalDeduccionesFieldSpecified;
        }
        set
        {
            this.totalDeduccionesFieldSpecified = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal TotalOtrosPagos
    {
        get
        {
            return this.totalOtrosPagosField;
        }
        set
        {
            this.totalOtrosPagosField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool TotalOtrosPagosSpecified
    {
        get
        {
            return this.totalOtrosPagosFieldSpecified;
        }
        set
        {
            this.totalOtrosPagosFieldSpecified = value;
        }
    }
}
