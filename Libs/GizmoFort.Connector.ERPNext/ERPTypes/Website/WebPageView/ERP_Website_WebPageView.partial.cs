/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Website.WebPageView
{
    public partial class ERP_Website_WebPageView : ERPNextObjectBase
    {
        public ERP_Website_WebPageView() : this(new ERPObject(_DockType.Website_WebPageView)) { }
        public ERP_Website_WebPageView(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Website_WebPageView>(propertyName);
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

        [Column("path")]
        public string? Path
        {
            get { return data.path; }
            set { data.path = value; }
        }

        [Column("referrer")]
        public string? Referrer
        {
            get { return data.referrer; }
            set { data.referrer = value; }
        }

        [Column("browser")]
        public string? Browser
        {
            get { return data.browser; }
            set { data.browser = value; }
        }

        [Column("browser_version")]
        public string? BrowserVersion
        {
            get { return data.browser_version; }
            set { data.browser_version = value; }
        }

        [Column("is_unique")]
        public string? IsUnique
        {
            get { return data.is_unique; }
            set { data.is_unique = value; }
        }

        [Column("time_zone")]
        public string? TimeZone
        {
            get { return data.time_zone; }
            set { data.time_zone = value; }
        }

        [Column("user_agent")]
        public string? UserAgent
        {
            get { return data.user_agent; }
            set { data.user_agent = value; }
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
