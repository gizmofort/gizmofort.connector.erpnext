using GizmoFort.Connector.ERPNext.ERPTypes.Customer;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;

namespace GizmoFort.Connector.ERPNext.PublicInterfaces
{
    public class ERPNextServiceCollection
    {
        private readonly ERPNextClient _client;
        public CustomerService Customer { get; }

        public ERPNextServiceCollection(string domain, string username, string password)
        {
            this._client = new ERPNextClient(domain, username, password);
            this.Customer = new CustomerService(_client);
        }
    }
}