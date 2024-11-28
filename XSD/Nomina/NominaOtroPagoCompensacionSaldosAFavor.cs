using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
public partial class NominaOtroPagoCompensacionSaldosAFavor
{
    private decimal saldoAFavorField;

    private short añoField;

    private decimal remanenteSalFavField;

    [XmlAttributeAttribute()]
    public decimal SaldoAFavor
    {
        get
        {
            return this.saldoAFavorField;
        }
        set
        {
            this.saldoAFavorField = value;
        }
    }

    [XmlAttributeAttribute()]
    public short Año
    {
        get
        {
            return this.añoField;
        }
        set
        {
            this.añoField = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal RemanenteSalFav
    {
        get
        {
            return this.remanenteSalFavField;
        }
        set
        {
            this.remanenteSalFavField = value;
        }
    }
}
