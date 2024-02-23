namespace Decorator.Practice.Discounts.Shared.Models;

[Serializable()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace =
    "http://www.iata.org/IATA/2015/EASD/00/IATA_OffersAndOrdersCommonTypes")]
[System.Runtime.Serialization.DataContractAttribute(Name = "AmountType",
    Namespace = "http://www.iata.org/IATA/2015/EASD/00/IATA_OffersAndOrdersMessage")]
public class AmountType
{
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string CurCode { get; set; }

    [System.Xml.Serialization.XmlTextAttribute()]
    [System.Runtime.Serialization.DataMemberAttribute()]
    public decimal Value { get; set; }
}