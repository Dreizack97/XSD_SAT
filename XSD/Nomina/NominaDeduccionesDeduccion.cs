﻿using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[Serializable()]
[DebuggerStepThrough()]
[DesignerCategory("code")]
[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
public partial class NominaDeduccionesDeduccion
{
    [XmlAttribute]
    public c_TipoDeduccion TipoDeduccion { get; set; }

    [XmlAttribute]
    public string Clave { get; set; }

    [XmlAttribute]
    public string Concepto { get; set; }

    [XmlAttribute]
    public decimal Importe { get; set; }
}
