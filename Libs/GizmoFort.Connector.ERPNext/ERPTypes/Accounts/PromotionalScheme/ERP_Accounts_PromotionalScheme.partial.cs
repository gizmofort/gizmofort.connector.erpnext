/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.PromotionalScheme
{
    public partial class ERP_Accounts_PromotionalScheme : ERPNextObjectBase
    {
        public ERP_Accounts_PromotionalScheme() : this(new ERPObject(_DockType.Accounts_PromotionalScheme)) { }
        public ERP_Accounts_PromotionalScheme(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Accounts_PromotionalScheme>(propertyName);
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

        [Column("apply_on")]
        public string? ApplyOn
        {
            get { return data.apply_on; }
            set { data.apply_on = value; }
        }

        [Column("disable")]
        public int Disable
        {
            get { return data.disable; }
            set { data.disable = value; }
        }

        [Column("mixed_conditions")]
        public int MixedConditions
        {
            get { return data.mixed_conditions; }
            set { data.mixed_conditions = value; }
        }

        [Column("is_cumulative")]
        public int IsCumulative
        {
            get { return data.is_cumulative; }
            set { data.is_cumulative = value; }
        }

        [Column("apply_rule_on_other")]
        public string? ApplyRuleOnOther
        {
            get { return data.apply_rule_on_other; }
            set { data.apply_rule_on_other = value; }
        }

        [Column("other_item_code")]
        public string? OtherItemCode
        {
            get { return data.other_item_code; }
            set { data.other_item_code = value; }
        }

        [Column("other_item_group")]
        public string? OtherItemGroup
        {
            get { return data.other_item_group; }
            set { data.other_item_group = value; }
        }

        [Column("other_brand")]
        public string? OtherBrand
        {
            get { return data.other_brand; }
            set { data.other_brand = value; }
        }

        [Column("selling")]
        public int Selling
        {
            get { return data.selling; }
            set { data.selling = value; }
        }

        [Column("buying")]
        public int Buying
        {
            get { return data.buying; }
            set { data.buying = value; }
        }

        [Column("applicable_for")]
        public string? ApplicableFor
        {
            get { return data.applicable_for; }
            set { data.applicable_for = value; }
        }

        [Column("valid_from")]
        public DateOnly? ValidFrom
        {
            get { return data.valid_from; }
            set { data.valid_from = value; }
        }

        [Column("valid_upto")]
        public DateOnly? ValidUpto
        {
            get { return data.valid_upto; }
            set { data.valid_upto = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("currency")]
        public string? Currency
        {
            get { return data.currency; }
            set { data.currency = value; }
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
