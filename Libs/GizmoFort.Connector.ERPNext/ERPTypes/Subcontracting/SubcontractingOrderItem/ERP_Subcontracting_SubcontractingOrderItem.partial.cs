/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Subcontracting.SubcontractingOrderItem
{
    public partial class ERP_Subcontracting_SubcontractingOrderItem : ERPNextObjectBase
    {
        public ERP_Subcontracting_SubcontractingOrderItem() : this(new ERPObject(_DockType.Subcontracting_SubcontractingOrderItem)) { }
        public ERP_Subcontracting_SubcontractingOrderItem(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Subcontracting_SubcontractingOrderItem>(propertyName);
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

        [Column("item_name")]
        public string? ItemName
        {
            get { return data.item_name; }
            set { data.item_name = value; }
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

        [Column("stock_uom")]
        public string? StockUom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
        }

        [Column("conversion_factor")]
        public decimal ConversionFactor
        {
            get { return data.conversion_factor; }
            set { data.conversion_factor = value; }
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

        [Column("rm_cost_per_qty")]
        public decimal RmCostPerQty
        {
            get { return data.rm_cost_per_qty; }
            set { data.rm_cost_per_qty = value; }
        }

        [Column("service_cost_per_qty")]
        public decimal ServiceCostPerQty
        {
            get { return data.service_cost_per_qty; }
            set { data.service_cost_per_qty = value; }
        }

        [Column("additional_cost_per_qty")]
        public decimal AdditionalCostPerQty
        {
            get { return data.additional_cost_per_qty; }
            set { data.additional_cost_per_qty = value; }
        }

        [Column("warehouse")]
        public string? Warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
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

        [Column("cost_center")]
        public string? CostCenter
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        [Column("project")]
        public string? Project
        {
            get { return data.project; }
            set { data.project = value; }
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
