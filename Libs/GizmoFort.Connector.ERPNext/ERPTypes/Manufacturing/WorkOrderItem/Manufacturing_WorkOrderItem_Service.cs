/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Manufacturing.WorkOrderItem
{
    public class Manufacturing_WorkOrderItem_Service : SubServiceBase<ERP_Manufacturing_WorkOrderItem>
    {
        public Manufacturing_WorkOrderItem_Service(ERPNextClient client) : base(_DockType.Manufacturing_WorkOrderItem, client) { }

        protected override ERP_Manufacturing_WorkOrderItem FromERPObject(ERPObject obj)
        {
            return new ERP_Manufacturing_WorkOrderItem(obj);
        }

        /* custom functions can be added here */

    }
}

