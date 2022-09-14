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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.Report
{
    public partial class ERP_Core_Report : ERPNextObjectBase
    {
        public ERP_Core_Report() : this(new ERPObject(_DocType.Core_Report)) { }
        public ERP_Core_Report(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("report_name", "varchar(140)", isNullable: true)]
        public string? ReportName
        {
            get { return data.report_name; }
            set { data.report_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("ref_doctype", "varchar(140)", isNullable: true)]
        public string? RefDoctype
        {
            get { return data.ref_doctype; }
            set { data.ref_doctype = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("reference_report", "varchar(140)", isNullable: true)]
        public string? ReferenceReport
        {
            get { return data.reference_report; }
            set { data.reference_report = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("is_standard", "varchar(140)", isNullable: true)]
        public string? IsStandard
        {
            get { return data.is_standard; }
            set { data.is_standard = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("module", "varchar(140)", isNullable: true)]
        public string? Module
        {
            get { return data.module; }
            set { data.module = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("report_type", "varchar(140)", isNullable: true)]
        public string? ReportType
        {
            get { return data.report_type; }
            set { data.report_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("letter_head", "varchar(140)", isNullable: true)]
        public string? LetterHead
        {
            get { return data.letter_head; }
            set { data.letter_head = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("add_total_row", "int(1)", isNullable: false)]
        public bool AddTotalRow
        {
            get { return ERPNextConverter.IntToBool((int)data.add_total_row); }
            set { data.add_total_row = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("disabled", "int(1)", isNullable: false)]
        public bool Disabled
        {
            get { return ERPNextConverter.IntToBool((int)data.disabled); }
            set { data.disabled = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("disable_prepared_report", "int(1)", isNullable: false)]
        public bool DisablePreparedReport
        {
            get { return ERPNextConverter.IntToBool((int)data.disable_prepared_report); }
            set { data.disable_prepared_report = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("prepared_report", "int(1)", isNullable: false)]
        public bool PreparedReport
        {
            get { return ERPNextConverter.IntToBool((int)data.prepared_report); }
            set { data.prepared_report = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("query", "longtext", isNullable: true)]
        public string? Query
        {
            get { return data.query; }
            set { data.query = value; }
        }

        [ColumnInfo("report_script", "longtext", isNullable: true)]
        public string? ReportScript
        {
            get { return data.report_script; }
            set { data.report_script = value; }
        }

        [ColumnInfo("javascript", "longtext", isNullable: true)]
        public string? Javascript
        {
            get { return data.javascript; }
            set { data.javascript = value; }
        }

        [ColumnInfo("json", "longtext", isNullable: true)]
        public string? Json
        {
            get { return data.json; }
            set { data.json = value; }
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

