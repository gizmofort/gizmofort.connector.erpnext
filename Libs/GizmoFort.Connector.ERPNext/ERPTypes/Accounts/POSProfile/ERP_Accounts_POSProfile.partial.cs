/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.POSProfile
{
    public partial class ERP_Accounts_POSProfile : ERPNextObjectBase
    {
        public ERP_Accounts_POSProfile() : this(new ERPObject(_DockType.Accounts_POSProfile)) { }
        public ERP_Accounts_POSProfile(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Accounts_POSProfile>(propertyName);
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

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("customer")]
        public string? Customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        [Column("country")]
        public string? Country
        {
            get { return data.country; }
            set { data.country = value; }
        }

        [Column("disabled")]
        public int Disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }

        [Column("warehouse")]
        public string? Warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        [Column("campaign")]
        public string? Campaign
        {
            get { return data.campaign; }
            set { data.campaign = value; }
        }

        [Column("company_address")]
        public string? CompanyAddress
        {
            get { return data.company_address; }
            set { data.company_address = value; }
        }

        [Column("hide_images")]
        public int HideImages
        {
            get { return data.hide_images; }
            set { data.hide_images = value; }
        }

        [Column("hide_unavailable_items")]
        public int HideUnavailableItems
        {
            get { return data.hide_unavailable_items; }
            set { data.hide_unavailable_items = value; }
        }

        [Column("auto_add_item_to_cart")]
        public int AutoAddItemToCart
        {
            get { return data.auto_add_item_to_cart; }
            set { data.auto_add_item_to_cart = value; }
        }

        [Column("validate_stock_on_save")]
        public int ValidateStockOnSave
        {
            get { return data.validate_stock_on_save; }
            set { data.validate_stock_on_save = value; }
        }

        [Column("update_stock")]
        public int UpdateStock
        {
            get { return data.update_stock; }
            set { data.update_stock = value; }
        }

        [Column("ignore_pricing_rule")]
        public int IgnorePricingRule
        {
            get { return data.ignore_pricing_rule; }
            set { data.ignore_pricing_rule = value; }
        }

        [Column("allow_rate_change")]
        public int AllowRateChange
        {
            get { return data.allow_rate_change; }
            set { data.allow_rate_change = value; }
        }

        [Column("allow_discount_change")]
        public int AllowDiscountChange
        {
            get { return data.allow_discount_change; }
            set { data.allow_discount_change = value; }
        }

        [Column("print_format")]
        public string? PrintFormat
        {
            get { return data.print_format; }
            set { data.print_format = value; }
        }

        [Column("letter_head")]
        public string? LetterHead
        {
            get { return data.letter_head; }
            set { data.letter_head = value; }
        }

        [Column("tc_name")]
        public string? TcName
        {
            get { return data.tc_name; }
            set { data.tc_name = value; }
        }

        [Column("select_print_heading")]
        public string? SelectPrintHeading
        {
            get { return data.select_print_heading; }
            set { data.select_print_heading = value; }
        }

        [Column("selling_price_list")]
        public string? SellingPriceList
        {
            get { return data.selling_price_list; }
            set { data.selling_price_list = value; }
        }

        [Column("currency")]
        public string? Currency
        {
            get { return data.currency; }
            set { data.currency = value; }
        }

        [Column("write_off_account")]
        public string? WriteOffAccount
        {
            get { return data.write_off_account; }
            set { data.write_off_account = value; }
        }

        [Column("write_off_cost_center")]
        public string? WriteOffCostCenter
        {
            get { return data.write_off_cost_center; }
            set { data.write_off_cost_center = value; }
        }

        [Column("account_for_change_amount")]
        public string? AccountForChangeAmount
        {
            get { return data.account_for_change_amount; }
            set { data.account_for_change_amount = value; }
        }

        [Column("disable_rounded_total")]
        public int DisableRoundedTotal
        {
            get { return data.disable_rounded_total; }
            set { data.disable_rounded_total = value; }
        }

        [Column("income_account")]
        public string? IncomeAccount
        {
            get { return data.income_account; }
            set { data.income_account = value; }
        }

        [Column("expense_account")]
        public string? ExpenseAccount
        {
            get { return data.expense_account; }
            set { data.expense_account = value; }
        }

        [Column("taxes_and_charges")]
        public string? TaxesAndCharges
        {
            get { return data.taxes_and_charges; }
            set { data.taxes_and_charges = value; }
        }

        [Column("tax_category")]
        public string? TaxCategory
        {
            get { return data.tax_category; }
            set { data.tax_category = value; }
        }

        [Column("apply_discount_on")]
        public string? ApplyDiscountOn
        {
            get { return data.apply_discount_on; }
            set { data.apply_discount_on = value; }
        }

        [Column("cost_center")]
        public string? CostCenter
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
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
