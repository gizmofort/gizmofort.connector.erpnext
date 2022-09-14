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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Custom.CustomField
{
    public partial class ERP_Custom_CustomField : ERPNextObjectBase
    {
        public ERP_Custom_CustomField() : this(new ERPObject(_DocType.Custom_CustomField)) { }
        public ERP_Custom_CustomField(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("is_system_generated", "int(1)", isNullable: false)]
        public bool IsSystemGenerated
        {
            get { return ERPNextConverter.IntToBool((int)data.is_system_generated); }
            set { data.is_system_generated = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("dt", "varchar(140)", isNullable: true)]
        public string? Dt
        {
            get { return data.dt; }
            set { data.dt = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("module", "varchar(140)", isNullable: true)]
        public string? Module
        {
            get { return data.module; }
            set { data.module = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("label", "varchar(140)", isNullable: true)]
        public string? Label
        {
            get { return data.label; }
            set { data.label = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("fieldname", "varchar(140)", isNullable: true)]
        public string? Fieldname
        {
            get { return data.fieldname; }
            set { data.fieldname = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("insert_after", "varchar(140)", isNullable: true)]
        public string? InsertAfter
        {
            get { return data.insert_after; }
            set { data.insert_after = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("length", "int(11)", isNullable: false)]
        public int Length
        {
            get { return data.length; }
            set { data.length = value; }
        }

        [ColumnInfo("fieldtype", "varchar(140)", isNullable: true)]
        public string? Fieldtype
        {
            get { return data.fieldtype; }
            set { data.fieldtype = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("precision", "varchar(140)", isNullable: true)]
        public string? Precision
        {
            get { return data.precision; }
            set { data.precision = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("hide_seconds", "int(1)", isNullable: false)]
        public bool HideSeconds
        {
            get { return ERPNextConverter.IntToBool((int)data.hide_seconds); }
            set { data.hide_seconds = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("hide_days", "int(1)", isNullable: false)]
        public bool HideDays
        {
            get { return ERPNextConverter.IntToBool((int)data.hide_days); }
            set { data.hide_days = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("options", "text", isNullable: true)]
        public string? Options
        {
            get { return data.options; }
            set { data.options = value; }
        }

        [ColumnInfo("fetch_from", "text", isNullable: true)]
        public string? FetchFrom
        {
            get { return data.fetch_from; }
            set { data.fetch_from = value; }
        }

        [ColumnInfo("fetch_if_empty", "int(1)", isNullable: false)]
        public bool FetchIfEmpty
        {
            get { return ERPNextConverter.IntToBool((int)data.fetch_if_empty); }
            set { data.fetch_if_empty = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("collapsible", "int(1)", isNullable: false)]
        public bool Collapsible
        {
            get { return ERPNextConverter.IntToBool((int)data.collapsible); }
            set { data.collapsible = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("collapsible_depends_on", "longtext", isNullable: true)]
        public string? CollapsibleDependsOn
        {
            get { return data.collapsible_depends_on; }
            set { data.collapsible_depends_on = value; }
        }

        [ColumnInfo("@default", "text", isNullable: true)]
        public string? Default
        {
            get { return data.@default; }
            set { data.@default = value; }
        }

        [ColumnInfo("depends_on", "longtext", isNullable: true)]
        public string? DependsOn
        {
            get { return data.depends_on; }
            set { data.depends_on = value; }
        }

        [ColumnInfo("mandatory_depends_on", "longtext", isNullable: true)]
        public string? MandatoryDependsOn
        {
            get { return data.mandatory_depends_on; }
            set { data.mandatory_depends_on = value; }
        }

        [ColumnInfo("read_only_depends_on", "longtext", isNullable: true)]
        public string? ReadOnlyDependsOn
        {
            get { return data.read_only_depends_on; }
            set { data.read_only_depends_on = value; }
        }

        [ColumnInfo("non_negative", "int(1)", isNullable: false)]
        public bool NonNegative
        {
            get { return ERPNextConverter.IntToBool((int)data.non_negative); }
            set { data.non_negative = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("reqd", "int(1)", isNullable: false)]
        public bool Reqd
        {
            get { return ERPNextConverter.IntToBool((int)data.reqd); }
            set { data.reqd = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("unique", "int(1)", isNullable: false)]
        public bool Unique
        {
            get { return ERPNextConverter.IntToBool((int)data.unique); }
            set { data.unique = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("is_virtual", "int(1)", isNullable: false)]
        public bool IsVirtual
        {
            get { return ERPNextConverter.IntToBool((int)data.is_virtual); }
            set { data.is_virtual = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("read_only", "int(1)", isNullable: false)]
        public bool ReadOnly
        {
            get { return ERPNextConverter.IntToBool((int)data.read_only); }
            set { data.read_only = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("ignore_user_permissions", "int(1)", isNullable: false)]
        public bool IgnoreUserPermissions
        {
            get { return ERPNextConverter.IntToBool((int)data.ignore_user_permissions); }
            set { data.ignore_user_permissions = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("hidden", "int(1)", isNullable: false)]
        public bool Hidden
        {
            get { return ERPNextConverter.IntToBool((int)data.hidden); }
            set { data.hidden = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("print_hide", "int(1)", isNullable: false)]
        public bool PrintHide
        {
            get { return ERPNextConverter.IntToBool((int)data.print_hide); }
            set { data.print_hide = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("print_hide_if_no_value", "int(1)", isNullable: false)]
        public bool PrintHideIfNoValue
        {
            get { return ERPNextConverter.IntToBool((int)data.print_hide_if_no_value); }
            set { data.print_hide_if_no_value = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("print_width", "varchar(140)", isNullable: true)]
        public string? PrintWidth
        {
            get { return data.print_width; }
            set { data.print_width = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("no_copy", "int(1)", isNullable: false)]
        public bool NoCopy
        {
            get { return ERPNextConverter.IntToBool((int)data.no_copy); }
            set { data.no_copy = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("allow_on_submit", "int(1)", isNullable: false)]
        public bool AllowOnSubmit
        {
            get { return ERPNextConverter.IntToBool((int)data.allow_on_submit); }
            set { data.allow_on_submit = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("in_list_view", "int(1)", isNullable: false)]
        public bool InListView
        {
            get { return ERPNextConverter.IntToBool((int)data.in_list_view); }
            set { data.in_list_view = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("in_standard_filter", "int(1)", isNullable: false)]
        public bool InStandardFilter
        {
            get { return ERPNextConverter.IntToBool((int)data.in_standard_filter); }
            set { data.in_standard_filter = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("in_global_search", "int(1)", isNullable: false)]
        public bool InGlobalSearch
        {
            get { return ERPNextConverter.IntToBool((int)data.in_global_search); }
            set { data.in_global_search = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("in_preview", "int(1)", isNullable: false)]
        public bool InPreview
        {
            get { return ERPNextConverter.IntToBool((int)data.in_preview); }
            set { data.in_preview = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("bold", "int(1)", isNullable: false)]
        public bool Bold
        {
            get { return ERPNextConverter.IntToBool((int)data.bold); }
            set { data.bold = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("report_hide", "int(1)", isNullable: false)]
        public bool ReportHide
        {
            get { return ERPNextConverter.IntToBool((int)data.report_hide); }
            set { data.report_hide = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("search_index", "int(1)", isNullable: false)]
        public bool SearchIndex
        {
            get { return ERPNextConverter.IntToBool((int)data.search_index); }
            set { data.search_index = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("allow_in_quick_entry", "int(1)", isNullable: false)]
        public bool AllowInQuickEntry
        {
            get { return ERPNextConverter.IntToBool((int)data.allow_in_quick_entry); }
            set { data.allow_in_quick_entry = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("ignore_xss_filter", "int(1)", isNullable: false)]
        public bool IgnoreXssFilter
        {
            get { return ERPNextConverter.IntToBool((int)data.ignore_xss_filter); }
            set { data.ignore_xss_filter = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("translatable", "int(1)", isNullable: false)]
        public bool Translatable
        {
            get { return ERPNextConverter.IntToBool((int)data.translatable); }
            set { data.translatable = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("hide_border", "int(1)", isNullable: false)]
        public bool HideBorder
        {
            get { return ERPNextConverter.IntToBool((int)data.hide_border); }
            set { data.hide_border = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("description", "text", isNullable: true)]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [ColumnInfo("permlevel", "int(11)", isNullable: false)]
        public int Permlevel
        {
            get { return data.permlevel; }
            set { data.permlevel = value; }
        }

        [ColumnInfo("width", "varchar(140)", isNullable: true)]
        public string? Width
        {
            get { return data.width; }
            set { data.width = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("columns", "int(11)", isNullable: false)]
        public int Columns
        {
            get { return data.columns; }
            set { data.columns = value; }
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

