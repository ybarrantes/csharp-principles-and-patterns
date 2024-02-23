using System.Xml.Serialization;

namespace Decorator.Practice.Discounts.Shared.Models;

[Serializable()]
[XmlType(Namespace = "http://www.iata.org/IATA/2015/EASD/00/IATA_OffersAndOrdersCommonTypes")]
[System.Runtime.Serialization.DataContractAttribute(Name = "DiscountType", Namespace = "http://www.iata.org/IATA/2015/EASD/00/IATA_OffersAndOrdersMessage")]
public class DiscountType
{
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string AppText { get; set; }

    [System.Runtime.Serialization.DataMemberAttribute()]
    public string DescText { get; set; }

    [System.Runtime.Serialization.DataMemberAttribute()]
    public AmountType DiscountAmount { get; set; }
    
    [XmlIgnore]
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
    public decimal DiscountPercent { get; set; }

    [System.Runtime.Serialization.DataMemberAttribute()]
    public AmountType PreDiscountedAmount { get; set; }
}