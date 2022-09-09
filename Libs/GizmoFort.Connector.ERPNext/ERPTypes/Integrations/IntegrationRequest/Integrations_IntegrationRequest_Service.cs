/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Integrations.IntegrationRequest
{
    public class Integrations_IntegrationRequest_Service : SubServiceBase<ERP_Integrations_IntegrationRequest>
    {
        public Integrations_IntegrationRequest_Service(ERPNextClient client) : base(_DockType.Integrations_IntegrationRequest, client) { }

        protected override ERP_Integrations_IntegrationRequest FromERPObject(ERPObject obj)
        {
            return new ERP_Integrations_IntegrationRequest(obj);
        }

        /* custom functions can be added here */

    }
}
