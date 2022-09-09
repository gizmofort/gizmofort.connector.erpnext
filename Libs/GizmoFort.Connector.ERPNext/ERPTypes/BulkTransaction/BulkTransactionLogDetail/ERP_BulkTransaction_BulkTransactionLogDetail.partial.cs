/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.BulkTransaction.BulkTransactionLogDetail
{
    public partial class ERP_BulkTransaction_BulkTransactionLogDetail : ERPNextObjectBase
    {
        public ERP_BulkTransaction_BulkTransactionLogDetail() : this(new ERPObject(_DockType.BulkTransaction_BulkTransactionLogDetail)) { }
        public ERP_BulkTransaction_BulkTransactionLogDetail(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_BulkTransaction_BulkTransactionLogDetail>(propertyName);
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

        [Column("transaction_name")]
        public string? TransactionName
        {
            get { return data.transaction_name; }
            set { data.transaction_name = value; }
        }

        [Column("date")]
        public DateOnly? Date
        {
            get { return data.date; }
            set { data.date = value; }
        }

        [Column("time")]
        public TimeSpan? Time
        {
            get { return data.time; }
            set { data.time = value; }
        }

        [Column("transaction_status")]
        public string? TransactionStatus
        {
            get { return data.transaction_status; }
            set { data.transaction_status = value; }
        }

        [Column("error_description")]
        public string? ErrorDescription
        {
            get { return data.error_description; }
            set { data.error_description = value; }
        }

        [Column("from_doctype")]
        public string? FromDoctype
        {
            get { return data.from_doctype; }
            set { data.from_doctype = value; }
        }

        [Column("to_doctype")]
        public string? ToDoctype
        {
            get { return data.to_doctype; }
            set { data.to_doctype = value; }
        }

        [Column("retried")]
        public int Retried
        {
            get { return data.retried; }
            set { data.retried = value; }
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
