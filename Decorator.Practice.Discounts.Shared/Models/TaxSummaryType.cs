using System.Xml.Serialization;

namespace Decorator.Practice.Discounts.Shared.Models;

[Serializable()]
[XmlType(Namespace = "http://www.iata.org/IATA/2015/EASD/00/IATA_OffersAndOrdersCommonTypes")]
[System.Runtime.Serialization.DataContractAttribute(Name = "TaxSummaryType", Namespace = "http://www.iata.org/IATA/2015/EASD/00/IATA_OffersAndOrdersMessage")]
public class TaxSummaryType
{
    [XmlIgnore]
    public bool AllRefundableInd { get; set; }

    [XmlIgnore]
    public bool ApproximateInd { get; set; }

    [XmlIgnore]
    public bool CollectionInd { get; set; }

    [XmlIgnore]
    public System.DateTime GuaranteeTimeLimitDateTime { get; set; }

    [XmlElement(DataType = "token")]
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string RefundMethodText { get; set; }

    [System.Runtime.Serialization.DataMemberAttribute()]
    public AmountType TotalRefundableTaxAmount { get; set; }

    [System.Runtime.Serialization.DataMemberAttribute()]
    public AmountType TotalTaxAmount { get; set; }
}