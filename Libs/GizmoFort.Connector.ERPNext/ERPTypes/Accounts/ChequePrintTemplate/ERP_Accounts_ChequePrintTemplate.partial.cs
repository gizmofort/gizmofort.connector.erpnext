/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.ChequePrintTemplate
{
    public partial class ERP_Accounts_ChequePrintTemplate : ERPNextObjectBase
    {
        public ERP_Accounts_ChequePrintTemplate() : this(new ERPObject(_DockType.Accounts_ChequePrintTemplate)) { }
        public ERP_Accounts_ChequePrintTemplate(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Accounts_ChequePrintTemplate>(propertyName);
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

        [Column("has_print_format")]
        public int HasPrintFormat
        {
            get { return data.has_print_format; }
            set { data.has_print_format = value; }
        }

        [Column("bank_name")]
        public string? BankName
        {
            get { return data.bank_name; }
            set { data.bank_name = value; }
        }

        [Column("cheque_size")]
        public string? ChequeSize
        {
            get { return data.cheque_size; }
            set { data.cheque_size = value; }
        }

        [Column("starting_position_from_top_edge")]
        public decimal StartingPositionFromTopEdge
        {
            get { return data.starting_position_from_top_edge; }
            set { data.starting_position_from_top_edge = value; }
        }

        [Column("cheque_width")]
        public decimal ChequeWidth
        {
            get { return data.cheque_width; }
            set { data.cheque_width = value; }
        }

        [Column("cheque_height")]
        public decimal ChequeHeight
        {
            get { return data.cheque_height; }
            set { data.cheque_height = value; }
        }

        [Column("scanned_cheque")]
        public string? ScannedCheque
        {
            get { return data.scanned_cheque; }
            set { data.scanned_cheque = value; }
        }

        [Column("is_account_payable")]
        public int IsAccountPayable
        {
            get { return data.is_account_payable; }
            set { data.is_account_payable = value; }
        }

        [Column("acc_pay_dist_from_top_edge")]
        public decimal AccPayDistFromTopEdge
        {
            get { return data.acc_pay_dist_from_top_edge; }
            set { data.acc_pay_dist_from_top_edge = value; }
        }

        [Column("acc_pay_dist_from_left_edge")]
        public decimal AccPayDistFromLeftEdge
        {
            get { return data.acc_pay_dist_from_left_edge; }
            set { data.acc_pay_dist_from_left_edge = value; }
        }

        [Column("message_to_show")]
        public string? MessageToShow
        {
            get { return data.message_to_show; }
            set { data.message_to_show = value; }
        }

        [Column("date_dist_from_top_edge")]
        public decimal DateDistFromTopEdge
        {
            get { return data.date_dist_from_top_edge; }
            set { data.date_dist_from_top_edge = value; }
        }

        [Column("date_dist_from_left_edge")]
        public decimal DateDistFromLeftEdge
        {
            get { return data.date_dist_from_left_edge; }
            set { data.date_dist_from_left_edge = value; }
        }

        [Column("payer_name_from_top_edge")]
        public decimal PayerNameFromTopEdge
        {
            get { return data.payer_name_from_top_edge; }
            set { data.payer_name_from_top_edge = value; }
        }

        [Column("payer_name_from_left_edge")]
        public decimal PayerNameFromLeftEdge
        {
            get { return data.payer_name_from_left_edge; }
            set { data.payer_name_from_left_edge = value; }
        }

        [Column("amt_in_words_from_top_edge")]
        public decimal AmtInWordsFromTopEdge
        {
            get { return data.amt_in_words_from_top_edge; }
            set { data.amt_in_words_from_top_edge = value; }
        }

        [Column("amt_in_words_from_left_edge")]
        public decimal AmtInWordsFromLeftEdge
        {
            get { return data.amt_in_words_from_left_edge; }
            set { data.amt_in_words_from_left_edge = value; }
        }

        [Column("amt_in_word_width")]
        public decimal AmtInWordWidth
        {
            get { return data.amt_in_word_width; }
            set { data.amt_in_word_width = value; }
        }

        [Column("amt_in_words_line_spacing")]
        public decimal AmtInWordsLineSpacing
        {
            get { return data.amt_in_words_line_spacing; }
            set { data.amt_in_words_line_spacing = value; }
        }

        [Column("amt_in_figures_from_top_edge")]
        public decimal AmtInFiguresFromTopEdge
        {
            get { return data.amt_in_figures_from_top_edge; }
            set { data.amt_in_figures_from_top_edge = value; }
        }

        [Column("amt_in_figures_from_left_edge")]
        public decimal AmtInFiguresFromLeftEdge
        {
            get { return data.amt_in_figures_from_left_edge; }
            set { data.amt_in_figures_from_left_edge = value; }
        }

        [Column("acc_no_dist_from_top_edge")]
        public decimal AccNoDistFromTopEdge
        {
            get { return data.acc_no_dist_from_top_edge; }
            set { data.acc_no_dist_from_top_edge = value; }
        }

        [Column("acc_no_dist_from_left_edge")]
        public decimal AccNoDistFromLeftEdge
        {
            get { return data.acc_no_dist_from_left_edge; }
            set { data.acc_no_dist_from_left_edge = value; }
        }

        [Column("signatory_from_top_edge")]
        public decimal SignatoryFromTopEdge
        {
            get { return data.signatory_from_top_edge; }
            set { data.signatory_from_top_edge = value; }
        }

        [Column("signatory_from_left_edge")]
        public decimal SignatoryFromLeftEdge
        {
            get { return data.signatory_from_left_edge; }
            set { data.signatory_from_left_edge = value; }
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
