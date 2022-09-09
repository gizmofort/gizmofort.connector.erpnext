/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Desk.NumberCard
{
    public partial class ERP_Desk_NumberCard : ERPNextObjectBase
    {
        public ERP_Desk_NumberCard() : this(new ERPObject(_DockType.Desk_NumberCard)) { }
        public ERP_Desk_NumberCard(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Desk_NumberCard>(propertyName);
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

        [Column("is_standard")]
        public int IsStandard
        {
            get { return data.is_standard; }
            set { data.is_standard = value; }
        }

        [Column("module")]
        public string? Module
        {
            get { return data.module; }
            set { data.module = value; }
        }

        [Column("label")]
        public string? Label
        {
            get { return data.label; }
            set { data.label = value; }
        }

        [Column("type")]
        public string? Type
        {
            get { return data.type; }
            set { data.type = value; }
        }

        [Column("report_name")]
        public string? ReportName
        {
            get { return data.report_name; }
            set { data.report_name = value; }
        }

        [Column("method")]
        public string? Method
        {
            get { return data.method; }
            set { data.method = value; }
        }

        [Column("function")]
        public string? Function
        {
            get { return data.function; }
            set { data.function = value; }
        }

        [Column("aggregate_function_based_on")]
        public string? AggregateFunctionBasedOn
        {
            get { return data.aggregate_function_based_on; }
            set { data.aggregate_function_based_on = value; }
        }

        [Column("document_type")]
        public string? DocumentType
        {
            get { return data.document_type; }
            set { data.document_type = value; }
        }

        [Column("parent_document_type")]
        public string? ParentDocumentType
        {
            get { return data.parent_document_type; }
            set { data.parent_document_type = value; }
        }

        [Column("report_field")]
        public string? ReportField
        {
            get { return data.report_field; }
            set { data.report_field = value; }
        }

        [Column("report_function")]
        public string? ReportFunction
        {
            get { return data.report_function; }
            set { data.report_function = value; }
        }

        [Column("is_public")]
        public int IsPublic
        {
            get { return data.is_public; }
            set { data.is_public = value; }
        }

        [Column("filters_config")]
        public string? FiltersConfig
        {
            get { return data.filters_config; }
            set { data.filters_config = value; }
        }

        [Column("show_percentage_stats")]
        public int ShowPercentageStats
        {
            get { return data.show_percentage_stats; }
            set { data.show_percentage_stats = value; }
        }

        [Column("stats_time_interval")]
        public string? StatsTimeInterval
        {
            get { return data.stats_time_interval; }
            set { data.stats_time_interval = value; }
        }

        [Column("filters_json")]
        public string? FiltersJson
        {
            get { return data.filters_json; }
            set { data.filters_json = value; }
        }

        [Column("dynamic_filters_json")]
        public string? DynamicFiltersJson
        {
            get { return data.dynamic_filters_json; }
            set { data.dynamic_filters_json = value; }
        }

        [Column("color")]
        public string? Color
        {
            get { return data.color; }
            set { data.color = value; }
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
