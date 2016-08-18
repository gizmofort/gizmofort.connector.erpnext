using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;

namespace GizmoFort.Connector.ERPNext.PublicInterfaces
{
    public class ERPNextServices
    {
        private readonly ERPNextClient _client;
        public CustomerService Customer { get; }

        public ERPNextServices(string domain, string username, string password)
        {
            this._client = new ERPNextClient(domain, username, password);
            this.Customer = new CustomerService(_client);
        }
    }
}