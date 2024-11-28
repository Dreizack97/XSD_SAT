using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[Serializable()]
[DebuggerStepThrough()]
[DesignerCategory("code")]
[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteInformacionGlobal
{
    [XmlAttribute]
    public c_Periodicidad Periodicidad { get; set; }

    [XmlAttribute]
    public c_Meses Meses { get; set; }

    [XmlAttribute]
    public short Año { get; set; }
}
