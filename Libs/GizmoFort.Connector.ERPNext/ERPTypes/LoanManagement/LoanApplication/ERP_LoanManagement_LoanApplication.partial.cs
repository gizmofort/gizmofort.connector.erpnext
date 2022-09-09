/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.LoanManagement.LoanApplication
{
    public partial class ERP_LoanManagement_LoanApplication : ERPNextObjectBase
    {
        public ERP_LoanManagement_LoanApplication() : this(new ERPObject(_DockType.LoanManagement_LoanApplication)) { }
        public ERP_LoanManagement_LoanApplication(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_LoanManagement_LoanApplication>(propertyName);
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

        [Column("applicant_type")]
        public string? ApplicantType
        {
            get { return data.applicant_type; }
            set { data.applicant_type = value; }
        }

        [Column("applicant")]
        public string? Applicant
        {
            get { return data.applicant; }
            set { data.applicant = value; }
        }

        [Column("applicant_name")]
        public string? ApplicantName
        {
            get { return data.applicant_name; }
            set { data.applicant_name = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("posting_date")]
        public DateOnly? PostingDate
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        [Column("status")]
        public string? Status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        [Column("loan_type")]
        public string? LoanType
        {
            get { return data.loan_type; }
            set { data.loan_type = value; }
        }

        [Column("is_term_loan")]
        public int IsTermLoan
        {
            get { return data.is_term_loan; }
            set { data.is_term_loan = value; }
        }

        [Column("loan_amount")]
        public decimal LoanAmount
        {
            get { return data.loan_amount; }
            set { data.loan_amount = value; }
        }

        [Column("is_secured_loan")]
        public int IsSecuredLoan
        {
            get { return data.is_secured_loan; }
            set { data.is_secured_loan = value; }
        }

        [Column("rate_of_interest")]
        public decimal RateOfInterest
        {
            get { return data.rate_of_interest; }
            set { data.rate_of_interest = value; }
        }

        [Column("description")]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [Column("maximum_loan_amount")]
        public decimal MaximumLoanAmount
        {
            get { return data.maximum_loan_amount; }
            set { data.maximum_loan_amount = value; }
        }

        [Column("repayment_method")]
        public string? RepaymentMethod
        {
            get { return data.repayment_method; }
            set { data.repayment_method = value; }
        }

        [Column("total_payable_amount")]
        public decimal TotalPayableAmount
        {
            get { return data.total_payable_amount; }
            set { data.total_payable_amount = value; }
        }

        [Column("repayment_periods")]
        public int RepaymentPeriods
        {
            get { return data.repayment_periods; }
            set { data.repayment_periods = value; }
        }

        [Column("repayment_amount")]
        public decimal RepaymentAmount
        {
            get { return data.repayment_amount; }
            set { data.repayment_amount = value; }
        }

        [Column("total_payable_interest")]
        public decimal TotalPayableInterest
        {
            get { return data.total_payable_interest; }
            set { data.total_payable_interest = value; }
        }

        [Column("amended_from")]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
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
