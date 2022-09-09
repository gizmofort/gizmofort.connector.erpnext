/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Desk.NotificationLog
{
    public partial class ERP_Desk_NotificationLog : ERPNextObjectBase
    {
        public ERP_Desk_NotificationLog() : this(new ERPObject(_DockType.Desk_NotificationLog)) { }
        public ERP_Desk_NotificationLog(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Desk_NotificationLog>(propertyName);
        }

        [Column("name")]
        public long Name
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

        [Column("subject")]
        public string? Subject
        {
            get { return data.subject; }
            set { data.subject = value; }
        }

        [Column("for_user")]
        public string? ForUser
        {
            get { return data.for_user; }
            set { data.for_user = value; }
        }

        [Column("type")]
        public string? Type
        {
            get { return data.type; }
            set { data.type = value; }
        }

        [Column("email_content")]
        public string? EmailContent
        {
            get { return data.email_content; }
            set { data.email_content = value; }
        }

        [Column("document_type")]
        public string? DocumentType
        {
            get { return data.document_type; }
            set { data.document_type = value; }
        }

        [Column("read")]
        public int Read
        {
            get { return data.read; }
            set { data.read = value; }
        }

        [Column("document_name")]
        public string? DocumentName
        {
            get { return data.document_name; }
            set { data.document_name = value; }
        }

        [Column("attached_file")]
        public string? AttachedFile
        {
            get { return data.attached_file; }
            set { data.attached_file = value; }
        }

        [Column("from_user")]
        public string? FromUser
        {
            get { return data.from_user; }
            set { data.from_user = value; }
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

        [Column("_seen")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Seen
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._seen; }
            set { data._seen = value; }
        }


    }
}
