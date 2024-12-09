
# Proyecto XSD a Clases C#

Este proyecto tiene como objetivo convertir archivos XSD en clases de C# para facilitar la lectura y manipulación de archivos XML asociados a diferentes conceptos fiscales y nómina. Las clases generadas a partir de los XSD son útiles para la validación, generación y procesamiento de XMLs conforme a las normativas fiscales y laborales en México.

**Compatibilidad con versión 3.3 y 4.0**

## Estructura del Proyecto

La estructura del proyecto está organizada en diferentes carpetas y archivos, los cuales están relacionados con dos áreas principales:

1. **TimbreFiscalDigital11.cs**: Archivos relacionados con el timbre fiscal digital (CFDI).
2. **Comprobante**: Archivos relacionados con facturas electrónicas.
3. **Nomina**: Archivos relacionados con la nómina.

La estructura de carpetas se muestra de la siguiente manera:

```
XSD
│
├── Complemento
│   └── TimbreFiscalDigital11.cs
│
├── Comprobante
│   ├── V33
│   │  ├── Comprobante.cs
│   │  ├── ComprobanteAddenda.cs
│   │  ├── ComprobanteCdfiRelacionados.cs
│   │  ├── ComprobanteCdfiRelacionadosCdfiRelacionados.cs
│   │  ├── ComprobanteComplemento.cs
│   │  ├── ComprobanteConcepto.cs
│   │  ├── ComprobanteConceptoComplementoConcepto.cs
│   │  ├── ComprobanteConceptoCuentaPredial.cs
│   │  ├── ComprobanteConceptoImpuestos.cs
│   │  ├── ComprobanteConceptoImpuestosRetencion.cs
│   │  ├── ComprobanteConceptoImpuestosTraslado.cs
│   │  ├── ComprobanteConceptoInformacionAduanera.cs
│   │  ├── ComprobanteConceptoParte.cs
│   │  ├── ComprobanteConceptoParteInformacionAduanera.cs
│   │  ├── ComprobanteEmisor.cs
│   │  ├── ComprobanteImpuestos.cs
│   │  ├── ComprobanteImpuestosRetencion.cs
│   │  ├── ComprobanteImpuestosTraslado.cs
│   │  └── ComprobanteReceptor.cs
│   ├── V40
│   │  ├── Comprobante.cs
│   │  ├── ComprobanteAddenda.cs
│   │  ├── ComprobanteCdfiRelacionados.cs
│   │  ├── ComprobanteCdfiRelacionadosCdfiRelacionados.cs
│   │  ├── ComprobanteComplemento.cs
│   │  ├── ComprobanteConcepto.cs
│   │  ├── ComprobanteConceptoACuentaTerceros.cs
│   │  ├── ComprobanteConceptoComplementoConcepto.cs
│   │  ├── ComprobanteConceptoCuentaPredial.cs
│   │  ├── ComprobanteConceptoImpuestos.cs
│   │  ├── ComprobanteConceptoImpuestosRetencion.cs
│   │  ├── ComprobanteConceptoImpuestosTraslado.cs
│   │  ├── ComprobanteConceptoInformacionAduanera.cs
│   │  ├── ComprobanteConceptoParte.cs
│   │  ├── ComprobanteConceptoParteInformacionAduanera.cs
│   │  ├── ComprobanteEmisor.cs
│   │  ├── ComprobanteImpuestos.cs
│   │  ├── ComprobanteImpuestosRetencion.cs
│   │  ├── ComprobanteImpuestosTraslado.cs
│   │  ├── ComprobanteInformacionGlobal.cs
│   └──└── ComprobanteReceptor.cs
├── Nomina
│    ├── Nomina.cs
│    ├── NominaDeducciones.cs
│    ├── NominaDeduccionesDeduccion.cs
│    ├── NominaEmisor.cs
│    ├── NominaEmisorEntidadSNFC.cs
│    ├── NominaIncapacidad.cs
│    ├── NominaOtroPago.cs
│    ├── NominaOtroPagoCompensacionSaldosAFavor.cs
│    ├── NominaOtroPagoSubsidioAlEmpleo.cs
│    ├── NominaPercepciones.cs
│    ├── NominaPercepcionesJubilacionPensionRetiro.cs
│    ├── NominaPercepcionesPercepcion.cs
│    ├── NominaPercepcionesPercepcionAccionesOTitulos.cs
│    ├── NominaPercepcionesPercepcionHorasExtra.cs
│    ├── NominaPercepcionesPercepcionSeparacionIndemnizacion.cs
│    ├── NominaPercepcionesReceptor.cs
│    ├── NominaPercepcionesReceptorSindicalizado.cs
│    └── NominaPercepcionesReceptorSubContratacion.cs
```

## Uso

Este proyecto proporciona clases generadas a partir de XSDs que pueden ser utilizadas para leer y manipular archivos XML con las siguientes finalidades:

- **Generación de XML conforme a las normativas fiscales y laborales.**
- **Validación de archivos XML de acuerdo con los esquemas XSD.**
- **Procesamiento de datos fiscales y de nómina de manera estructurada y eficiente.**
- **Creación de PDF's a partir de CFDI's de nómina.**

## Requisitos

- .NET Core o .NET Framework.
- iText7
- iText7.bouncy-castle-adapter
- QRCoder
- Conocimiento básico sobre XML, XSD y CFDI.

## Instalación

1. Clona el repositorio en tu máquina local:
   ```bash
   git clone https://github.com/Dreizack97/XSD_SAT.git
   ```
   
2. Abre el proyecto en Visual Studio o cualquier editor compatible con C#.

3. Los archivos generados están listos para ser utilizados según el esquema y necesidades de integración.

## Contribuciones

Si deseas contribuir al proyecto, por favor sigue estos pasos:

1. Realiza un fork de este repositorio.
2. Crea una rama para tu nueva funcionalidad (`git checkout -b nueva-funcionalidad`).
3. Realiza los cambios y haz commit (`git commit -am 'Agregando nueva funcionalidad'`).
4. Realiza un push a tu rama (`git push origin nueva-funcionalidad`).
5. Abre un pull request describiendo los cambios realizados.

## Licencia

Este proyecto está licenciado bajo la Licencia GPL 3.0 - consulta el archivo [LICENSE](https://www.gnu.org/licenses/gpl-3.0.html) para más detalles.
