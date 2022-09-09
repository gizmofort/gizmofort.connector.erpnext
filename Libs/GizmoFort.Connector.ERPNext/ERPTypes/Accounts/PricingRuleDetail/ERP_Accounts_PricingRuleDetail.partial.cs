/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.PricingRuleDetail
{
    public partial class ERP_Accounts_PricingRuleDetail : ERPNextObjectBase
    {
        public ERP_Accounts_PricingRuleDetail() : this(new ERPObject(_DockType.Accounts_PricingRuleDetail)) { }
        public ERP_Accounts_PricingRuleDetail(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Accounts_PricingRuleDetail>(propertyName);
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

        [Column("pricing_rule")]
        public string? PricingRule
        {
            get { return data.pricing_rule; }
            set { data.pricing_rule = value; }
        }

        [Column("item_code")]
        public string? ItemCode
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        [Column("margin_type")]
        public string? MarginType
        {
            get { return data.margin_type; }
            set { data.margin_type = value; }
        }

        [Column("rate_or_discount")]
        public string? RateOrDiscount
        {
            get { return data.rate_or_discount; }
            set { data.rate_or_discount = value; }
        }

        [Column("child_docname")]
        public string? ChildDocname
        {
            get { return data.child_docname; }
            set { data.child_docname = value; }
        }

        [Column("rule_applied")]
        public int RuleApplied
        {
            get { return data.rule_applied; }
            set { data.rule_applied = value; }
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
