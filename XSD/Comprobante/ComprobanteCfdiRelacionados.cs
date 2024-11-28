using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteCfdiRelacionados
{
    private ComprobanteCfdiRelacionadosCfdiRelacionado[] cfdiRelacionadoField;

    private c_TipoRelacion tipoRelacionField;

    [XmlElementAttribute("CfdiRelacionado")]
    public ComprobanteCfdiRelacionadosCfdiRelacionado[] CfdiRelacionado
    {
        get
        {
            return this.cfdiRelacionadoField;
        }
        set
        {
            this.cfdiRelacionadoField = value;
        }
    }


    [XmlAttributeAttribute()]
    public c_TipoRelacion TipoRelacion
    {
        get
        {
            return this.tipoRelacionField;
        }
        set
        {
            this.tipoRelacionField = value;
        }
    }
}
