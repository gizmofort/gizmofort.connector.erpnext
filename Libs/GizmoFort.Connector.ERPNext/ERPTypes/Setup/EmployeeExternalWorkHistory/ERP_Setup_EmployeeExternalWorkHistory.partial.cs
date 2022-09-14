/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/14/2022 8:42:56 AM
********************************************************************/

using System;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using GizmoFort.Connector.ERPNext.DataAnnotations;
using GizmoFort.Connector.ERPNext.Serialization;
using _DocType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Setup.EmployeeExternalWorkHistory
{
    public partial class ERP_Setup_EmployeeExternalWorkHistory : ERPNextObjectBase
    {
        public ERP_Setup_EmployeeExternalWorkHistory() : this(new ERPObject(_DocType.Setup_EmployeeExternalWorkHistory)) { }
        public ERP_Setup_EmployeeExternalWorkHistory(ERPObject obj) : base(obj) { }

        [ColumnInfo("name", "varchar(140)", isNullable: false)]
        public string Name
        {
            get { return data.name; }
            set { data.name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("creation", "datetime(6)", isNullable: true)]
        public DateTimeOffset? Creation
        {
            get { return ERPNextConverter.StringToDateTimeOffset(data.creation); }
            set { data.creation = ERPNextConverter.DateTimeOffsetToString(value, 6); }
        }

        [ColumnInfo("modified", "datetime(6)", isNullable: true)]
        public DateTimeOffset? Modified
        {
            get { return ERPNextConverter.StringToDateTimeOffset(data.modified); }
            set { data.modified = ERPNextConverter.DateTimeOffsetToString(value, 6); }
        }

        [ColumnInfo("modified_by", "varchar(140)", isNullable: true)]
        public string? ModifiedBy
        {
            get { return data.modified_by; }
            set { data.modified_by = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("owner", "varchar(140)", isNullable: true)]
        public string? Owner
        {
            get { return data.owner; }
            set { data.owner = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("docstatus", "int(1)", isNullable: false)]
        public Docstatus Docstatus
        {
            get { return (Docstatus)data.docstatus; }
            set { data.docstatus = (int)value; }
        }

        [ColumnInfo("idx", "int(8)", isNullable: false)]
        public int Idx
        {
            get { return data.idx; }
            set { data.idx = value; }
        }

        [ColumnInfo("company_name", "varchar(140)", isNullable: true)]
        public string? CompanyName
        {
            get { return data.company_name; }
            set { data.company_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("designation", "varchar(140)", isNullable: true)]
        public string? Designation
        {
            get { return data.designation; }
            set { data.designation = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("salary", "decimal(21,9)", isNullable: false)]
        public decimal Salary
        {
            get { return data.salary; }
            set { data.salary = value; }
        }

        [ColumnInfo("address", "text", isNullable: true)]
        public string? Address
        {
            get { return data.address; }
            set { data.address = value; }
        }

        [ColumnInfo("contact", "varchar(140)", isNullable: true)]
        public string? Contact
        {
            get { return data.contact; }
            set { data.contact = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("total_experience", "varchar(140)", isNullable: true)]
        public string? TotalExperience
        {
            get { return data.total_experience; }
            set { data.total_experience = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("parent", "varchar(140)", isNullable: true)]
        public string? Parent
        {
            get { return data.parent; }
            set { data.parent = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("parentfield", "varchar(140)", isNullable: true)]
        public string? Parentfield
        {
            get { return data.parentfield; }
            set { data.parentfield = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("parenttype", "varchar(140)", isNullable: true)]
        public string? Parenttype
        {
            get { return data.parenttype; }
            set { data.parenttype = ERPNextConverter.TruncateString(value, 140); }
        }


    }
}

