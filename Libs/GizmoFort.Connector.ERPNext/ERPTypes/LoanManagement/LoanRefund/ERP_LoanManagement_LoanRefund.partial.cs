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

namespace GizmoFort.Connector.ERPNext.ERPTypes.LoanManagement.LoanRefund
{
    public partial class ERP_LoanManagement_LoanRefund : ERPNextObjectBase
    {
        public ERP_LoanManagement_LoanRefund() : this(new ERPObject(_DocType.LoanManagement_LoanRefund)) { }
        public ERP_LoanManagement_LoanRefund(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("loan", "varchar(140)", isNullable: true)]
        public string? Loan
        {
            get { return data.loan; }
            set { data.loan = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("applicant_type", "varchar(140)", isNullable: true)]
        public string? ApplicantType
        {
            get { return data.applicant_type; }
            set { data.applicant_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("applicant", "varchar(140)", isNullable: true)]
        public string? Applicant
        {
            get { return data.applicant; }
            set { data.applicant = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("company", "varchar(140)", isNullable: true)]
        public string? Company
        {
            get { return data.company; }
            set { data.company = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("posting_date", "date", isNullable: true)]
        public DateOnly? PostingDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.posting_date); }
            set { data.posting_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("cost_center", "varchar(140)", isNullable: true)]
        public string? CostCenter
        {
            get { return data.cost_center; }
            set { data.cost_center = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("refund_account", "varchar(140)", isNullable: true)]
        public string? RefundAccount
        {
            get { return data.refund_account; }
            set { data.refund_account = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("refund_amount", "decimal(21,9)", isNullable: false)]
        public decimal RefundAmount
        {
            get { return data.refund_amount; }
            set { data.refund_amount = value; }
        }

        [ColumnInfo("reference_number", "varchar(140)", isNullable: true)]
        public string? ReferenceNumber
        {
            get { return data.reference_number; }
            set { data.reference_number = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("amended_from", "varchar(140)", isNullable: true)]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = ERPNextConverter.TruncateString(value, 140); }
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

