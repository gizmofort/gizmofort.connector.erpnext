/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Manufacturing.WorkOrder
{
    public partial class ERP_Manufacturing_WorkOrder : ERPNextObjectBase
    {
        public ERP_Manufacturing_WorkOrder() : this(new ERPObject(_DockType.Manufacturing_WorkOrder)) { }
        public ERP_Manufacturing_WorkOrder(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Manufacturing_WorkOrder>(propertyName);
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

        [Column("status")]
        public string? Status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        [Column("production_item")]
        public string? ProductionItem
        {
            get { return data.production_item; }
            set { data.production_item = value; }
        }

        [Column("item_name")]
        public string? ItemName
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        [Column("image")]
        public string? Image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        [Column("bom_no")]
        public string? BomNo
        {
            get { return data.bom_no; }
            set { data.bom_no = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("qty")]
        public decimal Qty
        {
            get { return data.qty; }
            set { data.qty = value; }
        }

        [Column("material_transferred_for_manufacturing")]
        public decimal MaterialTransferredForManufacturing
        {
            get { return data.material_transferred_for_manufacturing; }
            set { data.material_transferred_for_manufacturing = value; }
        }

        [Column("produced_qty")]
        public decimal ProducedQty
        {
            get { return data.produced_qty; }
            set { data.produced_qty = value; }
        }

        [Column("process_loss_qty")]
        public decimal ProcessLossQty
        {
            get { return data.process_loss_qty; }
            set { data.process_loss_qty = value; }
        }

        [Column("sales_order")]
        public string? SalesOrder
        {
            get { return data.sales_order; }
            set { data.sales_order = value; }
        }

        [Column("project")]
        public string? Project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        [Column("has_serial_no")]
        public int HasSerialNo
        {
            get { return data.has_serial_no; }
            set { data.has_serial_no = value; }
        }

        [Column("has_batch_no")]
        public int HasBatchNo
        {
            get { return data.has_batch_no; }
            set { data.has_batch_no = value; }
        }

        [Column("serial_no")]
        public string? SerialNo
        {
            get { return data.serial_no; }
            set { data.serial_no = value; }
        }

        [Column("batch_size")]
        public decimal BatchSize
        {
            get { return data.batch_size; }
            set { data.batch_size = value; }
        }

        [Column("allow_alternative_item")]
        public int AllowAlternativeItem
        {
            get { return data.allow_alternative_item; }
            set { data.allow_alternative_item = value; }
        }

        [Column("use_multi_level_bom")]
        public int UseMultiLevelBom
        {
            get { return data.use_multi_level_bom; }
            set { data.use_multi_level_bom = value; }
        }

        [Column("skip_transfer")]
        public int SkipTransfer
        {
            get { return data.skip_transfer; }
            set { data.skip_transfer = value; }
        }

        [Column("from_wip_warehouse")]
        public int FromWipWarehouse
        {
            get { return data.from_wip_warehouse; }
            set { data.from_wip_warehouse = value; }
        }

        [Column("update_consumed_material_cost_in_project")]
        public int UpdateConsumedMaterialCostInProject
        {
            get { return data.update_consumed_material_cost_in_project; }
            set { data.update_consumed_material_cost_in_project = value; }
        }

        [Column("source_warehouse")]
        public string? SourceWarehouse
        {
            get { return data.source_warehouse; }
            set { data.source_warehouse = value; }
        }

        [Column("wip_warehouse")]
        public string? WipWarehouse
        {
            get { return data.wip_warehouse; }
            set { data.wip_warehouse = value; }
        }

        [Column("fg_warehouse")]
        public string? FgWarehouse
        {
            get { return data.fg_warehouse; }
            set { data.fg_warehouse = value; }
        }

        [Column("scrap_warehouse")]
        public string? ScrapWarehouse
        {
            get { return data.scrap_warehouse; }
            set { data.scrap_warehouse = value; }
        }

        [Column("planned_start_date")]
        public DateTime? PlannedStartDate
        {
            get { return data.planned_start_date; }
            set { data.planned_start_date = value; }
        }

        [Column("planned_end_date")]
        public DateTime? PlannedEndDate
        {
            get { return data.planned_end_date; }
            set { data.planned_end_date = value; }
        }

        [Column("expected_delivery_date")]
        public DateOnly? ExpectedDeliveryDate
        {
            get { return data.expected_delivery_date; }
            set { data.expected_delivery_date = value; }
        }

        [Column("actual_start_date")]
        public DateTime? ActualStartDate
        {
            get { return data.actual_start_date; }
            set { data.actual_start_date = value; }
        }

        [Column("actual_end_date")]
        public DateTime? ActualEndDate
        {
            get { return data.actual_end_date; }
            set { data.actual_end_date = value; }
        }

        [Column("lead_time")]
        public decimal LeadTime
        {
            get { return data.lead_time; }
            set { data.lead_time = value; }
        }

        [Column("transfer_material_against")]
        public string? TransferMaterialAgainst
        {
            get { return data.transfer_material_against; }
            set { data.transfer_material_against = value; }
        }

        [Column("planned_operating_cost")]
        public decimal PlannedOperatingCost
        {
            get { return data.planned_operating_cost; }
            set { data.planned_operating_cost = value; }
        }

        [Column("actual_operating_cost")]
        public decimal ActualOperatingCost
        {
            get { return data.actual_operating_cost; }
            set { data.actual_operating_cost = value; }
        }

        [Column("additional_operating_cost")]
        public decimal AdditionalOperatingCost
        {
            get { return data.additional_operating_cost; }
            set { data.additional_operating_cost = value; }
        }

        [Column("corrective_operation_cost")]
        public decimal CorrectiveOperationCost
        {
            get { return data.corrective_operation_cost; }
            set { data.corrective_operation_cost = value; }
        }

        [Column("total_operating_cost")]
        public decimal TotalOperatingCost
        {
            get { return data.total_operating_cost; }
            set { data.total_operating_cost = value; }
        }

        [Column("description")]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [Column("stock_uom")]
        public string? StockUom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
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

        [Column("sales_order_item")]
        public string? SalesOrderItem
        {
            get { return data.sales_order_item; }
            set { data.sales_order_item = value; }
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

        [Column("product_bundle_item")]
        public string? ProductBundleItem
        {
            get { return data.product_bundle_item; }
            set { data.product_bundle_item = value; }
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

        [Column("_seen")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Seen
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._seen; }
            set { data._seen = value; }
        }


    }
}
