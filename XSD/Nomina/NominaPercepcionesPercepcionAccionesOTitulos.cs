using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
public partial class NominaPercepcionesPercepcionAccionesOTitulos
{
    private decimal valorMercadoField;

    private decimal precioAlOtorgarseField;

    [XmlAttributeAttribute()]
    public decimal ValorMercado
    {
        get
        {
            return this.valorMercadoField;
        }
        set
        {
            this.valorMercadoField = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal PrecioAlOtorgarse
    {
        get
        {
            return this.precioAlOtorgarseField;
        }
        set
        {
            this.precioAlOtorgarseField = value;
        }
    }
}
