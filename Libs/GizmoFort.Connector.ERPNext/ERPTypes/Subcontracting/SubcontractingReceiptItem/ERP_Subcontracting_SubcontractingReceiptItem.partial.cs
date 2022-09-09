/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Subcontracting.SubcontractingReceiptItem
{
    public partial class ERP_Subcontracting_SubcontractingReceiptItem : ERPNextObjectBase
    {
        public ERP_Subcontracting_SubcontractingReceiptItem() : this(new ERPObject(_DockType.Subcontracting_SubcontractingReceiptItem)) { }
        public ERP_Subcontracting_SubcontractingReceiptItem(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Subcontracting_SubcontractingReceiptItem>(propertyName);
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

        [Column("description")]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
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

        [Column("received_qty")]
        public decimal ReceivedQty
        {
            get { return data.received_qty; }
            set { data.received_qty = value; }
        }

        [Column("qty")]
        public decimal Qty
        {
            get { return data.qty; }
            set { data.qty = value; }
        }

        [Column("rejected_qty")]
        public decimal RejectedQty
        {
            get { return data.rejected_qty; }
            set { data.rejected_qty = value; }
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

        [Column("recalculate_rate")]
        public int RecalculateRate
        {
            get { return data.recalculate_rate; }
            set { data.recalculate_rate = value; }
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

        [Column("rm_supp_cost")]
        public decimal RmSuppCost
        {
            get { return data.rm_supp_cost; }
            set { data.rm_supp_cost = value; }
        }

        [Column("warehouse")]
        public string? Warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        [Column("rejected_warehouse")]
        public string? RejectedWarehouse
        {
            get { return data.rejected_warehouse; }
            set { data.rejected_warehouse = value; }
        }

        [Column("subcontracting_order")]
        public string? SubcontractingOrder
        {
            get { return data.subcontracting_order; }
            set { data.subcontracting_order = value; }
        }

        [Column("schedule_date")]
        public DateOnly? ScheduleDate
        {
            get { return data.schedule_date; }
            set { data.schedule_date = value; }
        }

        [Column("quality_inspection")]
        public string? QualityInspection
        {
            get { return data.quality_inspection; }
            set { data.quality_inspection = value; }
        }

        [Column("subcontracting_order_item")]
        public string? SubcontractingOrderItem
        {
            get { return data.subcontracting_order_item; }
            set { data.subcontracting_order_item = value; }
        }

        [Column("subcontracting_receipt_item")]
        public string? SubcontractingReceiptItem
        {
            get { return data.subcontracting_receipt_item; }
            set { data.subcontracting_receipt_item = value; }
        }

        [Column("bom")]
        public string? Bom
        {
            get { return data.bom; }
            set { data.bom = value; }
        }

        [Column("serial_no")]
        public string? SerialNo
        {
            get { return data.serial_no; }
            set { data.serial_no = value; }
        }

        [Column("batch_no")]
        public string? BatchNo
        {
            get { return data.batch_no; }
            set { data.batch_no = value; }
        }

        [Column("rejected_serial_no")]
        public string? RejectedSerialNo
        {
            get { return data.rejected_serial_no; }
            set { data.rejected_serial_no = value; }
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

        [Column("expense_account")]
        public string? ExpenseAccount
        {
            get { return data.expense_account; }
            set { data.expense_account = value; }
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
