using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Item
{
    public class ItemService : SubServiceBase<ERPItem>
    {
        public ItemService(ERPNextClient client) : base(DocType.Item, client)
        {
        }

        protected override ERPItem fromERPObject(ERPObject obj)
        {
            return new ERPItem(obj);
        }
    }
}