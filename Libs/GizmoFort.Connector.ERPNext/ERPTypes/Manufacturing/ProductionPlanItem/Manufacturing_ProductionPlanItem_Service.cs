/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Manufacturing.ProductionPlanItem
{
    public class Manufacturing_ProductionPlanItem_Service : SubServiceBase<ERP_Manufacturing_ProductionPlanItem>
    {
        public Manufacturing_ProductionPlanItem_Service(ERPNextClient client) : base(_DockType.Manufacturing_ProductionPlanItem, client) { }

        protected override ERP_Manufacturing_ProductionPlanItem FromERPObject(ERPObject obj)
        {
            return new ERP_Manufacturing_ProductionPlanItem(obj);
        }

        /* custom functions can be added here */

    }
}
