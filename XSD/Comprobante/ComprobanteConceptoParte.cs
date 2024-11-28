using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

[SerializableAttribute()]
[DebuggerStepThroughAttribute()]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteConceptoParte
{
    private ComprobanteConceptoParteInformacionAduanera[] informacionAduaneraField;

    private c_ClaveProdServ claveProdServField;

    private string noIdentificacionField;

    private decimal cantidadField;

    private string unidadField;

    private string descripcionField;

    private decimal valorUnitarioField;

    private bool valorUnitarioFieldSpecified;

    private decimal importeField;

    private bool importeFieldSpecified;

    [XmlElementAttribute("InformacionAduanera")]
    public ComprobanteConceptoParteInformacionAduanera[] InformacionAduanera
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

    [XmlIgnoreAttribute()]
    public bool ValorUnitarioSpecified
    {
        get
        {
            return this.valorUnitarioFieldSpecified;
        }
        set
        {
            this.valorUnitarioFieldSpecified = value;
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

    [XmlIgnoreAttribute()]
    public bool ImporteSpecified
    {
        get
        {
            return this.importeFieldSpecified;
        }
        set
        {
            this.importeFieldSpecified = value;
        }
    }
}
