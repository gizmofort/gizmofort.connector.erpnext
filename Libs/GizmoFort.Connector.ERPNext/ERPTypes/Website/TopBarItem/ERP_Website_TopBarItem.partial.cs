/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Website.TopBarItem
{
    public partial class ERP_Website_TopBarItem : ERPNextObjectBase
    {
        public ERP_Website_TopBarItem() : this(new ERPObject(_DockType.Website_TopBarItem)) { }
        public ERP_Website_TopBarItem(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Website_TopBarItem>(propertyName);
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

        [Column("label")]
        public string? Label
        {
            get { return data.label; }
            set { data.label = value; }
        }

        [Column("url")]
        public string? Url
        {
            get { return data.url; }
            set { data.url = value; }
        }

        [Column("open_in_new_tab")]
        public int OpenInNewTab
        {
            get { return data.open_in_new_tab; }
            set { data.open_in_new_tab = value; }
        }

        [Column("right")]
        public int Right
        {
            get { return data.right; }
            set { data.right = value; }
        }

        [Column("parent_label")]
        public string? ParentLabel
        {
            get { return data.parent_label; }
            set { data.parent_label = value; }
        }

        [Column("icon")]
        public string? Icon
        {
            get { return data.icon; }
            set { data.icon = value; }
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
