/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.StockLedgerEntry
{
    public partial class ERP_Stock_StockLedgerEntry : ERPNextObjectBase
    {
        public ERP_Stock_StockLedgerEntry() : this(new ERPObject(_DockType.Stock_StockLedgerEntry)) { }
        public ERP_Stock_StockLedgerEntry(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Stock_StockLedgerEntry>(propertyName);
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

        [Column("warehouse")]
        public string? Warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        [Column("posting_date")]
        public DateOnly? PostingDate
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        [Column("posting_time")]
        public TimeSpan? PostingTime
        {
            get { return data.posting_time; }
            set { data.posting_time = value; }
        }

        [Column("voucher_type")]
        public string? VoucherType
        {
            get { return data.voucher_type; }
            set { data.voucher_type = value; }
        }

        [Column("voucher_no")]
        public string? VoucherNo
        {
            get { return data.voucher_no; }
            set { data.voucher_no = value; }
        }

        [Column("voucher_detail_no")]
        public string? VoucherDetailNo
        {
            get { return data.voucher_detail_no; }
            set { data.voucher_detail_no = value; }
        }

        [Column("dependant_sle_voucher_detail_no")]
        public string? DependantSleVoucherDetailNo
        {
            get { return data.dependant_sle_voucher_detail_no; }
            set { data.dependant_sle_voucher_detail_no = value; }
        }

        [Column("recalculate_rate")]
        public int RecalculateRate
        {
            get { return data.recalculate_rate; }
            set { data.recalculate_rate = value; }
        }

        [Column("actual_qty")]
        public decimal ActualQty
        {
            get { return data.actual_qty; }
            set { data.actual_qty = value; }
        }

        [Column("qty_after_transaction")]
        public decimal QtyAfterTransaction
        {
            get { return data.qty_after_transaction; }
            set { data.qty_after_transaction = value; }
        }

        [Column("incoming_rate")]
        public decimal IncomingRate
        {
            get { return data.incoming_rate; }
            set { data.incoming_rate = value; }
        }

        [Column("outgoing_rate")]
        public decimal OutgoingRate
        {
            get { return data.outgoing_rate; }
            set { data.outgoing_rate = value; }
        }

        [Column("valuation_rate")]
        public decimal ValuationRate
        {
            get { return data.valuation_rate; }
            set { data.valuation_rate = value; }
        }

        [Column("stock_value")]
        public decimal StockValue
        {
            get { return data.stock_value; }
            set { data.stock_value = value; }
        }

        [Column("stock_value_difference")]
        public decimal StockValueDifference
        {
            get { return data.stock_value_difference; }
            set { data.stock_value_difference = value; }
        }

        [Column("stock_queue")]
        public string? StockQueue
        {
            get { return data.stock_queue; }
            set { data.stock_queue = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("stock_uom")]
        public string? StockUom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
        }

        [Column("project")]
        public string? Project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        [Column("batch_no")]
        public string? BatchNo
        {
            get { return data.batch_no; }
            set { data.batch_no = value; }
        }

        [Column("fiscal_year")]
        public string? FiscalYear
        {
            get { return data.fiscal_year; }
            set { data.fiscal_year = value; }
        }

        [Column("serial_no")]
        public string? SerialNo
        {
            get { return data.serial_no; }
            set { data.serial_no = value; }
        }

        [Column("is_cancelled")]
        public int IsCancelled
        {
            get { return data.is_cancelled; }
            set { data.is_cancelled = value; }
        }

        [Column("to_rename")]
        public int ToRename
        {
            get { return data.to_rename; }
            set { data.to_rename = value; }
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
