using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Customer
{
    public class ERPCustomer : ERPNextObjectBase
    {
        public ERPCustomer() : this(new ERPObject(DocType.Customer)) { }
        public ERPCustomer(ERPObject obj) : base(obj) { }

        public static ERPCustomer Create(string fullName, CustomerType customerType, string customerGroup, string territory)
        {
            ERPCustomer obj = new ERPCustomer();
            obj.customer_name = fullName;
            obj.customer_type = customerType;
            obj.customer_group = customerGroup;
            obj.territory = territory;
            return obj;
        }

        public CustomerType customer_type
        {
            get { return parseEnum<CustomerType>(data.customer_type); }
            set { data.customer_type = value.ToString(); }
        }

        public string customer_name
        {
            get { return data.customer_name; }
            set
            {
                data.customer_name = value;
                data.name = value;
            }
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
            get { return parseEnum<CustomerStatus>(data.status); }
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