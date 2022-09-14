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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Ecommerce.WishlistItem
{
    public partial class ERP_Ecommerce_WishlistItem : ERPNextObjectBase
    {
        public ERP_Ecommerce_WishlistItem() : this(new ERPObject(_DocType.Ecommerce_WishlistItem)) { }
        public ERP_Ecommerce_WishlistItem(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("item_code", "varchar(140)", isNullable: true)]
        public string? ItemCode
        {
            get { return data.item_code; }
            set { data.item_code = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("website_item", "varchar(140)", isNullable: true)]
        public string? WebsiteItem
        {
            get { return data.website_item; }
            set { data.website_item = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("web_item_name", "varchar(140)", isNullable: true)]
        public string? WebItemName
        {
            get { return data.web_item_name; }
            set { data.web_item_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("item_name", "varchar(140)", isNullable: true)]
        public string? ItemName
        {
            get { return data.item_name; }
            set { data.item_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("item_group", "varchar(140)", isNullable: true)]
        public string? ItemGroup
        {
            get { return data.item_group; }
            set { data.item_group = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("description", "longtext", isNullable: true)]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [ColumnInfo("route", "text", isNullable: true)]
        public string? Route
        {
            get { return data.route; }
            set { data.route = value; }
        }

        [ColumnInfo("image", "text", isNullable: true)]
        public string? Image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        [ColumnInfo("warehouse", "varchar(140)", isNullable: true)]
        public string? Warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("parent", "varchar(140)", isNullable: true)]
        public string? Parent
        {
            get { return data.parent; }
            set { data.parent = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("parentfield", "varchar(140)", isNullable: true)]
        public string? Parentfield
        {
            get { return data.parentfield; }
            set { data.parentfield = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("parenttype", "varchar(140)", isNullable: true)]
        public string? Parenttype
        {
            get { return data.parenttype; }
            set { data.parenttype = ERPNextConverter.TruncateString(value, 140); }
        }


    }
}

