/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.BankAccount
{
    public partial class ERP_Accounts_BankAccount : ERPNextObjectBase
    {
        public ERP_Accounts_BankAccount() : this(new ERPObject(_DockType.Accounts_BankAccount)) { }
        public ERP_Accounts_BankAccount(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Accounts_BankAccount>(propertyName);
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

        [Column("account_name")]
        public string? AccountName
        {
            get { return data.account_name; }
            set { data.account_name = value; }
        }

        [Column("account")]
        public string? Account
        {
            get { return data.account; }
            set { data.account = value; }
        }

        [Column("bank")]
        public string? Bank
        {
            get { return data.bank; }
            set { data.bank = value; }
        }

        [Column("account_type")]
        public string? AccountType
        {
            get { return data.account_type; }
            set { data.account_type = value; }
        }

        [Column("account_subtype")]
        public string? AccountSubtype
        {
            get { return data.account_subtype; }
            set { data.account_subtype = value; }
        }

        [Column("is_default")]
        public int IsDefault
        {
            get { return data.is_default; }
            set { data.is_default = value; }
        }

        [Column("is_company_account")]
        public int IsCompanyAccount
        {
            get { return data.is_company_account; }
            set { data.is_company_account = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("party_type")]
        public string? PartyType
        {
            get { return data.party_type; }
            set { data.party_type = value; }
        }

        [Column("party")]
        public string? Party
        {
            get { return data.party; }
            set { data.party = value; }
        }

        [Column("iban")]
        public string? Iban
        {
            get { return data.iban; }
            set { data.iban = value; }
        }

        [Column("branch_code")]
        public string? BranchCode
        {
            get { return data.branch_code; }
            set { data.branch_code = value; }
        }

        [Column("bank_account_no")]
        public string? BankAccountNo
        {
            get { return data.bank_account_no; }
            set { data.bank_account_no = value; }
        }

        [Column("integration_id")]
        public string? IntegrationId
        {
            get { return data.integration_id; }
            set { data.integration_id = value; }
        }

        [Column("last_integration_date")]
        public DateOnly? LastIntegrationDate
        {
            get { return data.last_integration_date; }
            set { data.last_integration_date = value; }
        }

        [Column("mask")]
        public string? Mask
        {
            get { return data.mask; }
            set { data.mask = value; }
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
