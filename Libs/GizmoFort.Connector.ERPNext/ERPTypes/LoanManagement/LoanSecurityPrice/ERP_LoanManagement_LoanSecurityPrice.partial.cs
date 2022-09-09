/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.LoanManagement.LoanSecurityPrice
{
    public partial class ERP_LoanManagement_LoanSecurityPrice : ERPNextObjectBase
    {
        public ERP_LoanManagement_LoanSecurityPrice() : this(new ERPObject(_DockType.LoanManagement_LoanSecurityPrice)) { }
        public ERP_LoanManagement_LoanSecurityPrice(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_LoanManagement_LoanSecurityPrice>(propertyName);
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

        [Column("loan_security")]
        public string? LoanSecurity
        {
            get { return data.loan_security; }
            set { data.loan_security = value; }
        }

        [Column("loan_security_name")]
        public string? LoanSecurityName
        {
            get { return data.loan_security_name; }
            set { data.loan_security_name = value; }
        }

        [Column("loan_security_type")]
        public string? LoanSecurityType
        {
            get { return data.loan_security_type; }
            set { data.loan_security_type = value; }
        }

        [Column("uom")]
        public string? Uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        [Column("loan_security_price")]
        public decimal LoanSecurityPrice
        {
            get { return data.loan_security_price; }
            set { data.loan_security_price = value; }
        }

        [Column("valid_from")]
        public DateTime? ValidFrom
        {
            get { return data.valid_from; }
            set { data.valid_from = value; }
        }

        [Column("valid_upto")]
        public DateTime? ValidUpto
        {
            get { return data.valid_upto; }
            set { data.valid_upto = value; }
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
