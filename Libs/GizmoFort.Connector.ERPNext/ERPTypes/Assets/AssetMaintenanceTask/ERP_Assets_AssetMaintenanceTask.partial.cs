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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Assets.AssetMaintenanceTask
{
    public partial class ERP_Assets_AssetMaintenanceTask : ERPNextObjectBase
    {
        public ERP_Assets_AssetMaintenanceTask() : this(new ERPObject(_DocType.Assets_AssetMaintenanceTask)) { }
        public ERP_Assets_AssetMaintenanceTask(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("maintenance_task", "varchar(140)", isNullable: true)]
        public string? MaintenanceTask
        {
            get { return data.maintenance_task; }
            set { data.maintenance_task = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("maintenance_type", "varchar(140)", isNullable: true)]
        public string? MaintenanceType
        {
            get { return data.maintenance_type; }
            set { data.maintenance_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("maintenance_status", "varchar(140)", isNullable: true)]
        public string? MaintenanceStatus
        {
            get { return data.maintenance_status; }
            set { data.maintenance_status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("start_date", "date", isNullable: true)]
        public DateOnly? StartDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.start_date); }
            set { data.start_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("periodicity", "varchar(140)", isNullable: true)]
        public string? Periodicity
        {
            get { return data.periodicity; }
            set { data.periodicity = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("end_date", "date", isNullable: true)]
        public DateOnly? EndDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.end_date); }
            set { data.end_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("certificate_required", "int(1)", isNullable: false)]
        public bool CertificateRequired
        {
            get { return ERPNextConverter.IntToBool((int)data.certificate_required); }
            set { data.certificate_required = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("assign_to", "varchar(140)", isNullable: true)]
        public string? AssignTo
        {
            get { return data.assign_to; }
            set { data.assign_to = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("assign_to_name", "varchar(140)", isNullable: true)]
        public string? AssignToName
        {
            get { return data.assign_to_name; }
            set { data.assign_to_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("next_due_date", "date", isNullable: true)]
        public DateOnly? NextDueDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.next_due_date); }
            set { data.next_due_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("last_completion_date", "date", isNullable: true)]
        public DateOnly? LastCompletionDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.last_completion_date); }
            set { data.last_completion_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("description", "longtext", isNullable: true)]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
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

