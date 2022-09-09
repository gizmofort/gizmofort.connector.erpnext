/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Buying.SupplierScorecardScoringStanding
{
    public partial class ERP_Buying_SupplierScorecardScoringStanding : ERPNextObjectBase
    {
        public ERP_Buying_SupplierScorecardScoringStanding() : this(new ERPObject(_DockType.Buying_SupplierScorecardScoringStanding)) { }
        public ERP_Buying_SupplierScorecardScoringStanding(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Buying_SupplierScorecardScoringStanding>(propertyName);
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

        [Column("standing_name")]
        public string? StandingName
        {
            get { return data.standing_name; }
            set { data.standing_name = value; }
        }

        [Column("standing_color")]
        public string? StandingColor
        {
            get { return data.standing_color; }
            set { data.standing_color = value; }
        }

        [Column("min_grade")]
        public decimal MinGrade
        {
            get { return data.min_grade; }
            set { data.min_grade = value; }
        }

        [Column("max_grade")]
        public decimal MaxGrade
        {
            get { return data.max_grade; }
            set { data.max_grade = value; }
        }

        [Column("warn_rfqs")]
        public int WarnRfqs
        {
            get { return data.warn_rfqs; }
            set { data.warn_rfqs = value; }
        }

        [Column("warn_pos")]
        public int WarnPos
        {
            get { return data.warn_pos; }
            set { data.warn_pos = value; }
        }

        [Column("prevent_rfqs")]
        public int PreventRfqs
        {
            get { return data.prevent_rfqs; }
            set { data.prevent_rfqs = value; }
        }

        [Column("prevent_pos")]
        public int PreventPos
        {
            get { return data.prevent_pos; }
            set { data.prevent_pos = value; }
        }

        [Column("notify_supplier")]
        public int NotifySupplier
        {
            get { return data.notify_supplier; }
            set { data.notify_supplier = value; }
        }

        [Column("notify_employee")]
        public int NotifyEmployee
        {
            get { return data.notify_employee; }
            set { data.notify_employee = value; }
        }

        [Column("employee_link")]
        public string? EmployeeLink
        {
            get { return data.employee_link; }
            set { data.employee_link = value; }
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

