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
            get { return EnumUtils.Parse<CustomerType>(parameters.customer_type); }
            set { parameters.customer_type = value.ToString(); }
        }

        public string customer_name
        {
            get { return parameters.customer_name; }
            set { parameters.customer_name = value; }
        }

        public string customer_group
        {
            get { return parameters.customer_group; }
            set { parameters.customer_group = value; }
        }

        public string website
        {
            get { return parameters.website; }
            set { parameters.website = value; }
        }

        public string territory
        {
            get { return parameters.territory; }
            set { parameters.territory = value; }
        }

        public CustomerStatus status
        {
            get { return EnumUtils.Parse<CustomerStatus>(parameters.status); }
            set { parameters.status = value.ToString(); }
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