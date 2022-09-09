/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.DeliveryStop
{
    public partial class ERP_Stock_DeliveryStop : ERPNextObjectBase
    {
        public ERP_Stock_DeliveryStop() : this(new ERPObject(_DockType.Stock_DeliveryStop)) { }
        public ERP_Stock_DeliveryStop(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Stock_DeliveryStop>(propertyName);
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

        [Column("customer")]
        public string? Customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        [Column("address")]
        public string? Address
        {
            get { return data.address; }
            set { data.address = value; }
        }

        [Column("@lock")]
        public int Lock
        {
            get { return data.@lock; }
            set { data.@lock = value; }
        }

        [Column("customer_address")]
        public string? CustomerAddress
        {
            get { return data.customer_address; }
            set { data.customer_address = value; }
        }

        [Column("visited")]
        public int Visited
        {
            get { return data.visited; }
            set { data.visited = value; }
        }

        [Column("delivery_note")]
        public string? DeliveryNote
        {
            get { return data.delivery_note; }
            set { data.delivery_note = value; }
        }

        [Column("grand_total")]
        public decimal GrandTotal
        {
            get { return data.grand_total; }
            set { data.grand_total = value; }
        }

        [Column("contact")]
        public string? Contact
        {
            get { return data.contact; }
            set { data.contact = value; }
        }

        [Column("email_sent_to")]
        public string? EmailSentTo
        {
            get { return data.email_sent_to; }
            set { data.email_sent_to = value; }
        }

        [Column("customer_contact")]
        public string? CustomerContact
        {
            get { return data.customer_contact; }
            set { data.customer_contact = value; }
        }

        [Column("distance")]
        public decimal Distance
        {
            get { return data.distance; }
            set { data.distance = value; }
        }

        [Column("estimated_arrival")]
        public DateTime? EstimatedArrival
        {
            get { return data.estimated_arrival; }
            set { data.estimated_arrival = value; }
        }

        [Column("lat")]
        public decimal Lat
        {
            get { return data.lat; }
            set { data.lat = value; }
        }

        [Column("uom")]
        public string? Uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        [Column("lng")]
        public decimal Lng
        {
            get { return data.lng; }
            set { data.lng = value; }
        }

        [Column("details")]
        public string? Details
        {
            get { return data.details; }
            set { data.details = value; }
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
