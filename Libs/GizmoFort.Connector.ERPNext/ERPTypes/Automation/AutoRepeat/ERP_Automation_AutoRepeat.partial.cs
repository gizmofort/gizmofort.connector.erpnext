/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Automation.AutoRepeat
{
    public partial class ERP_Automation_AutoRepeat : ERPNextObjectBase
    {
        public ERP_Automation_AutoRepeat() : this(new ERPObject(_DockType.Automation_AutoRepeat)) { }
        public ERP_Automation_AutoRepeat(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Automation_AutoRepeat>(propertyName);
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

        [Column("disabled")]
        public int Disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }

        [Column("reference_doctype")]
        public string? ReferenceDoctype
        {
            get { return data.reference_doctype; }
            set { data.reference_doctype = value; }
        }

        [Column("reference_document")]
        public string? ReferenceDocument
        {
            get { return data.reference_document; }
            set { data.reference_document = value; }
        }

        [Column("submit_on_creation")]
        public int SubmitOnCreation
        {
            get { return data.submit_on_creation; }
            set { data.submit_on_creation = value; }
        }

        [Column("start_date")]
        public DateOnly? StartDate
        {
            get { return data.start_date; }
            set { data.start_date = value; }
        }

        [Column("end_date")]
        public DateOnly? EndDate
        {
            get { return data.end_date; }
            set { data.end_date = value; }
        }

        [Column("frequency")]
        public string? Frequency
        {
            get { return data.frequency; }
            set { data.frequency = value; }
        }

        [Column("repeat_on_day")]
        public int RepeatOnDay
        {
            get { return data.repeat_on_day; }
            set { data.repeat_on_day = value; }
        }

        [Column("repeat_on_last_day")]
        public int RepeatOnLastDay
        {
            get { return data.repeat_on_last_day; }
            set { data.repeat_on_last_day = value; }
        }

        [Column("next_schedule_date")]
        public DateOnly? NextScheduleDate
        {
            get { return data.next_schedule_date; }
            set { data.next_schedule_date = value; }
        }

        [Column("notify_by_email")]
        public int NotifyByEmail
        {
            get { return data.notify_by_email; }
            set { data.notify_by_email = value; }
        }

        [Column("recipients")]
        public string? Recipients
        {
            get { return data.recipients; }
            set { data.recipients = value; }
        }

        [Column("template")]
        public string? Template
        {
            get { return data.template; }
            set { data.template = value; }
        }

        [Column("subject")]
        public string? Subject
        {
            get { return data.subject; }
            set { data.subject = value; }
        }

        [Column("message")]
        public string? Message
        {
            get { return data.message; }
            set { data.message = value; }
        }

        [Column("print_format")]
        public string? PrintFormat
        {
            get { return data.print_format; }
            set { data.print_format = value; }
        }

        [Column("status")]
        public string? Status
        {
            get { return data.status; }
            set { data.status = value; }
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
