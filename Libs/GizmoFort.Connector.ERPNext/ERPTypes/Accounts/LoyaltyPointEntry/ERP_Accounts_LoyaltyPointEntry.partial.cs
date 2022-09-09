/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.LoyaltyPointEntry
{
    public partial class ERP_Accounts_LoyaltyPointEntry : ERPNextObjectBase
    {
        public ERP_Accounts_LoyaltyPointEntry() : this(new ERPObject(_DockType.Accounts_LoyaltyPointEntry)) { }
        public ERP_Accounts_LoyaltyPointEntry(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Accounts_LoyaltyPointEntry>(propertyName);
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

        [Column("loyalty_program")]
        public string? LoyaltyProgram
        {
            get { return data.loyalty_program; }
            set { data.loyalty_program = value; }
        }

        [Column("loyalty_program_tier")]
        public string? LoyaltyProgramTier
        {
            get { return data.loyalty_program_tier; }
            set { data.loyalty_program_tier = value; }
        }

        [Column("customer")]
        public string? Customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        [Column("invoice_type")]
        public string? InvoiceType
        {
            get { return data.invoice_type; }
            set { data.invoice_type = value; }
        }

        [Column("invoice")]
        public string? Invoice
        {
            get { return data.invoice; }
            set { data.invoice = value; }
        }

        [Column("redeem_against")]
        public string? RedeemAgainst
        {
            get { return data.redeem_against; }
            set { data.redeem_against = value; }
        }

        [Column("loyalty_points")]
        public int LoyaltyPoints
        {
            get { return data.loyalty_points; }
            set { data.loyalty_points = value; }
        }

        [Column("purchase_amount")]
        public decimal PurchaseAmount
        {
            get { return data.purchase_amount; }
            set { data.purchase_amount = value; }
        }

        [Column("expiry_date")]
        public DateOnly? ExpiryDate
        {
            get { return data.expiry_date; }
            set { data.expiry_date = value; }
        }

        [Column("posting_date")]
        public DateOnly? PostingDate
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
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

