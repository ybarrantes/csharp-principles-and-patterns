namespace Decorator.Practice.Discounts.Shared.Models;

[Serializable()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iata.org/IATA/2015/EASD/00/IATA_OffersAndOrdersCommonTypes")]
[System.Runtime.Serialization.DataContractAttribute(Name = "PriceType", Namespace = "http://www.iata.org/IATA/2015/EASD/00/IATA_OffersAndOrdersMessage")]
public class PriceType
{
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
    public AmountType BaseAmount { get; set; }

    [System.Xml.Serialization.XmlIgnore]
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
    public System.DateTime BaseAmountGuaranteeTimeLimitDateTime { get; set; }

    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
    public DiscountType Discount { get; set; }

    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
    public AmountType EquivAmount { get; set; }

    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
    public AmountType LoyaltyUnitAmount { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
    public string LoyaltyUnitName { get; set; }

    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool MaskedInd { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("TaxSummary")]
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
    public List<TaxSummaryType> TaxSummary { get; set; }

    [System.Runtime.Serialization.DataMemberAttribute()]
    public AmountType TotalAmount { get; set; }
}