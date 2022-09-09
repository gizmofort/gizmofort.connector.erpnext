/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Setup.Employee
{
    public partial class ERP_Setup_Employee : ERPNextObjectBase
    {
        public ERP_Setup_Employee() : this(new ERPObject(_DockType.Setup_Employee)) { }
        public ERP_Setup_Employee(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Setup_Employee>(propertyName);
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

        [Column("employee")]
        public string? Employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        [Column("naming_series")]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        [Column("first_name")]
        public string? FirstName
        {
            get { return data.first_name; }
            set { data.first_name = value; }
        }

        [Column("middle_name")]
        public string? MiddleName
        {
            get { return data.middle_name; }
            set { data.middle_name = value; }
        }

        [Column("last_name")]
        public string? LastName
        {
            get { return data.last_name; }
            set { data.last_name = value; }
        }

        [Column("salutation")]
        public string? Salutation
        {
            get { return data.salutation; }
            set { data.salutation = value; }
        }

        [Column("employee_name")]
        public string? EmployeeName
        {
            get { return data.employee_name; }
            set { data.employee_name = value; }
        }

        [Column("image")]
        public string? Image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("status")]
        public string? Status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        [Column("gender")]
        public string? Gender
        {
            get { return data.gender; }
            set { data.gender = value; }
        }

        [Column("date_of_birth")]
        public DateOnly? DateOfBirth
        {
            get { return data.date_of_birth; }
            set { data.date_of_birth = value; }
        }

        [Column("date_of_joining")]
        public DateOnly? DateOfJoining
        {
            get { return data.date_of_joining; }
            set { data.date_of_joining = value; }
        }

        [Column("employee_number")]
        public string? EmployeeNumber
        {
            get { return data.employee_number; }
            set { data.employee_number = value; }
        }

        [Column("person_to_be_contacted")]
        public string? PersonToBeContacted
        {
            get { return data.person_to_be_contacted; }
            set { data.person_to_be_contacted = value; }
        }

        [Column("relation")]
        public string? Relation
        {
            get { return data.relation; }
            set { data.relation = value; }
        }

        [Column("emergency_phone_number")]
        public string? EmergencyPhoneNumber
        {
            get { return data.emergency_phone_number; }
            set { data.emergency_phone_number = value; }
        }

        [Column("user_id")]
        public string? UserId
        {
            get { return data.user_id; }
            set { data.user_id = value; }
        }

        [Column("create_user_permission")]
        public int CreateUserPermission
        {
            get { return data.create_user_permission; }
            set { data.create_user_permission = value; }
        }

        [Column("scheduled_confirmation_date")]
        public DateOnly? ScheduledConfirmationDate
        {
            get { return data.scheduled_confirmation_date; }
            set { data.scheduled_confirmation_date = value; }
        }

        [Column("final_confirmation_date")]
        public DateOnly? FinalConfirmationDate
        {
            get { return data.final_confirmation_date; }
            set { data.final_confirmation_date = value; }
        }

        [Column("contract_end_date")]
        public DateOnly? ContractEndDate
        {
            get { return data.contract_end_date; }
            set { data.contract_end_date = value; }
        }

        [Column("notice_number_of_days")]
        public int NoticeNumberOfDays
        {
            get { return data.notice_number_of_days; }
            set { data.notice_number_of_days = value; }
        }

        [Column("date_of_retirement")]
        public DateOnly? DateOfRetirement
        {
            get { return data.date_of_retirement; }
            set { data.date_of_retirement = value; }
        }

        [Column("department")]
        public string? Department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        [Column("designation")]
        public string? Designation
        {
            get { return data.designation; }
            set { data.designation = value; }
        }

        [Column("reports_to")]
        public string? ReportsTo
        {
            get { return data.reports_to; }
            set { data.reports_to = value; }
        }

        [Column("branch")]
        public string? Branch
        {
            get { return data.branch; }
            set { data.branch = value; }
        }

        [Column("attendance_device_id")]
        public string? AttendanceDeviceId
        {
            get { return data.attendance_device_id; }
            set { data.attendance_device_id = value; }
        }

        [Column("holiday_list")]
        public string? HolidayList
        {
            get { return data.holiday_list; }
            set { data.holiday_list = value; }
        }

        [Column("salary_currency")]
        public string? SalaryCurrency
        {
            get { return data.salary_currency; }
            set { data.salary_currency = value; }
        }

        [Column("ctc")]
        public decimal Ctc
        {
            get { return data.ctc; }
            set { data.ctc = value; }
        }

        [Column("bank_name")]
        public string? BankName
        {
            get { return data.bank_name; }
            set { data.bank_name = value; }
        }

        [Column("bank_ac_no")]
        public string? BankAcNo
        {
            get { return data.bank_ac_no; }
            set { data.bank_ac_no = value; }
        }

        [Column("cell_number")]
        public string? CellNumber
        {
            get { return data.cell_number; }
            set { data.cell_number = value; }
        }

        [Column("prefered_email")]
        public string? PreferedEmail
        {
            get { return data.prefered_email; }
            set { data.prefered_email = value; }
        }

        [Column("personal_email")]
        public string? PersonalEmail
        {
            get { return data.personal_email; }
            set { data.personal_email = value; }
        }

        [Column("unsubscribed")]
        public int Unsubscribed
        {
            get { return data.unsubscribed; }
            set { data.unsubscribed = value; }
        }

        [Column("permanent_accommodation_type")]
        public string? PermanentAccommodationType
        {
            get { return data.permanent_accommodation_type; }
            set { data.permanent_accommodation_type = value; }
        }

        [Column("permanent_address")]
        public string? PermanentAddress
        {
            get { return data.permanent_address; }
            set { data.permanent_address = value; }
        }

        [Column("prefered_contact_email")]
        public string? PreferedContactEmail
        {
            get { return data.prefered_contact_email; }
            set { data.prefered_contact_email = value; }
        }

        [Column("company_email")]
        public string? CompanyEmail
        {
            get { return data.company_email; }
            set { data.company_email = value; }
        }

        [Column("current_accommodation_type")]
        public string? CurrentAccommodationType
        {
            get { return data.current_accommodation_type; }
            set { data.current_accommodation_type = value; }
        }

        [Column("current_address")]
        public string? CurrentAddress
        {
            get { return data.current_address; }
            set { data.current_address = value; }
        }

        [Column("bio")]
        public string? Bio
        {
            get { return data.bio; }
            set { data.bio = value; }
        }

        [Column("passport_number")]
        public string? PassportNumber
        {
            get { return data.passport_number; }
            set { data.passport_number = value; }
        }

        [Column("date_of_issue")]
        public DateOnly? DateOfIssue
        {
            get { return data.date_of_issue; }
            set { data.date_of_issue = value; }
        }

        [Column("valid_upto")]
        public DateOnly? ValidUpto
        {
            get { return data.valid_upto; }
            set { data.valid_upto = value; }
        }

        [Column("place_of_issue")]
        public string? PlaceOfIssue
        {
            get { return data.place_of_issue; }
            set { data.place_of_issue = value; }
        }

        [Column("marital_status")]
        public string? MaritalStatus
        {
            get { return data.marital_status; }
            set { data.marital_status = value; }
        }

        [Column("blood_group")]
        public string? BloodGroup
        {
            get { return data.blood_group; }
            set { data.blood_group = value; }
        }

        [Column("family_background")]
        public string? FamilyBackground
        {
            get { return data.family_background; }
            set { data.family_background = value; }
        }

        [Column("health_details")]
        public string? HealthDetails
        {
            get { return data.health_details; }
            set { data.health_details = value; }
        }

        [Column("resignation_letter_date")]
        public DateOnly? ResignationLetterDate
        {
            get { return data.resignation_letter_date; }
            set { data.resignation_letter_date = value; }
        }

        [Column("relieving_date")]
        public DateOnly? RelievingDate
        {
            get { return data.relieving_date; }
            set { data.relieving_date = value; }
        }

        [Column("reason_for_leaving")]
        public string? ReasonForLeaving
        {
            get { return data.reason_for_leaving; }
            set { data.reason_for_leaving = value; }
        }

        [Column("leave_encashed")]
        public string? LeaveEncashed
        {
            get { return data.leave_encashed; }
            set { data.leave_encashed = value; }
        }

        [Column("encashment_date")]
        public DateOnly? EncashmentDate
        {
            get { return data.encashment_date; }
            set { data.encashment_date = value; }
        }

        [Column("held_on")]
        public DateOnly? HeldOn
        {
            get { return data.held_on; }
            set { data.held_on = value; }
        }

        [Column("new_workplace")]
        public string? NewWorkplace
        {
            get { return data.new_workplace; }
            set { data.new_workplace = value; }
        }

        [Column("feedback")]
        public string? Feedback
        {
            get { return data.feedback; }
            set { data.feedback = value; }
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

        [Column("salary_mode")]
        public string? SalaryMode
        {
            get { return data.salary_mode; }
            set { data.salary_mode = value; }
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
