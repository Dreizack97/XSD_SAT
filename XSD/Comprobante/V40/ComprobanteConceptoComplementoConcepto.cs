﻿using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace XSD.Comprobante.V40
{
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoComplementoConcepto
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; } = Array.Empty<XmlElement>();
    }
}