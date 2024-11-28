using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteInformacionGlobal
{
    private c_Periodicidad periodicidadField;

    private c_Meses mesesField;

    private short añoField;

    [XmlAttributeAttribute()]
    public c_Periodicidad Periodicidad
    {
        get
        {
            return this.periodicidadField;
        }
        set
        {
            this.periodicidadField = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_Meses Meses
    {
        get
        {
            return this.mesesField;
        }
        set
        {
            this.mesesField = value;
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
}
