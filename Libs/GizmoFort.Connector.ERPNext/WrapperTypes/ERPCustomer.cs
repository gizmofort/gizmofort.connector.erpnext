using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.Utils;

namespace GizmoFort.Connector.ERPNext.WrapperTypes
{
    public class ERPCustomer : WrapperObjectBase
    {
        public ERPCustomer(ERPObject obj) : base(obj) { }

        public ERPCustomer() : this(new ERPObject(DocType.Customer)) { }

        public CustomerType customer_type
        {
            get { return EnumUtils.Parse<CustomerType>(data.customer_type); }
            set { data.customer_type = value.ToString(); }
        }

        public string customer_name
        {
            get { return data.customer_name; }
            set { data.customer_name = value; }
        }

        public string customer_group
        {
            get { return data.customer_group; }
            set { data.customer_group = value; }
        }

        public string website
        {
            get { return data.website; }
            set { data.website = value; }
        }

        public string territory
        {
            get { return data.territory; }
            set { data.territory = value; }
        }

        public CustomerStatus status
        {
            get { return EnumUtils.Parse<CustomerStatus>(data.status); }
            set { data.status = value.ToString(); }
        }
    }

    public enum CustomerType
    {
        Company,
        Individual,
    }

    public enum CustomerStatus
    {
        Active,
        Dormant,
        Open,
    }
}