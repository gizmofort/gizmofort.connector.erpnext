/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.PurchaseTaxesandCharges
{
    public partial class ERP_Accounts_PurchaseTaxesandCharges : ERPNextObjectBase
    {
        public ERP_Accounts_PurchaseTaxesandCharges() : this(new ERPObject(_DockType.Accounts_PurchaseTaxesandCharges)) { }
        public ERP_Accounts_PurchaseTaxesandCharges(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Accounts_PurchaseTaxesandCharges>(propertyName);
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

        [Column("category")]
        public string? Category
        {
            get { return data.category; }
            set { data.category = value; }
        }

        [Column("add_deduct_tax")]
        public string? AddDeductTax
        {
            get { return data.add_deduct_tax; }
            set { data.add_deduct_tax = value; }
        }

        [Column("charge_type")]
        public string? ChargeType
        {
            get { return data.charge_type; }
            set { data.charge_type = value; }
        }

        [Column("row_id")]
        public string? RowId
        {
            get { return data.row_id; }
            set { data.row_id = value; }
        }

        [Column("included_in_print_rate")]
        public int IncludedInPrintRate
        {
            get { return data.included_in_print_rate; }
            set { data.included_in_print_rate = value; }
        }

        [Column("included_in_paid_amount")]
        public int IncludedInPaidAmount
        {
            get { return data.included_in_paid_amount; }
            set { data.included_in_paid_amount = value; }
        }

        [Column("account_head")]
        public string? AccountHead
        {
            get { return data.account_head; }
            set { data.account_head = value; }
        }

        [Column("description")]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [Column("rate")]
        public decimal Rate
        {
            get { return data.rate; }
            set { data.rate = value; }
        }

        [Column("cost_center")]
        public string? CostCenter
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        [Column("account_currency")]
        public string? AccountCurrency
        {
            get { return data.account_currency; }
            set { data.account_currency = value; }
        }

        [Column("tax_amount")]
        public decimal TaxAmount
        {
            get { return data.tax_amount; }
            set { data.tax_amount = value; }
        }

        [Column("tax_amount_after_discount_amount")]
        public decimal TaxAmountAfterDiscountAmount
        {
            get { return data.tax_amount_after_discount_amount; }
            set { data.tax_amount_after_discount_amount = value; }
        }

        [Column("total")]
        public decimal Total
        {
            get { return data.total; }
            set { data.total = value; }
        }

        [Column("base_tax_amount")]
        public decimal BaseTaxAmount
        {
            get { return data.base_tax_amount; }
            set { data.base_tax_amount = value; }
        }

        [Column("base_total")]
        public decimal BaseTotal
        {
            get { return data.base_total; }
            set { data.base_total = value; }
        }

        [Column("base_tax_amount_after_discount_amount")]
        public decimal BaseTaxAmountAfterDiscountAmount
        {
            get { return data.base_tax_amount_after_discount_amount; }
            set { data.base_tax_amount_after_discount_amount = value; }
        }

        [Column("item_wise_tax_detail")]
        public string? ItemWiseTaxDetail
        {
            get { return data.item_wise_tax_detail; }
            set { data.item_wise_tax_detail = value; }
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
