﻿using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using XSD.Complemento;
using XSD.Comprobante;

namespace XSD.Nomina
{
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    [XmlRoot(Namespace = "http://www.sat.gob.mx/cfd/4", IsNullable = false)]
    public partial class Comprobante
    {
        public ComprobanteEmisor Emisor = null!;

        public ComprobanteReceptor Receptor = null!;

        [XmlArrayItem("Concepto", IsNullable = false)]
        public ComprobanteConcepto[] Conceptos { get; set; } = Array.Empty<ComprobanteConcepto>();

        public ComprobanteComplemento Complemento { get; set; }

        public Nomina Nomina { get; set; }

        public TimbreFiscalDigital TimbreFiscalDigital { get; set; }

        [XmlAttribute]
        public string Version { get; set; } = "4.0";

        [XmlAttribute]
        public string Serie { get; set; } = string.Empty;

        [XmlAttribute]
        public string Folio { get; set; } = string.Empty;

        [XmlAttribute]
        public DateTime Fecha { get; set; }

        [XmlAttribute]
        public string Sello { get; set; } = string.Empty;

        [XmlAttribute]
        public string NoCertificado { get; set; } = string.Empty;

        [XmlAttribute]
        public string Certificado { get; set; } = string.Empty;

        [XmlAttribute]
        public decimal SubTotal { get; set; }

        [XmlAttribute]
        public decimal Descuento { get; set; }

        [XmlIgnore]
        public bool DescuentoSpecified { get; set; }

        [XmlAttribute]
        public string Moneda { get; set; }

        [XmlAttribute]
        public decimal Total { get; set; }

        [XmlAttribute]
        public string TipoDeComprobante { get; set; }

        [XmlAttribute]
        public string Exportacion { get; set; }

        [XmlAttribute]
        public string MetodoPago { get; set; }

        [XmlIgnore]
        public bool MetodoPagoSpecified { get; set; }

        [XmlAttribute]
        public int LugarExpedicion { get; set; }
    }
}