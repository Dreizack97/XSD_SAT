﻿using System.Xml.Serialization;

[SerializableAttribute()]
[XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
public enum c_ObjetoImp
{
    [XmlEnumAttribute("01")]
    Item01,
    [XmlEnumAttribute("02")]
    Item02,
    [XmlEnumAttribute("03")]
    Item03,
    [XmlEnumAttribute("04")]
    Item04,
    [XmlEnumAttribute("05")]
    Item05,
}