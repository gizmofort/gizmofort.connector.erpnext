using GizmoFort.Connector.ERPNext.ERPTypes.Customer;
using GizmoFort.Connector.ERPNext.ERPTypes.Item;
using GizmoFort.Connector.ERPNext.ERPTypes.Warehouse;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;

namespace GizmoFort.Connector.ERPNext.PublicInterfaces
{
    public class ERPNextServices
    {
        public ERPNextClient Client { get; }
        public CustomerService CustomerService { get; }
        public ItemService ItemService { get; }
        public WarehouseService WarehouseService { get; }

        public ERPNextServices(string domain, string username, string password)
        {
            this.Client = new ERPNextClient(domain, username, password);
            this.CustomerService = new CustomerService(Client);
            this.ItemService = new ItemService(Client);
            this.WarehouseService = new WarehouseService(Client);
        }
    }
}