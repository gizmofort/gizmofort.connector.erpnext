/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Selling.SalesOrderItem
{
    public partial class ERP_Selling_SalesOrderItem : ERPNextObjectBase
    {
        public ERP_Selling_SalesOrderItem() : this(new ERPObject(_DockType.Selling_SalesOrderItem)) { }
        public ERP_Selling_SalesOrderItem(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Selling_SalesOrderItem>(propertyName);
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

        [Column("item_code")]
        public string? ItemCode
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        [Column("customer_item_code")]
        public string? CustomerItemCode
        {
            get { return data.customer_item_code; }
            set { data.customer_item_code = value; }
        }

        [Column("ensure_delivery_based_on_produced_serial_no")]
        public int EnsureDeliveryBasedOnProducedSerialNo
        {
            get { return data.ensure_delivery_based_on_produced_serial_no; }
            set { data.ensure_delivery_based_on_produced_serial_no = value; }
        }

        [Column("delivery_date")]
        public DateOnly? DeliveryDate
        {
            get { return data.delivery_date; }
            set { data.delivery_date = value; }
        }

        [Column("item_name")]
        public string? ItemName
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        [Column("description")]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [Column("item_group")]
        public string? ItemGroup
        {
            get { return data.item_group; }
            set { data.item_group = value; }
        }

        [Column("brand")]
        public string? Brand
        {
            get { return data.brand; }
            set { data.brand = value; }
        }

        [Column("image")]
        public string? Image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        [Column("qty")]
        public decimal Qty
        {
            get { return data.qty; }
            set { data.qty = value; }
        }

        [Column("stock_uom")]
        public string? StockUom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
        }

        [Column("uom")]
        public string? Uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        [Column("conversion_factor")]
        public decimal ConversionFactor
        {
            get { return data.conversion_factor; }
            set { data.conversion_factor = value; }
        }

        [Column("stock_qty")]
        public decimal StockQty
        {
            get { return data.stock_qty; }
            set { data.stock_qty = value; }
        }

        [Column("price_list_rate")]
        public decimal PriceListRate
        {
            get { return data.price_list_rate; }
            set { data.price_list_rate = value; }
        }

        [Column("base_price_list_rate")]
        public decimal BasePriceListRate
        {
            get { return data.base_price_list_rate; }
            set { data.base_price_list_rate = value; }
        }

        [Column("margin_type")]
        public string? MarginType
        {
            get { return data.margin_type; }
            set { data.margin_type = value; }
        }

        [Column("margin_rate_or_amount")]
        public decimal MarginRateOrAmount
        {
            get { return data.margin_rate_or_amount; }
            set { data.margin_rate_or_amount = value; }
        }

        [Column("rate_with_margin")]
        public decimal RateWithMargin
        {
            get { return data.rate_with_margin; }
            set { data.rate_with_margin = value; }
        }

        [Column("discount_percentage")]
        public decimal DiscountPercentage
        {
            get { return data.discount_percentage; }
            set { data.discount_percentage = value; }
        }

        [Column("discount_amount")]
        public decimal DiscountAmount
        {
            get { return data.discount_amount; }
            set { data.discount_amount = value; }
        }

        [Column("base_rate_with_margin")]
        public decimal BaseRateWithMargin
        {
            get { return data.base_rate_with_margin; }
            set { data.base_rate_with_margin = value; }
        }

        [Column("rate")]
        public decimal Rate
        {
            get { return data.rate; }
            set { data.rate = value; }
        }

        [Column("amount")]
        public decimal Amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        [Column("item_tax_template")]
        public string? ItemTaxTemplate
        {
            get { return data.item_tax_template; }
            set { data.item_tax_template = value; }
        }

        [Column("base_rate")]
        public decimal BaseRate
        {
            get { return data.base_rate; }
            set { data.base_rate = value; }
        }

        [Column("base_amount")]
        public decimal BaseAmount
        {
            get { return data.base_amount; }
            set { data.base_amount = value; }
        }

        [Column("pricing_rules")]
        public string? PricingRules
        {
            get { return data.pricing_rules; }
            set { data.pricing_rules = value; }
        }

        [Column("stock_uom_rate")]
        public decimal StockUomRate
        {
            get { return data.stock_uom_rate; }
            set { data.stock_uom_rate = value; }
        }

        [Column("is_free_item")]
        public int IsFreeItem
        {
            get { return data.is_free_item; }
            set { data.is_free_item = value; }
        }

        [Column("grant_commission")]
        public int GrantCommission
        {
            get { return data.grant_commission; }
            set { data.grant_commission = value; }
        }

        [Column("net_rate")]
        public decimal NetRate
        {
            get { return data.net_rate; }
            set { data.net_rate = value; }
        }

        [Column("net_amount")]
        public decimal NetAmount
        {
            get { return data.net_amount; }
            set { data.net_amount = value; }
        }

        [Column("base_net_rate")]
        public decimal BaseNetRate
        {
            get { return data.base_net_rate; }
            set { data.base_net_rate = value; }
        }

        [Column("base_net_amount")]
        public decimal BaseNetAmount
        {
            get { return data.base_net_amount; }
            set { data.base_net_amount = value; }
        }

        [Column("billed_amt")]
        public decimal BilledAmt
        {
            get { return data.billed_amt; }
            set { data.billed_amt = value; }
        }

        [Column("valuation_rate")]
        public decimal ValuationRate
        {
            get { return data.valuation_rate; }
            set { data.valuation_rate = value; }
        }

        [Column("gross_profit")]
        public decimal GrossProfit
        {
            get { return data.gross_profit; }
            set { data.gross_profit = value; }
        }

        [Column("delivered_by_supplier")]
        public int DeliveredBySupplier
        {
            get { return data.delivered_by_supplier; }
            set { data.delivered_by_supplier = value; }
        }

        [Column("supplier")]
        public string? Supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
        }

        [Column("weight_per_unit")]
        public decimal WeightPerUnit
        {
            get { return data.weight_per_unit; }
            set { data.weight_per_unit = value; }
        }

        [Column("total_weight")]
        public decimal TotalWeight
        {
            get { return data.total_weight; }
            set { data.total_weight = value; }
        }

        [Column("weight_uom")]
        public string? WeightUom
        {
            get { return data.weight_uom; }
            set { data.weight_uom = value; }
        }

        [Column("warehouse")]
        public string? Warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        [Column("target_warehouse")]
        public string? TargetWarehouse
        {
            get { return data.target_warehouse; }
            set { data.target_warehouse = value; }
        }

        [Column("prevdoc_docname")]
        public string? PrevdocDocname
        {
            get { return data.prevdoc_docname; }
            set { data.prevdoc_docname = value; }
        }

        [Column("against_blanket_order")]
        public int AgainstBlanketOrder
        {
            get { return data.against_blanket_order; }
            set { data.against_blanket_order = value; }
        }

        [Column("blanket_order")]
        public string? BlanketOrder
        {
            get { return data.blanket_order; }
            set { data.blanket_order = value; }
        }

        [Column("blanket_order_rate")]
        public decimal BlanketOrderRate
        {
            get { return data.blanket_order_rate; }
            set { data.blanket_order_rate = value; }
        }

        [Column("bom_no")]
        public string? BomNo
        {
            get { return data.bom_no; }
            set { data.bom_no = value; }
        }

        [Column("projected_qty")]
        public decimal ProjectedQty
        {
            get { return data.projected_qty; }
            set { data.projected_qty = value; }
        }

        [Column("actual_qty")]
        public decimal ActualQty
        {
            get { return data.actual_qty; }
            set { data.actual_qty = value; }
        }

        [Column("ordered_qty")]
        public decimal OrderedQty
        {
            get { return data.ordered_qty; }
            set { data.ordered_qty = value; }
        }

        [Column("planned_qty")]
        public decimal PlannedQty
        {
            get { return data.planned_qty; }
            set { data.planned_qty = value; }
        }

        [Column("work_order_qty")]
        public decimal WorkOrderQty
        {
            get { return data.work_order_qty; }
            set { data.work_order_qty = value; }
        }

        [Column("delivered_qty")]
        public decimal DeliveredQty
        {
            get { return data.delivered_qty; }
            set { data.delivered_qty = value; }
        }

        [Column("produced_qty")]
        public decimal ProducedQty
        {
            get { return data.produced_qty; }
            set { data.produced_qty = value; }
        }

        [Column("returned_qty")]
        public decimal ReturnedQty
        {
            get { return data.returned_qty; }
            set { data.returned_qty = value; }
        }

        [Column("picked_qty")]
        public decimal PickedQty
        {
            get { return data.picked_qty; }
            set { data.picked_qty = value; }
        }

        [Column("additional_notes")]
        public string? AdditionalNotes
        {
            get { return data.additional_notes; }
            set { data.additional_notes = value; }
        }

        [Column("page_break")]
        public int PageBreak
        {
            get { return data.page_break; }
            set { data.page_break = value; }
        }

        [Column("item_tax_rate")]
        public string? ItemTaxRate
        {
            get { return data.item_tax_rate; }
            set { data.item_tax_rate = value; }
        }

        [Column("transaction_date")]
        public DateOnly? TransactionDate
        {
            get { return data.transaction_date; }
            set { data.transaction_date = value; }
        }

        [Column("parent")]
        public string? Parent
        {
            get { return data.parent; }
            set { data.parent = value; }
        }

        [Column("parentfield")]
        public string? Parentfield
        {
            get { return data.parentfield; }
            set { data.parentfield = value; }
        }

        [Column("parenttype")]
        public string? Parenttype
        {
            get { return data.parenttype; }
            set { data.parenttype = value; }
        }


    }
}
