/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.QualityInspection
{
    public partial class ERP_Stock_QualityInspection : ERPNextObjectBase
    {
        public ERP_Stock_QualityInspection() : this(new ERPObject(_DockType.Stock_QualityInspection)) { }
        public ERP_Stock_QualityInspection(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Stock_QualityInspection>(propertyName);
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

        [Column("naming_series")]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        [Column("report_date")]
        public DateOnly? ReportDate
        {
            get { return data.report_date; }
            set { data.report_date = value; }
        }

        [Column("status")]
        public string? Status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        [Column("inspection_type")]
        public string? InspectionType
        {
            get { return data.inspection_type; }
            set { data.inspection_type = value; }
        }

        [Column("reference_type")]
        public string? ReferenceType
        {
            get { return data.reference_type; }
            set { data.reference_type = value; }
        }

        [Column("reference_name")]
        public string? ReferenceName
        {
            get { return data.reference_name; }
            set { data.reference_name = value; }
        }

        [Column("item_code")]
        public string? ItemCode
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        [Column("item_serial_no")]
        public string? ItemSerialNo
        {
            get { return data.item_serial_no; }
            set { data.item_serial_no = value; }
        }

        [Column("batch_no")]
        public string? BatchNo
        {
            get { return data.batch_no; }
            set { data.batch_no = value; }
        }

        [Column("sample_size")]
        public decimal SampleSize
        {
            get { return data.sample_size; }
            set { data.sample_size = value; }
        }

        [Column("item_name")]
        public string? ItemName
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        [Column("description")]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [Column("bom_no")]
        public string? BomNo
        {
            get { return data.bom_no; }
            set { data.bom_no = value; }
        }

        [Column("quality_inspection_template")]
        public string? QualityInspectionTemplate
        {
            get { return data.quality_inspection_template; }
            set { data.quality_inspection_template = value; }
        }

        [Column("inspected_by")]
        public string? InspectedBy
        {
            get { return data.inspected_by; }
            set { data.inspected_by = value; }
        }

        [Column("verified_by")]
        public string? VerifiedBy
        {
            get { return data.verified_by; }
            set { data.verified_by = value; }
        }

        [Column("remarks")]
        public string? Remarks
        {
            get { return data.remarks; }
            set { data.remarks = value; }
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
