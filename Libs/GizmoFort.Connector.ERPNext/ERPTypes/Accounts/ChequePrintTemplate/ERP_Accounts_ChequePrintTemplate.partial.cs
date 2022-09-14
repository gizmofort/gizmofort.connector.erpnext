/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/14/2022 8:42:56 AM
********************************************************************/

using System;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using GizmoFort.Connector.ERPNext.DataAnnotations;
using GizmoFort.Connector.ERPNext.Serialization;
using _DocType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.ChequePrintTemplate
{
    public partial class ERP_Accounts_ChequePrintTemplate : ERPNextObjectBase
    {
        public ERP_Accounts_ChequePrintTemplate() : this(new ERPObject(_DocType.Accounts_ChequePrintTemplate)) { }
        public ERP_Accounts_ChequePrintTemplate(ERPObject obj) : base(obj) { }

        [ColumnInfo("name", "varchar(140)", isNullable: false)]
        public string Name
        {
            get { return data.name; }
            set { data.name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("creation", "datetime(6)", isNullable: true)]
        public DateTimeOffset? Creation
        {
            get { return ERPNextConverter.StringToDateTimeOffset(data.creation); }
            set { data.creation = ERPNextConverter.DateTimeOffsetToString(value, 6); }
        }

        [ColumnInfo("modified", "datetime(6)", isNullable: true)]
        public DateTimeOffset? Modified
        {
            get { return ERPNextConverter.StringToDateTimeOffset(data.modified); }
            set { data.modified = ERPNextConverter.DateTimeOffsetToString(value, 6); }
        }

        [ColumnInfo("modified_by", "varchar(140)", isNullable: true)]
        public string? ModifiedBy
        {
            get { return data.modified_by; }
            set { data.modified_by = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("owner", "varchar(140)", isNullable: true)]
        public string? Owner
        {
            get { return data.owner; }
            set { data.owner = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("docstatus", "int(1)", isNullable: false)]
        public Docstatus Docstatus
        {
            get { return (Docstatus)data.docstatus; }
            set { data.docstatus = (int)value; }
        }

        [ColumnInfo("idx", "int(8)", isNullable: false)]
        public int Idx
        {
            get { return data.idx; }
            set { data.idx = value; }
        }

        [ColumnInfo("has_print_format", "int(1)", isNullable: false)]
        public bool HasPrintFormat
        {
            get { return ERPNextConverter.IntToBool((int)data.has_print_format); }
            set { data.has_print_format = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("bank_name", "varchar(140)", isNullable: true)]
        public string? BankName
        {
            get { return data.bank_name; }
            set { data.bank_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("cheque_size", "varchar(140)", isNullable: true)]
        public string? ChequeSize
        {
            get { return data.cheque_size; }
            set { data.cheque_size = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("starting_position_from_top_edge", "decimal(21,9)", isNullable: false)]
        public decimal StartingPositionFromTopEdge
        {
            get { return data.starting_position_from_top_edge; }
            set { data.starting_position_from_top_edge = value; }
        }

        [ColumnInfo("cheque_width", "decimal(21,9)", isNullable: false)]
        public decimal ChequeWidth
        {
            get { return data.cheque_width; }
            set { data.cheque_width = value; }
        }

        [ColumnInfo("cheque_height", "decimal(21,9)", isNullable: false)]
        public decimal ChequeHeight
        {
            get { return data.cheque_height; }
            set { data.cheque_height = value; }
        }

        [ColumnInfo("scanned_cheque", "text", isNullable: true)]
        public string? ScannedCheque
        {
            get { return data.scanned_cheque; }
            set { data.scanned_cheque = value; }
        }

        [ColumnInfo("is_account_payable", "int(1)", isNullable: false)]
        public bool IsAccountPayable
        {
            get { return ERPNextConverter.IntToBool((int)data.is_account_payable); }
            set { data.is_account_payable = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("acc_pay_dist_from_top_edge", "decimal(21,9)", isNullable: false)]
        public decimal AccPayDistFromTopEdge
        {
            get { return data.acc_pay_dist_from_top_edge; }
            set { data.acc_pay_dist_from_top_edge = value; }
        }

        [ColumnInfo("acc_pay_dist_from_left_edge", "decimal(21,9)", isNullable: false)]
        public decimal AccPayDistFromLeftEdge
        {
            get { return data.acc_pay_dist_from_left_edge; }
            set { data.acc_pay_dist_from_left_edge = value; }
        }

        [ColumnInfo("message_to_show", "varchar(140)", isNullable: true)]
        public string? MessageToShow
        {
            get { return data.message_to_show; }
            set { data.message_to_show = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("date_dist_from_top_edge", "decimal(21,9)", isNullable: false)]
        public decimal DateDistFromTopEdge
        {
            get { return data.date_dist_from_top_edge; }
            set { data.date_dist_from_top_edge = value; }
        }

        [ColumnInfo("date_dist_from_left_edge", "decimal(21,9)", isNullable: false)]
        public decimal DateDistFromLeftEdge
        {
            get { return data.date_dist_from_left_edge; }
            set { data.date_dist_from_left_edge = value; }
        }

        [ColumnInfo("payer_name_from_top_edge", "decimal(21,9)", isNullable: false)]
        public decimal PayerNameFromTopEdge
        {
            get { return data.payer_name_from_top_edge; }
            set { data.payer_name_from_top_edge = value; }
        }

        [ColumnInfo("payer_name_from_left_edge", "decimal(21,9)", isNullable: false)]
        public decimal PayerNameFromLeftEdge
        {
            get { return data.payer_name_from_left_edge; }
            set { data.payer_name_from_left_edge = value; }
        }

        [ColumnInfo("amt_in_words_from_top_edge", "decimal(21,9)", isNullable: false)]
        public decimal AmtInWordsFromTopEdge
        {
            get { return data.amt_in_words_from_top_edge; }
            set { data.amt_in_words_from_top_edge = value; }
        }

        [ColumnInfo("amt_in_words_from_left_edge", "decimal(21,9)", isNullable: false)]
        public decimal AmtInWordsFromLeftEdge
        {
            get { return data.amt_in_words_from_left_edge; }
            set { data.amt_in_words_from_left_edge = value; }
        }

        [ColumnInfo("amt_in_word_width", "decimal(21,9)", isNullable: false)]
        public decimal AmtInWordWidth
        {
            get { return data.amt_in_word_width; }
            set { data.amt_in_word_width = value; }
        }

        [ColumnInfo("amt_in_words_line_spacing", "decimal(21,9)", isNullable: false)]
        public decimal AmtInWordsLineSpacing
        {
            get { return data.amt_in_words_line_spacing; }
            set { data.amt_in_words_line_spacing = value; }
        }

        [ColumnInfo("amt_in_figures_from_top_edge", "decimal(21,9)", isNullable: false)]
        public decimal AmtInFiguresFromTopEdge
        {
            get { return data.amt_in_figures_from_top_edge; }
            set { data.amt_in_figures_from_top_edge = value; }
        }

        [ColumnInfo("amt_in_figures_from_left_edge", "decimal(21,9)", isNullable: false)]
        public decimal AmtInFiguresFromLeftEdge
        {
            get { return data.amt_in_figures_from_left_edge; }
            set { data.amt_in_figures_from_left_edge = value; }
        }

        [ColumnInfo("acc_no_dist_from_top_edge", "decimal(21,9)", isNullable: false)]
        public decimal AccNoDistFromTopEdge
        {
            get { return data.acc_no_dist_from_top_edge; }
            set { data.acc_no_dist_from_top_edge = value; }
        }

        [ColumnInfo("acc_no_dist_from_left_edge", "decimal(21,9)", isNullable: false)]
        public decimal AccNoDistFromLeftEdge
        {
            get { return data.acc_no_dist_from_left_edge; }
            set { data.acc_no_dist_from_left_edge = value; }
        }

        [ColumnInfo("signatory_from_top_edge", "decimal(21,9)", isNullable: false)]
        public decimal SignatoryFromTopEdge
        {
            get { return data.signatory_from_top_edge; }
            set { data.signatory_from_top_edge = value; }
        }

        [ColumnInfo("signatory_from_left_edge", "decimal(21,9)", isNullable: false)]
        public decimal SignatoryFromLeftEdge
        {
            get { return data.signatory_from_left_edge; }
            set { data.signatory_from_left_edge = value; }
        }

        [ColumnInfo("_user_tags", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _UserTags
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._user_tags; }
            set { data._user_tags = value; }
        }

        [ColumnInfo("_comments", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Comments
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._comments; }
            set { data._comments = value; }
        }

        [ColumnInfo("_assign", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Assign
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._assign; }
            set { data._assign = value; }
        }

        [ColumnInfo("_liked_by", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _LikedBy
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._liked_by; }
            set { data._liked_by = value; }
        }


    }
}

