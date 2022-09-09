/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Integrations.Webhook
{
    public class Integrations_Webhook_Service : SubServiceBase<ERP_Integrations_Webhook>
    {
        public Integrations_Webhook_Service(ERPNextClient client) : base(_DockType.Integrations_Webhook, client) { }

        protected override ERP_Integrations_Webhook FromERPObject(ERPObject obj)
        {
            return new ERP_Integrations_Webhook(obj);
        }

        /* custom functions can be added here */

    }
}
