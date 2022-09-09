/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Website.WebsiteTheme
{
    public partial class ERP_Website_WebsiteTheme : ERPNextObjectBase
    {
        public ERP_Website_WebsiteTheme() : this(new ERPObject(_DockType.Website_WebsiteTheme)) { }
        public ERP_Website_WebsiteTheme(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Website_WebsiteTheme>(propertyName);
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

        [Column("theme")]
        public string? Theme
        {
            get { return data.theme; }
            set { data.theme = value; }
        }

        [Column("module")]
        public string? Module
        {
            get { return data.module; }
            set { data.module = value; }
        }

        [Column("custom")]
        public int Custom
        {
            get { return data.custom; }
            set { data.custom = value; }
        }

        [Column("google_font")]
        public string? GoogleFont
        {
            get { return data.google_font; }
            set { data.google_font = value; }
        }

        [Column("font_size")]
        public string? FontSize
        {
            get { return data.font_size; }
            set { data.font_size = value; }
        }

        [Column("font_properties")]
        public string? FontProperties
        {
            get { return data.font_properties; }
            set { data.font_properties = value; }
        }

        [Column("button_rounded_corners")]
        public int ButtonRoundedCorners
        {
            get { return data.button_rounded_corners; }
            set { data.button_rounded_corners = value; }
        }

        [Column("button_shadows")]
        public int ButtonShadows
        {
            get { return data.button_shadows; }
            set { data.button_shadows = value; }
        }

        [Column("button_gradients")]
        public int ButtonGradients
        {
            get { return data.button_gradients; }
            set { data.button_gradients = value; }
        }

        [Column("primary_color")]
        public string? PrimaryColor
        {
            get { return data.primary_color; }
            set { data.primary_color = value; }
        }

        [Column("text_color")]
        public string? TextColor
        {
            get { return data.text_color; }
            set { data.text_color = value; }
        }

        [Column("light_color")]
        public string? LightColor
        {
            get { return data.light_color; }
            set { data.light_color = value; }
        }

        [Column("dark_color")]
        public string? DarkColor
        {
            get { return data.dark_color; }
            set { data.dark_color = value; }
        }

        [Column("background_color")]
        public string? BackgroundColor
        {
            get { return data.background_color; }
            set { data.background_color = value; }
        }

        [Column("custom_overrides")]
        public string? CustomOverrides
        {
            get { return data.custom_overrides; }
            set { data.custom_overrides = value; }
        }

        [Column("custom_scss")]
        public string? CustomScss
        {
            get { return data.custom_scss; }
            set { data.custom_scss = value; }
        }

        [Column("theme_scss")]
        public string? ThemeScss
        {
            get { return data.theme_scss; }
            set { data.theme_scss = value; }
        }

        [Column("theme_url")]
        public string? ThemeUrl
        {
            get { return data.theme_url; }
            set { data.theme_url = value; }
        }

        [Column("js")]
        public string? Js
        {
            get { return data.js; }
            set { data.js = value; }
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
