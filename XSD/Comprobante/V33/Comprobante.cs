﻿using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using XSD.Complemento;

namespace XSD.Comprobante.V33
{
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    [XmlRoot(Namespace = "http://www.sat.gob.mx/cfd/3", IsNullable = false)]
    public partial class Comprobante
    {
        [XmlElement("CfdiRelacionados")]
        public ComprobanteCfdiRelacionados[] CfdiRelacionados { get; set; } = Array.Empty<ComprobanteCfdiRelacionados>();

        public ComprobanteEmisor Emisor { get; set; } = null!;

        public ComprobanteReceptor Receptor { get; set; } = null;

        [XmlArrayItem("Concepto", IsNullable = false)]
        public ComprobanteConcepto[] Conceptos { get; set; } = Array.Empty<ComprobanteConcepto>();

        public ComprobanteImpuestos? Impuestos { get; set; } = null;

        public ComprobanteComplemento Complemento { get; set; }

        public ComprobanteAddenda? Addenda { get; set; }

        public Nomina.Nomina Nomina { get; set; }

        public TimbreFiscalDigital TimbreFiscalDigital { get; set; }

        [XmlAttribute]
        public string Version { get; set; } = "3.3";

        [XmlAttribute]
        public string Serie { get; set; } = string.Empty;

        [XmlAttribute]
        public string Folio { get; set; } = string.Empty;

        [XmlAttribute]
        public DateTime Fecha { get; set; }

        [XmlAttribute]
        public string Sello { get; set; } = string.Empty;

        [XmlAttribute]
        public string FormaPago { get; set; }

        [XmlIgnore]
        public bool FormaPagoSpecified { get; set; }

        [XmlAttribute]
        public string NoCertificado { get; set; } = string.Empty;

        [XmlAttribute]
        public string Certificado { get; set; } = string.Empty;

        [XmlAttribute]
        public string CondicionesDePago { get; set; } = string.Empty;

        [XmlAttribute]
        public decimal SubTotal { get; set; }

        [XmlAttribute]
        public decimal Descuento { get; set; }

        [XmlIgnore]
        public bool DescuentoSpecified { get; set; }

        [XmlAttribute]
        public string Moneda { get; set; }

        [XmlAttribute]
        public decimal TipoCambio { get; set; }

        [XmlIgnore]
        public bool TipoCambioSpecified { get; set; }

        [XmlAttribute]
        public decimal Total { get; set; }

        [XmlAttribute]
        public string TipoDeComprobante { get; set; }

        [XmlAttribute]
        public string MetodoPago { get; set; }

        [XmlIgnore]
        public bool MetodoPagoSpecified { get; set; }

        [XmlAttribute]
        public int LugarExpedicion { get; set; }

        [XmlAttribute]
        public string? Confirmacion { get; set; }
    }
}
