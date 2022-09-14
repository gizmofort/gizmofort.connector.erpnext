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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.PaymentTerm
{
    public partial class ERP_Accounts_PaymentTerm : ERPNextObjectBase
    {
        public ERP_Accounts_PaymentTerm() : this(new ERPObject(_DocType.Accounts_PaymentTerm)) { }
        public ERP_Accounts_PaymentTerm(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("payment_term_name", "varchar(140)", isNullable: true)]
        public string? PaymentTermName
        {
            get { return data.payment_term_name; }
            set { data.payment_term_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("invoice_portion", "decimal(21,9)", isNullable: false)]
        public decimal InvoicePortion
        {
            get { return data.invoice_portion; }
            set { data.invoice_portion = value; }
        }

        [ColumnInfo("mode_of_payment", "varchar(140)", isNullable: true)]
        public string? ModeOfPayment
        {
            get { return data.mode_of_payment; }
            set { data.mode_of_payment = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("due_date_based_on", "varchar(140)", isNullable: true)]
        public string? DueDateBasedOn
        {
            get { return data.due_date_based_on; }
            set { data.due_date_based_on = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("credit_days", "int(11)", isNullable: false)]
        public int CreditDays
        {
            get { return data.credit_days; }
            set { data.credit_days = value; }
        }

        [ColumnInfo("credit_months", "int(11)", isNullable: false)]
        public int CreditMonths
        {
            get { return data.credit_months; }
            set { data.credit_months = value; }
        }

        [ColumnInfo("discount_type", "varchar(140)", isNullable: true)]
        public string? DiscountType
        {
            get { return data.discount_type; }
            set { data.discount_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("discount", "decimal(21,9)", isNullable: false)]
        public decimal Discount
        {
            get { return data.discount; }
            set { data.discount = value; }
        }

        [ColumnInfo("discount_validity_based_on", "varchar(140)", isNullable: true)]
        public string? DiscountValidityBasedOn
        {
            get { return data.discount_validity_based_on; }
            set { data.discount_validity_based_on = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("discount_validity", "int(11)", isNullable: false)]
        public int DiscountValidity
        {
            get { return data.discount_validity; }
            set { data.discount_validity = value; }
        }

        [ColumnInfo("description", "text", isNullable: true)]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
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

