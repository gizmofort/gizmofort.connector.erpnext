/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Desk.WorkspaceLink
{
    public partial class ERP_Desk_WorkspaceLink : ERPNextObjectBase
    {
        public ERP_Desk_WorkspaceLink() : this(new ERPObject(_DockType.Desk_WorkspaceLink)) { }
        public ERP_Desk_WorkspaceLink(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Desk_WorkspaceLink>(propertyName);
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

        [Column("type")]
        public string? Type
        {
            get { return data.type; }
            set { data.type = value; }
        }

        [Column("label")]
        public string? Label
        {
            get { return data.label; }
            set { data.label = value; }
        }

        [Column("icon")]
        public string? Icon
        {
            get { return data.icon; }
            set { data.icon = value; }
        }

        [Column("hidden")]
        public int Hidden
        {
            get { return data.hidden; }
            set { data.hidden = value; }
        }

        [Column("link_type")]
        public string? LinkType
        {
            get { return data.link_type; }
            set { data.link_type = value; }
        }

        [Column("link_to")]
        public string? LinkTo
        {
            get { return data.link_to; }
            set { data.link_to = value; }
        }

        [Column("dependencies")]
        public string? Dependencies
        {
            get { return data.dependencies; }
            set { data.dependencies = value; }
        }

        [Column("only_for")]
        public string? OnlyFor
        {
            get { return data.only_for; }
            set { data.only_for = value; }
        }

        [Column("onboard")]
        public int Onboard
        {
            get { return data.onboard; }
            set { data.onboard = value; }
        }

        [Column("is_query_report")]
        public int IsQueryReport
        {
            get { return data.is_query_report; }
            set { data.is_query_report = value; }
        }

        [Column("link_count")]
        public int LinkCount
        {
            get { return data.link_count; }
            set { data.link_count = value; }
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
