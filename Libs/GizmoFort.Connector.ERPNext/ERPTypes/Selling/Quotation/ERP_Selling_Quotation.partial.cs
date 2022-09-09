/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Selling.Quotation
{
    public partial class ERP_Selling_Quotation : ERPNextObjectBase
    {
        public ERP_Selling_Quotation() : this(new ERPObject(_DockType.Selling_Quotation)) { }
        public ERP_Selling_Quotation(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Selling_Quotation>(propertyName);
        }

        [Column("name")]
        public string Name
        {
            get { return data.name; }
            set { data.name = value; }
        }

        [Column("creation")]
        public DateTime? Creation
        {
            get { return data.creation; }
            set { data.creation = value; }
        }

        [Column("modified")]
        public DateTime? Modified
        {
            get { return data.modified; }
            set { data.modified = value; }
        }

        [Column("modified_by")]
        public string? ModifiedBy
        {
            get { return data.modified_by; }
            set { data.modified_by = value; }
        }

        [Column("owner")]
        public string? Owner
        {
            get { return data.owner; }
            set { data.owner = value; }
        }

        [Column("docstatus")]
        public int Docstatus
        {
            get { return data.docstatus; }
            set { data.docstatus = value; }
        }

        [Column("idx")]
        public int Idx
        {
            get { return data.idx; }
            set { data.idx = value; }
        }

        [Column("title")]
        public string? Title
        {
            get { return data.title; }
            set { data.title = value; }
        }

        [Column("naming_series")]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        [Column("quotation_to")]
        public string? QuotationTo
        {
            get { return data.quotation_to; }
            set { data.quotation_to = value; }
        }

        [Column("party_name")]
        public string? PartyName
        {
            get { return data.party_name; }
            set { data.party_name = value; }
        }

        [Column("customer_name")]
        public string? CustomerName
        {
            get { return data.customer_name; }
            set { data.customer_name = value; }
        }

        [Column("amended_from")]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("transaction_date")]
        public DateOnly? TransactionDate
        {
            get { return data.transaction_date; }
            set { data.transaction_date = value; }
        }

        [Column("valid_till")]
        public DateOnly? ValidTill
        {
            get { return data.valid_till; }
            set { data.valid_till = value; }
        }

        [Column("order_type")]
        public string? OrderType
        {
            get { return data.order_type; }
            set { data.order_type = value; }
        }

        [Column("customer_address")]
        public string? CustomerAddress
        {
            get { return data.customer_address; }
            set { data.customer_address = value; }
        }

        [Column("address_display")]
        public string? AddressDisplay
        {
            get { return data.address_display; }
            set { data.address_display = value; }
        }

        [Column("contact_person")]
        public string? ContactPerson
        {
            get { return data.contact_person; }
            set { data.contact_person = value; }
        }

        [Column("contact_display")]
        public string? ContactDisplay
        {
            get { return data.contact_display; }
            set { data.contact_display = value; }
        }

        [Column("contact_mobile")]
        public string? ContactMobile
        {
            get { return data.contact_mobile; }
            set { data.contact_mobile = value; }
        }

        [Column("contact_email")]
        public string? ContactEmail
        {
            get { return data.contact_email; }
            set { data.contact_email = value; }
        }

        [Column("shipping_address_name")]
        public string? ShippingAddressName
        {
            get { return data.shipping_address_name; }
            set { data.shipping_address_name = value; }
        }

        [Column("shipping_address")]
        public string? ShippingAddress
        {
            get { return data.shipping_address; }
            set { data.shipping_address = value; }
        }

        [Column("company_address")]
        public string? CompanyAddress
        {
            get { return data.company_address; }
            set { data.company_address = value; }
        }

        [Column("company_address_display")]
        public string? CompanyAddressDisplay
        {
            get { return data.company_address_display; }
            set { data.company_address_display = value; }
        }

        [Column("customer_group")]
        public string? CustomerGroup
        {
            get { return data.customer_group; }
            set { data.customer_group = value; }
        }

        [Column("territory")]
        public string? Territory
        {
            get { return data.territory; }
            set { data.territory = value; }
        }

        [Column("currency")]
        public string? Currency
        {
            get { return data.currency; }
            set { data.currency = value; }
        }

        [Column("conversion_rate")]
        public decimal ConversionRate
        {
            get { return data.conversion_rate; }
            set { data.conversion_rate = value; }
        }

        [Column("selling_price_list")]
        public string? SellingPriceList
        {
            get { return data.selling_price_list; }
            set { data.selling_price_list = value; }
        }

        [Column("price_list_currency")]
        public string? PriceListCurrency
        {
            get { return data.price_list_currency; }
            set { data.price_list_currency = value; }
        }

        [Column("plc_conversion_rate")]
        public decimal PlcConversionRate
        {
            get { return data.plc_conversion_rate; }
            set { data.plc_conversion_rate = value; }
        }

        [Column("ignore_pricing_rule")]
        public int IgnorePricingRule
        {
            get { return data.ignore_pricing_rule; }
            set { data.ignore_pricing_rule = value; }
        }

        [Column("scan_barcode")]
        public string? ScanBarcode
        {
            get { return data.scan_barcode; }
            set { data.scan_barcode = value; }
        }

        [Column("total_qty")]
        public decimal TotalQty
        {
            get { return data.total_qty; }
            set { data.total_qty = value; }
        }

        [Column("base_total")]
        public decimal BaseTotal
        {
            get { return data.base_total; }
            set { data.base_total = value; }
        }

        [Column("base_net_total")]
        public decimal BaseNetTotal
        {
            get { return data.base_net_total; }
            set { data.base_net_total = value; }
        }

        [Column("total")]
        public decimal Total
        {
            get { return data.total; }
            set { data.total = value; }
        }

        [Column("net_total")]
        public decimal NetTotal
        {
            get { return data.net_total; }
            set { data.net_total = value; }
        }

        [Column("total_net_weight")]
        public decimal TotalNetWeight
        {
            get { return data.total_net_weight; }
            set { data.total_net_weight = value; }
        }

        [Column("tax_category")]
        public string? TaxCategory
        {
            get { return data.tax_category; }
            set { data.tax_category = value; }
        }

        [Column("shipping_rule")]
        public string? ShippingRule
        {
            get { return data.shipping_rule; }
            set { data.shipping_rule = value; }
        }

        [Column("taxes_and_charges")]
        public string? TaxesAndCharges
        {
            get { return data.taxes_and_charges; }
            set { data.taxes_and_charges = value; }
        }

        [Column("other_charges_calculation")]
        public string? OtherChargesCalculation
        {
            get { return data.other_charges_calculation; }
            set { data.other_charges_calculation = value; }
        }

        [Column("base_total_taxes_and_charges")]
        public decimal BaseTotalTaxesAndCharges
        {
            get { return data.base_total_taxes_and_charges; }
            set { data.base_total_taxes_and_charges = value; }
        }

        [Column("total_taxes_and_charges")]
        public decimal TotalTaxesAndCharges
        {
            get { return data.total_taxes_and_charges; }
            set { data.total_taxes_and_charges = value; }
        }

        [Column("coupon_code")]
        public string? CouponCode
        {
            get { return data.coupon_code; }
            set { data.coupon_code = value; }
        }

        [Column("referral_sales_partner")]
        public string? ReferralSalesPartner
        {
            get { return data.referral_sales_partner; }
            set { data.referral_sales_partner = value; }
        }

        [Column("apply_discount_on")]
        public string? ApplyDiscountOn
        {
            get { return data.apply_discount_on; }
            set { data.apply_discount_on = value; }
        }

        [Column("base_discount_amount")]
        public decimal BaseDiscountAmount
        {
            get { return data.base_discount_amount; }
            set { data.base_discount_amount = value; }
        }

        [Column("additional_discount_percentage")]
        public decimal AdditionalDiscountPercentage
        {
            get { return data.additional_discount_percentage; }
            set { data.additional_discount_percentage = value; }
        }

        [Column("discount_amount")]
        public decimal DiscountAmount
        {
            get { return data.discount_amount; }
            set { data.discount_amount = value; }
        }

        [Column("base_grand_total")]
        public decimal BaseGrandTotal
        {
            get { return data.base_grand_total; }
            set { data.base_grand_total = value; }
        }

        [Column("base_rounding_adjustment")]
        public decimal BaseRoundingAdjustment
        {
            get { return data.base_rounding_adjustment; }
            set { data.base_rounding_adjustment = value; }
        }

        [Column("base_in_words")]
        public string? BaseInWords
        {
            get { return data.base_in_words; }
            set { data.base_in_words = value; }
        }

        [Column("base_rounded_total")]
        public decimal BaseRoundedTotal
        {
            get { return data.base_rounded_total; }
            set { data.base_rounded_total = value; }
        }

        [Column("grand_total")]
        public decimal GrandTotal
        {
            get { return data.grand_total; }
            set { data.grand_total = value; }
        }

        [Column("rounding_adjustment")]
        public decimal RoundingAdjustment
        {
            get { return data.rounding_adjustment; }
            set { data.rounding_adjustment = value; }
        }

        [Column("rounded_total")]
        public decimal RoundedTotal
        {
            get { return data.rounded_total; }
            set { data.rounded_total = value; }
        }

        [Column("in_words")]
        public string? InWords
        {
            get { return data.in_words; }
            set { data.in_words = value; }
        }

        [Column("payment_terms_template")]
        public string? PaymentTermsTemplate
        {
            get { return data.payment_terms_template; }
            set { data.payment_terms_template = value; }
        }

        [Column("tc_name")]
        public string? TcName
        {
            get { return data.tc_name; }
            set { data.tc_name = value; }
        }

        [Column("terms")]
        public string? Terms
        {
            get { return data.terms; }
            set { data.terms = value; }
        }

        [Column("letter_head")]
        public string? LetterHead
        {
            get { return data.letter_head; }
            set { data.letter_head = value; }
        }

        [Column("group_same_items")]
        public int GroupSameItems
        {
            get { return data.group_same_items; }
            set { data.group_same_items = value; }
        }

        [Column("select_print_heading")]
        public string? SelectPrintHeading
        {
            get { return data.select_print_heading; }
            set { data.select_print_heading = value; }
        }

        [Column("language")]
        public string? Language
        {
            get { return data.language; }
            set { data.language = value; }
        }

        [Column("auto_repeat")]
        public string? AutoRepeat
        {
            get { return data.auto_repeat; }
            set { data.auto_repeat = value; }
        }

        [Column("campaign")]
        public string? Campaign
        {
            get { return data.campaign; }
            set { data.campaign = value; }
        }

        [Column("source")]
        public string? Source
        {
            get { return data.source; }
            set { data.source = value; }
        }

        [Column("order_lost_reason")]
        public string? OrderLostReason
        {
            get { return data.order_lost_reason; }
            set { data.order_lost_reason = value; }
        }

        [Column("status")]
        public string? Status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        [Column("enq_det")]
        public string? EnqDet
        {
            get { return data.enq_det; }
            set { data.enq_det = value; }
        }

        [Column("supplier_quotation")]
        public string? SupplierQuotation
        {
            get { return data.supplier_quotation; }
            set { data.supplier_quotation = value; }
        }

        [Column("opportunity")]
        public string? Opportunity
        {
            get { return data.opportunity; }
            set { data.opportunity = value; }
        }

        [Column("_user_tags")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _UserTags
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._user_tags; }
            set { data._user_tags = value; }
        }

        [Column("_comments")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Comments
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._comments; }
            set { data._comments = value; }
        }

        [Column("_assign")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Assign
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._assign; }
            set { data._assign = value; }
        }

        [Column("_liked_by")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _LikedBy
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._liked_by; }
            set { data._liked_by = value; }
        }

        [Column("exempt_from_sales_tax")]
        public int ExemptFromSalesTax
        {
            get { return data.exempt_from_sales_tax; }
            set { data.exempt_from_sales_tax = value; }
        }


    }
}
