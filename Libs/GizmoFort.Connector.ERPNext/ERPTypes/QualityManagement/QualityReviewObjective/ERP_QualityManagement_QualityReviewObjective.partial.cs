/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.QualityManagement.QualityReviewObjective
{
    public partial class ERP_QualityManagement_QualityReviewObjective : ERPNextObjectBase
    {
        public ERP_QualityManagement_QualityReviewObjective() : this(new ERPObject(_DockType.QualityManagement_QualityReviewObjective)) { }
        public ERP_QualityManagement_QualityReviewObjective(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_QualityManagement_QualityReviewObjective>(propertyName);
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

        [Column("objective")]
        public string? Objective
        {
            get { return data.objective; }
            set { data.objective = value; }
        }

        [Column("target")]
        public string? Target
        {
            get { return data.target; }
            set { data.target = value; }
        }

        [Column("uom")]
        public string? Uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        [Column("status")]
        public string? Status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        [Column("review")]
        public string? Review
        {
            get { return data.review; }
            set { data.review = value; }
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
