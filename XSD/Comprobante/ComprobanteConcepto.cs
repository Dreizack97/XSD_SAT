using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteConcepto
{
    private ComprobanteConceptoImpuestos impuestosField;

    private ComprobanteConceptoACuentaTerceros aCuentaTercerosField;

    private ComprobanteConceptoInformacionAduanera[] informacionAduaneraField;

    private ComprobanteConceptoCuentaPredial[] cuentaPredialField;

    private ComprobanteConceptoComplementoConcepto complementoConceptoField;

    private ComprobanteConceptoParte[] parteField;

    private c_ClaveProdServ claveProdServField;

    private string noIdentificacionField;

    private decimal cantidadField;

    private c_ClaveUnidad claveUnidadField;

    private string unidadField;

    private string descripcionField;

    private decimal valorUnitarioField;

    private decimal importeField;

    private decimal descuentoField;

    private bool descuentoFieldSpecified;

    private c_ObjetoImp objetoImpField;

    public ComprobanteConceptoImpuestos Impuestos
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

    public ComprobanteConceptoACuentaTerceros ACuentaTerceros
    {
        get
        {
            return this.aCuentaTercerosField;
        }
        set
        {
            this.aCuentaTercerosField = value;
        }
    }

    [XmlElementAttribute("InformacionAduanera")]
    public ComprobanteConceptoInformacionAduanera[] InformacionAduanera
    {
        get
        {
            return this.informacionAduaneraField;
        }
        set
        {
            this.informacionAduaneraField = value;
        }
    }

    [XmlElementAttribute("CuentaPredial")]
    public ComprobanteConceptoCuentaPredial[] CuentaPredial
    {
        get
        {
            return this.cuentaPredialField;
        }
        set
        {
            this.cuentaPredialField = value;
        }
    }

    public ComprobanteConceptoComplementoConcepto ComplementoConcepto
    {
        get
        {
            return this.complementoConceptoField;
        }
        set
        {
            this.complementoConceptoField = value;
        }
    }

    [XmlElementAttribute("Parte")]
    public ComprobanteConceptoParte[] Parte
    {
        get
        {
            return this.parteField;
        }
        set
        {
            this.parteField = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_ClaveProdServ ClaveProdServ
    {
        get
        {
            return this.claveProdServField;
        }
        set
        {
            this.claveProdServField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string NoIdentificacion
    {
        get
        {
            return this.noIdentificacionField;
        }
        set
        {
            this.noIdentificacionField = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal Cantidad
    {
        get
        {
            return this.cantidadField;
        }
        set
        {
            this.cantidadField = value;
        }
    }

    [XmlAttributeAttribute()]
    public c_ClaveUnidad ClaveUnidad
    {
        get
        {
            return this.claveUnidadField;
        }
        set
        {
            this.claveUnidadField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string Unidad
    {
        get
        {
            return this.unidadField;
        }
        set
        {
            this.unidadField = value;
        }
    }

    [XmlAttributeAttribute()]
    public string Descripcion
    {
        get
        {
            return this.descripcionField;
        }
        set
        {
            this.descripcionField = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal ValorUnitario
    {
        get
        {
            return this.valorUnitarioField;
        }
        set
        {
            this.valorUnitarioField = value;
        }
    }

    [XmlAttributeAttribute()]
    public decimal Importe
    {
        get
        {
            return this.importeField;
        }
        set
        {
            this.importeField = value;
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
    public c_ObjetoImp ObjetoImp
    {
        get
        {
            return this.objetoImpField;
        }
        set
        {
            this.objetoImpField = value;
        }
    }
}
