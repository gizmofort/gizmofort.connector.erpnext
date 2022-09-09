/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Setup.CustomerGroup
{
    public partial class ERP_Setup_CustomerGroup : ERPNextObjectBase
    {
        public ERP_Setup_CustomerGroup() : this(new ERPObject(_DockType.Setup_CustomerGroup)) { }
        public ERP_Setup_CustomerGroup(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Setup_CustomerGroup>(propertyName);
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

        [Column("customer_group_name")]
        public string? CustomerGroupName
        {
            get { return data.customer_group_name; }
            set { data.customer_group_name = value; }
        }

        [Column("parent_customer_group")]
        public string? ParentCustomerGroup
        {
            get { return data.parent_customer_group; }
            set { data.parent_customer_group = value; }
        }

        [Column("is_group")]
        public int IsGroup
        {
            get { return data.is_group; }
            set { data.is_group = value; }
        }

        [Column("default_price_list")]
        public string? DefaultPriceList
        {
            get { return data.default_price_list; }
            set { data.default_price_list = value; }
        }

        [Column("payment_terms")]
        public string? PaymentTerms
        {
            get { return data.payment_terms; }
            set { data.payment_terms = value; }
        }

        [Column("lft")]
        public int Lft
        {
            get { return data.lft; }
            set { data.lft = value; }
        }

        [Column("rgt")]
        public int Rgt
        {
            get { return data.rgt; }
            set { data.rgt = value; }
        }

        [Column("old_parent")]
        public string? OldParent
        {
            get { return data.old_parent; }
            set { data.old_parent = value; }
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

