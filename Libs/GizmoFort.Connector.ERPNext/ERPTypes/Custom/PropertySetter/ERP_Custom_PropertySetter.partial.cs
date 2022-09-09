/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Custom.PropertySetter
{
    public partial class ERP_Custom_PropertySetter : ERPNextObjectBase
    {
        public ERP_Custom_PropertySetter() : this(new ERPObject(_DockType.Custom_PropertySetter)) { }
        public ERP_Custom_PropertySetter(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Custom_PropertySetter>(propertyName);
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

        [Column("is_system_generated")]
        public int IsSystemGenerated
        {
            get { return data.is_system_generated; }
            set { data.is_system_generated = value; }
        }

        [Column("doctype_or_field")]
        public string? DoctypeOrField
        {
            get { return data.doctype_or_field; }
            set { data.doctype_or_field = value; }
        }

        [Column("doc_type")]
        public string? DocType
        {
            get { return data.doc_type; }
            set { data.doc_type = value; }
        }

        [Column("field_name")]
        public string? FieldName
        {
            get { return data.field_name; }
            set { data.field_name = value; }
        }

        [Column("row_name")]
        public string? RowName
        {
            get { return data.row_name; }
            set { data.row_name = value; }
        }

        [Column("module")]
        public string? Module
        {
            get { return data.module; }
            set { data.module = value; }
        }

        [Column("property")]
        public string? Property
        {
            get { return data.property; }
            set { data.property = value; }
        }

        [Column("property_type")]
        public string? PropertyType
        {
            get { return data.property_type; }
            set { data.property_type = value; }
        }

        [Column("@value")]
        public string? Value
        {
            get { return data.@value; }
            set { data.@value = value; }
        }

        [Column("default_value")]
        public string? DefaultValue
        {
            get { return data.default_value; }
            set { data.default_value = value; }
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
