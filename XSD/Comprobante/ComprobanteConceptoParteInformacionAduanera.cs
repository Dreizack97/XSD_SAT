using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteConceptoParteInformacionAduanera
{
    private string numeroPedimentoField;

    [XmlAttributeAttribute()]
    public string NumeroPedimento
    {
        get
        {
            return this.numeroPedimentoField;
        }
        set
        {
            this.numeroPedimentoField = value;
        }
    }
}
