using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
[XmlRootAttribute(Namespace = "http://www.sat.gob.mx/cfd/4", IsNullable = false)]
public partial class Comprobante
{
    private ComprobanteInformacionGlobal informacionGlobalField;

    private ComprobanteCfdiRelacionados[] cfdiRelacionadosField;

    private ComprobanteEmisor emisorField;

    private ComprobanteReceptor receptorField;

    private ComprobanteConcepto[] conceptosField;

    private ComprobanteImpuestos impuestosField;

    private ComprobanteComplemento complementoField;

    private ComprobanteAddenda addendaField;

    private string versionField;

    private string serieField;

    private string folioField;

    private System.DateTime fechaField;

    private string selloField;

    private c_FormaPago formaPagoField;

    private bool formaPagoFieldSpecified;

    private string noCertificadoField;

    private string certificadoField;

    private string condicionesDePagoField;

    private decimal subTotalField;

    private decimal descuentoField;

    private bool descuentoFieldSpecified;

    private c_Moneda monedaField;

    private decimal tipoCambioField;

    private bool tipoCambioFieldSpecified;

    private decimal totalField;

    private c_TipoDeComprobante tipoDeComprobanteField;

    private c_Exportacion exportacionField;

    private c_MetodoPago metodoPagoField;

    private bool metodoPagoFieldSpecified;

    private c_CodigoPostal lugarExpedicionField;

    private string confirmacionField;

    public Comprobante()
    {
        this.versionField = "4.0";
    }

    public ComprobanteInformacionGlobal InformacionGlobal
    {
        get
        {
            return this.informacionGlobalField;
        }
        set
        {
            this.informacionGlobalField = value;
        }
    }

    [XmlElementAttribute("CfdiRelacionados")]
    public ComprobanteCfdiRelacionados[] CfdiRelacionados
    {
        get
        {
            return this.cfdiRelacionadosField;
        }
        set
        {
            this.cfdiRelacionadosField = value;
        }
    }

    public ComprobanteEmisor Emisor
    {
        get
        {
            return this.emisorField;
        }
        set
        {
            this.emisorField = value;
        }
    }

    public ComprobanteReceptor Receptor
    {
        get
        {
            return this.receptorField;
        }
        set
        {
            this.receptorField = value;
        }
    }

    [XmlArrayItemAttribute("Concepto", IsNullable = false)]
    public ComprobanteConcepto[] Conceptos
    {
        get
        {
            return this.conceptosField;
        }
        set
        {
            this.conceptosField = value;
        }
    }

    public ComprobanteImpuestos Impuestos
    {
        get
        {
            return this.impuestosField;
        }
        set
        {
            this.impuestosField = value;
        }
    }

    public ComprobanteComplemento Complemento
    {
        get
        {
            return this.complementoField;
        }
        set
        {
            this.complementoField = value;
        }
    }

    public ComprobanteAddenda Addenda
    {
        get
        {
            return this.addendaField;
        }
        set
        {
            this.addendaField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string Version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string Serie
    {
        get
        {
            return this.serieField;
        }
        set
        {
            this.serieField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string Folio
    {
        get
        {
            return this.folioField;
        }
        set
        {
            this.folioField = value;
        }
    }

    [XmlAttributeAttribute()]
    public System.DateTime Fecha
    {
        get
        {
            return this.fechaField;
        }
        set
        {
            this.fechaField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string Sello
    {
        get
        {
            return this.selloField;
        }
        set
        {
            this.selloField = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_FormaPago FormaPago
    {
        get
        {
            return this.formaPagoField;
        }
        set
        {
            this.formaPagoField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool FormaPagoSpecified
    {
        get
        {
            return this.formaPagoFieldSpecified;
        }
        set
        {
            this.formaPagoFieldSpecified = value;
        }
    }

    [XmlAttributeAttribute()]
    public string NoCertificado
    {
        get
        {
            return this.noCertificadoField;
        }
        set
        {
            this.noCertificadoField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string Certificado
    {
        get
        {
            return this.certificadoField;
        }
        set
        {
            this.certificadoField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string CondicionesDePago
    {
        get
        {
            return this.condicionesDePagoField;
        }
        set
        {
            this.condicionesDePagoField = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal SubTotal
    {
        get
        {
            return this.subTotalField;
        }
        set
        {
            this.subTotalField = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal Descuento
    {
        get
        {
            return this.descuentoField;
        }
        set
        {
            this.descuentoField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool DescuentoSpecified
    {
        get
        {
            return this.descuentoFieldSpecified;
        }
        set
        {
            this.descuentoFieldSpecified = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_Moneda Moneda
    {
        get
        {
            return this.monedaField;
        }
        set
        {
            this.monedaField = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal TipoCambio
    {
        get
        {
            return this.tipoCambioField;
        }
        set
        {
            this.tipoCambioField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool TipoCambioSpecified
    {
        get
        {
            return this.tipoCambioFieldSpecified;
        }
        set
        {
            this.tipoCambioFieldSpecified = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal Total
    {
        get
        {
            return this.totalField;
        }
        set
        {
            this.totalField = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_TipoDeComprobante TipoDeComprobante
    {
        get
        {
            return this.tipoDeComprobanteField;
        }
        set
        {
            this.tipoDeComprobanteField = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_Exportacion Exportacion
    {
        get
        {
            return this.exportacionField;
        }
        set
        {
            this.exportacionField = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_MetodoPago MetodoPago
    {
        get
        {
            return this.metodoPagoField;
        }
        set
        {
            this.metodoPagoField = value;
        }
    }

    [XmlIgnoreAttribute()]
    public bool MetodoPagoSpecified
    {
        get
        {
            return this.metodoPagoFieldSpecified;
        }
        set
        {
            this.metodoPagoFieldSpecified = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_CodigoPostal LugarExpedicion
    {
        get
        {
            return this.lugarExpedicionField;
        }
        set
        {
            this.lugarExpedicionField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string Confirmacion
    {
        get
        {
            return this.confirmacionField;
        }
        set
        {
            this.confirmacionField = value;
        }
    }
}
