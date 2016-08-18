using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;

namespace GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices
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