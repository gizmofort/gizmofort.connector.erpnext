using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Customer
{
    public class CustomerService : SubServiceBase<ERPCustomer>
    {
        public CustomerService(ERPNextClient client) : base(DocType.Customer, client)
        {
        }

        protected override ERPCustomer fromERPObject(ERPObject obj)
        {
            return new ERPCustomer(obj);
        }
    }
}