/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Manufacturing.BOMItem
{
    public class Manufacturing_BOMItem_Service : SubServiceBase<ERP_Manufacturing_BOMItem>
    {
        public Manufacturing_BOMItem_Service(ERPNextClient client) : base(_DockType.Manufacturing_BOMItem, client) { }

        protected override ERP_Manufacturing_BOMItem FromERPObject(ERPObject obj)
        {
            return new ERP_Manufacturing_BOMItem(obj);
        }

        /* custom functions can be added here */

    }
}
