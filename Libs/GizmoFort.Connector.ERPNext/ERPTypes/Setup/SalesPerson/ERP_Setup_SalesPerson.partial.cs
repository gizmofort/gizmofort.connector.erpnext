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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Setup.SalesPerson
{
    public partial class ERP_Setup_SalesPerson : ERPNextObjectBase
    {
        public ERP_Setup_SalesPerson() : this(new ERPObject(_DocType.Setup_SalesPerson)) { }
        public ERP_Setup_SalesPerson(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("sales_person_name", "varchar(140)", isNullable: true)]
        public string? SalesPersonName
        {
            get { return data.sales_person_name; }
            set { data.sales_person_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("parent_sales_person", "varchar(140)", isNullable: true)]
        public string? ParentSalesPerson
        {
            get { return data.parent_sales_person; }
            set { data.parent_sales_person = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("commission_rate", "varchar(140)", isNullable: true)]
        public string? CommissionRate
        {
            get { return data.commission_rate; }
            set { data.commission_rate = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("is_group", "int(1)", isNullable: false)]
        public bool IsGroup
        {
            get { return ERPNextConverter.IntToBool((int)data.is_group); }
            set { data.is_group = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("enabled", "int(1)", isNullable: false)]
        public bool Enabled
        {
            get { return ERPNextConverter.IntToBool((int)data.enabled); }
            set { data.enabled = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("employee", "varchar(140)", isNullable: true)]
        public string? Employee
        {
            get { return data.employee; }
            set { data.employee = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("department", "varchar(140)", isNullable: true)]
        public string? Department
        {
            get { return data.department; }
            set { data.department = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("lft", "int(11)", isNullable: false)]
        public int Lft
        {
            get { return data.lft; }
            set { data.lft = value; }
        }

        [ColumnInfo("rgt", "int(11)", isNullable: false)]
        public int Rgt
        {
            get { return data.rgt; }
            set { data.rgt = value; }
        }

        [ColumnInfo("old_parent", "varchar(140)", isNullable: true)]
        public string? OldParent
        {
            get { return data.old_parent; }
            set { data.old_parent = ERPNextConverter.TruncateString(value, 140); }
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

