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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Desk.Note
{
    public partial class ERP_Desk_Note : ERPNextObjectBase
    {
        public ERP_Desk_Note() : this(new ERPObject(_DocType.Desk_Note)) { }
        public ERP_Desk_Note(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("title", "varchar(140)", isNullable: true)]
        public string? Title
        {
            get { return data.title; }
            set { data.title = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("@public", "int(1)", isNullable: false)]
        public bool Public
        {
            get { return ERPNextConverter.IntToBool((int)data.@public); }
            set { data.@public = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("notify_on_login", "int(1)", isNullable: false)]
        public bool NotifyOnLogin
        {
            get { return ERPNextConverter.IntToBool((int)data.notify_on_login); }
            set { data.notify_on_login = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("notify_on_every_login", "int(1)", isNullable: false)]
        public bool NotifyOnEveryLogin
        {
            get { return ERPNextConverter.IntToBool((int)data.notify_on_every_login); }
            set { data.notify_on_every_login = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("expire_notification_on", "date", isNullable: true)]
        public DateOnly? ExpireNotificationOn
        {
            get { return ERPNextConverter.StringToDateOnly(data.expire_notification_on); }
            set { data.expire_notification_on = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("content", "longtext", isNullable: true)]
        public string? Content
        {
            get { return data.content; }
            set { data.content = value; }
        }

        [ColumnInfo("_user_tags", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _UserTags
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._user_tags; }
            set { data._user_tags = value; }
        }

        [ColumnInfo("_comments", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Comments
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._comments; }
            set { data._comments = value; }
        }

        [ColumnInfo("_assign", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Assign
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._assign; }
            set { data._assign = value; }
        }

        [ColumnInfo("_liked_by", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _LikedBy
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._liked_by; }
            set { data._liked_by = value; }
        }


    }
}

