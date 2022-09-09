/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Manufacturing.ProductionPlan
{
    public partial class ERP_Manufacturing_ProductionPlan : ERPNextObjectBase
    {
        public ERP_Manufacturing_ProductionPlan() : this(new ERPObject(_DockType.Manufacturing_ProductionPlan)) { }
        public ERP_Manufacturing_ProductionPlan(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Manufacturing_ProductionPlan>(propertyName);
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

        [Column("naming_series")]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("get_items_from")]
        public string? GetItemsFrom
        {
            get { return data.get_items_from; }
            set { data.get_items_from = value; }
        }

        [Column("posting_date")]
        public DateOnly? PostingDate
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        [Column("item_code")]
        public string? ItemCode
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        [Column("customer")]
        public string? Customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        [Column("warehouse")]
        public string? Warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        [Column("project")]
        public string? Project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        [Column("sales_order_status")]
        public string? SalesOrderStatus
        {
            get { return data.sales_order_status; }
            set { data.sales_order_status = value; }
        }

        [Column("from_date")]
        public DateOnly? FromDate
        {
            get { return data.from_date; }
            set { data.from_date = value; }
        }

        [Column("to_date")]
        public DateOnly? ToDate
        {
            get { return data.to_date; }
            set { data.to_date = value; }
        }

        [Column("from_delivery_date")]
        public DateOnly? FromDeliveryDate
        {
            get { return data.from_delivery_date; }
            set { data.from_delivery_date = value; }
        }

        [Column("to_delivery_date")]
        public DateOnly? ToDeliveryDate
        {
            get { return data.to_delivery_date; }
            set { data.to_delivery_date = value; }
        }

        [Column("combine_items")]
        public int CombineItems
        {
            get { return data.combine_items; }
            set { data.combine_items = value; }
        }

        [Column("combine_sub_items")]
        public int CombineSubItems
        {
            get { return data.combine_sub_items; }
            set { data.combine_sub_items = value; }
        }

        [Column("include_non_stock_items")]
        public int IncludeNonStockItems
        {
            get { return data.include_non_stock_items; }
            set { data.include_non_stock_items = value; }
        }

        [Column("include_subcontracted_items")]
        public int IncludeSubcontractedItems
        {
            get { return data.include_subcontracted_items; }
            set { data.include_subcontracted_items = value; }
        }

        [Column("include_safety_stock")]
        public int IncludeSafetyStock
        {
            get { return data.include_safety_stock; }
            set { data.include_safety_stock = value; }
        }

        [Column("ignore_existing_ordered_qty")]
        public int IgnoreExistingOrderedQty
        {
            get { return data.ignore_existing_ordered_qty; }
            set { data.ignore_existing_ordered_qty = value; }
        }

        [Column("for_warehouse")]
        public string? ForWarehouse
        {
            get { return data.for_warehouse; }
            set { data.for_warehouse = value; }
        }

        [Column("total_planned_qty")]
        public decimal TotalPlannedQty
        {
            get { return data.total_planned_qty; }
            set { data.total_planned_qty = value; }
        }

        [Column("total_produced_qty")]
        public decimal TotalProducedQty
        {
            get { return data.total_produced_qty; }
            set { data.total_produced_qty = value; }
        }

        [Column("status")]
        public string? Status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        [Column("amended_from")]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
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


    }
}
