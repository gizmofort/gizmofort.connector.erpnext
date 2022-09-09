/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.PreparedReport
{
    public partial class ERP_Core_PreparedReport : ERPNextObjectBase
    {
        public ERP_Core_PreparedReport() : this(new ERPObject(_DockType.Core_PreparedReport)) { }
        public ERP_Core_PreparedReport(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Core_PreparedReport>(propertyName);
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

        [Column("report_name")]
        public string? ReportName
        {
            get { return data.report_name; }
            set { data.report_name = value; }
        }

        [Column("ref_report_doctype")]
        public string? RefReportDoctype
        {
            get { return data.ref_report_doctype; }
            set { data.ref_report_doctype = value; }
        }

        [Column("status")]
        public string? Status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        [Column("report_start_time")]
        public DateTime? ReportStartTime
        {
            get { return data.report_start_time; }
            set { data.report_start_time = value; }
        }

        [Column("report_end_time")]
        public DateTime? ReportEndTime
        {
            get { return data.report_end_time; }
            set { data.report_end_time = value; }
        }

        [Column("error_message")]
        public string? ErrorMessage
        {
            get { return data.error_message; }
            set { data.error_message = value; }
        }

        [Column("filters")]
        public string? Filters
        {
            get { return data.filters; }
            set { data.filters = value; }
        }

        [Column("columns")]
        public string? Columns
        {
            get { return data.columns; }
            set { data.columns = value; }
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
