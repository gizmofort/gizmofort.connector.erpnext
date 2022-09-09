/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Buying.PurchaseOrderItem
{
    public partial class ERP_Buying_PurchaseOrderItem : ERPNextObjectBase
    {
        public ERP_Buying_PurchaseOrderItem() : this(new ERPObject(_DockType.Buying_PurchaseOrderItem)) { }
        public ERP_Buying_PurchaseOrderItem(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Buying_PurchaseOrderItem>(propertyName);
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

        [Column("supplier_part_no")]
        public string? SupplierPartNo
        {
            get { return data.supplier_part_no; }
            set { data.supplier_part_no = value; }
        }

        [Column("item_name")]
        public string? ItemName
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        [Column("product_bundle")]
        public string? ProductBundle
        {
            get { return data.product_bundle; }
            set { data.product_bundle = value; }
        }

        [Column("fg_item")]
        public string? FgItem
        {
            get { return data.fg_item; }
            set { data.fg_item = value; }
        }

        [Column("fg_item_qty")]
        public decimal FgItemQty
        {
            get { return data.fg_item_qty; }
            set { data.fg_item_qty = value; }
        }

        [Column("schedule_date")]
        public DateOnly? ScheduleDate
        {
            get { return data.schedule_date; }
            set { data.schedule_date = value; }
        }

        [Column("expected_delivery_date")]
        public DateOnly? ExpectedDeliveryDate
        {
            get { return data.expected_delivery_date; }
            set { data.expected_delivery_date = value; }
        }

        [Column("description")]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
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

        [Column("last_purchase_rate")]
        public decimal LastPurchaseRate
        {
            get { return data.last_purchase_rate; }
            set { data.last_purchase_rate = value; }
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

        [Column("warehouse")]
        public string? Warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        [Column("actual_qty")]
        public decimal ActualQty
        {
            get { return data.actual_qty; }
            set { data.actual_qty = value; }
        }

        [Column("company_total_stock")]
        public decimal CompanyTotalStock
        {
            get { return data.company_total_stock; }
            set { data.company_total_stock = value; }
        }

        [Column("material_request")]
        public string? MaterialRequest
        {
            get { return data.material_request; }
            set { data.material_request = value; }
        }

        [Column("material_request_item")]
        public string? MaterialRequestItem
        {
            get { return data.material_request_item; }
            set { data.material_request_item = value; }
        }

        [Column("sales_order")]
        public string? SalesOrder
        {
            get { return data.sales_order; }
            set { data.sales_order = value; }
        }

        [Column("sales_order_item")]
        public string? SalesOrderItem
        {
            get { return data.sales_order_item; }
            set { data.sales_order_item = value; }
        }

        [Column("sales_order_packed_item")]
        public string? SalesOrderPackedItem
        {
            get { return data.sales_order_packed_item; }
            set { data.sales_order_packed_item = value; }
        }

        [Column("supplier_quotation")]
        public string? SupplierQuotation
        {
            get { return data.supplier_quotation; }
            set { data.supplier_quotation = value; }
        }

        [Column("supplier_quotation_item")]
        public string? SupplierQuotationItem
        {
            get { return data.supplier_quotation_item; }
            set { data.supplier_quotation_item = value; }
        }

        [Column("delivered_by_supplier")]
        public int DeliveredBySupplier
        {
            get { return data.delivered_by_supplier; }
            set { data.delivered_by_supplier = value; }
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

        [Column("received_qty")]
        public decimal ReceivedQty
        {
            get { return data.received_qty; }
            set { data.received_qty = value; }
        }

        [Column("returned_qty")]
        public decimal ReturnedQty
        {
            get { return data.returned_qty; }
            set { data.returned_qty = value; }
        }

        [Column("billed_amt")]
        public decimal BilledAmt
        {
            get { return data.billed_amt; }
            set { data.billed_amt = value; }
        }

        [Column("expense_account")]
        public string? ExpenseAccount
        {
            get { return data.expense_account; }
            set { data.expense_account = value; }
        }

        [Column("manufacturer")]
        public string? Manufacturer
        {
            get { return data.manufacturer; }
            set { data.manufacturer = value; }
        }

        [Column("manufacturer_part_no")]
        public string? ManufacturerPartNo
        {
            get { return data.manufacturer_part_no; }
            set { data.manufacturer_part_no = value; }
        }

        [Column("bom")]
        public string? Bom
        {
            get { return data.bom; }
            set { data.bom = value; }
        }

        [Column("include_exploded_items")]
        public int IncludeExplodedItems
        {
            get { return data.include_exploded_items; }
            set { data.include_exploded_items = value; }
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

        [Column("project")]
        public string? Project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        [Column("cost_center")]
        public string? CostCenter
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        [Column("is_fixed_asset")]
        public int IsFixedAsset
        {
            get { return data.is_fixed_asset; }
            set { data.is_fixed_asset = value; }
        }

        [Column("item_tax_rate")]
        public string? ItemTaxRate
        {
            get { return data.item_tax_rate; }
            set { data.item_tax_rate = value; }
        }

        [Column("production_plan")]
        public string? ProductionPlan
        {
            get { return data.production_plan; }
            set { data.production_plan = value; }
        }

        [Column("production_plan_item")]
        public string? ProductionPlanItem
        {
            get { return data.production_plan_item; }
            set { data.production_plan_item = value; }
        }

        [Column("production_plan_sub_assembly_item")]
        public string? ProductionPlanSubAssemblyItem
        {
            get { return data.production_plan_sub_assembly_item; }
            set { data.production_plan_sub_assembly_item = value; }
        }

        [Column("page_break")]
        public int PageBreak
        {
            get { return data.page_break; }
            set { data.page_break = value; }
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
