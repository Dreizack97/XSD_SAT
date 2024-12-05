using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace XSD.Comprobante.V33
{
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteReceptor
    {
        [XmlAttribute]
        public string Rfc { get; set; }

        [XmlAttribute]
        public string Nombre { get; set; }

        [XmlAttribute]
        public string ResidenciaFiscal { get; set; }

        [XmlIgnore]
        public bool ResidenciaFiscalSpecified { get; set; }

        [XmlAttribute]
        public string NumRegIdTrib { get; set; }

        [XmlAttribute]
        public string UsoCFDI { get; set; }
    }
}
