/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.ShareBalance
{
    public partial class ERP_Accounts_ShareBalance : ERPNextObjectBase
    {
        public ERP_Accounts_ShareBalance() : this(new ERPObject(_DockType.Accounts_ShareBalance)) { }
        public ERP_Accounts_ShareBalance(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Accounts_ShareBalance>(propertyName);
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

        [Column("share_type")]
        public string? ShareType
        {
            get { return data.share_type; }
            set { data.share_type = value; }
        }

        [Column("from_no")]
        public int FromNo
        {
            get { return data.from_no; }
            set { data.from_no = value; }
        }

        [Column("rate")]
        public int Rate
        {
            get { return data.rate; }
            set { data.rate = value; }
        }

        [Column("no_of_shares")]
        public int NoOfShares
        {
            get { return data.no_of_shares; }
            set { data.no_of_shares = value; }
        }

        [Column("to_no")]
        public int ToNo
        {
            get { return data.to_no; }
            set { data.to_no = value; }
        }

        [Column("amount")]
        public int Amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        [Column("is_company")]
        public int IsCompany
        {
            get { return data.is_company; }
            set { data.is_company = value; }
        }

        [Column("current_state")]
        public string? CurrentState
        {
            get { return data.current_state; }
            set { data.current_state = value; }
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
