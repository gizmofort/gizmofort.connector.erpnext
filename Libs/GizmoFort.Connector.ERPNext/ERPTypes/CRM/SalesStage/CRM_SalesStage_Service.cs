/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.CRM.SalesStage
{
    public class CRM_SalesStage_Service : SubServiceBase<ERP_CRM_SalesStage>
    {
        public CRM_SalesStage_Service(ERPNextClient client) : base(_DockType.CRM_SalesStage, client) { }

        protected override ERP_CRM_SalesStage FromERPObject(ERPObject obj)
        {
            return new ERP_CRM_SalesStage(obj);
        }

        /* custom functions can be added here */

    }
}

