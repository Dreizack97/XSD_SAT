using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
public partial class NominaOtroPago
{
    private NominaOtroPagoSubsidioAlEmpleo subsidioAlEmpleoField;

    private NominaOtroPagoCompensacionSaldosAFavor compensacionSaldosAFavorField;

    private c_TipoOtroPago tipoOtroPagoField;

    private string claveField;

    private string conceptoField;

    private decimal importeField;

    public NominaOtroPagoSubsidioAlEmpleo SubsidioAlEmpleo
    {
        get
        {
            return this.subsidioAlEmpleoField;
        }
        set
        {
            this.subsidioAlEmpleoField = value;
        }
    }

    public NominaOtroPagoCompensacionSaldosAFavor CompensacionSaldosAFavor
    {
        get
        {
            return this.compensacionSaldosAFavorField;
        }
        set
        {
            this.compensacionSaldosAFavorField = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_TipoOtroPago TipoOtroPago
    {
        get
        {
            return this.tipoOtroPagoField;
        }
        set
        {
            this.tipoOtroPagoField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string Clave
    {
        get
        {
            return this.claveField;
        }
        set
        {
            this.claveField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string Concepto
    {
        get
        {
            return this.conceptoField;
        }
        set
        {
            this.conceptoField = value;
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
}
