/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Support.SupportSearchSource
{
    public partial class ERP_Support_SupportSearchSource : ERPNextObjectBase
    {
        public ERP_Support_SupportSearchSource() : this(new ERPObject(_DockType.Support_SupportSearchSource)) { }
        public ERP_Support_SupportSearchSource(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Support_SupportSearchSource>(propertyName);
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

        [Column("source_name")]
        public string? SourceName
        {
            get { return data.source_name; }
            set { data.source_name = value; }
        }

        [Column("source_type")]
        public string? SourceType
        {
            get { return data.source_type; }
            set { data.source_type = value; }
        }

        [Column("base_url")]
        public string? BaseUrl
        {
            get { return data.base_url; }
            set { data.base_url = value; }
        }

        [Column("query_route")]
        public string? QueryRoute
        {
            get { return data.query_route; }
            set { data.query_route = value; }
        }

        [Column("search_term_param_name")]
        public string? SearchTermParamName
        {
            get { return data.search_term_param_name; }
            set { data.search_term_param_name = value; }
        }

        [Column("response_result_key_path")]
        public string? ResponseResultKeyPath
        {
            get { return data.response_result_key_path; }
            set { data.response_result_key_path = value; }
        }

        [Column("post_route")]
        public string? PostRoute
        {
            get { return data.post_route; }
            set { data.post_route = value; }
        }

        [Column("post_route_key_list")]
        public string? PostRouteKeyList
        {
            get { return data.post_route_key_list; }
            set { data.post_route_key_list = value; }
        }

        [Column("post_title_key")]
        public string? PostTitleKey
        {
            get { return data.post_title_key; }
            set { data.post_title_key = value; }
        }

        [Column("post_description_key")]
        public string? PostDescriptionKey
        {
            get { return data.post_description_key; }
            set { data.post_description_key = value; }
        }

        [Column("source_doctype")]
        public string? SourceDoctype
        {
            get { return data.source_doctype; }
            set { data.source_doctype = value; }
        }

        [Column("result_title_field")]
        public string? ResultTitleField
        {
            get { return data.result_title_field; }
            set { data.result_title_field = value; }
        }

        [Column("result_preview_field")]
        public string? ResultPreviewField
        {
            get { return data.result_preview_field; }
            set { data.result_preview_field = value; }
        }

        [Column("result_route_field")]
        public string? ResultRouteField
        {
            get { return data.result_route_field; }
            set { data.result_route_field = value; }
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

