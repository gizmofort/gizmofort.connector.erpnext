/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.CRM.Contract
{
    public class CRM_Contract_Service : SubServiceBase<ERP_CRM_Contract>
    {
        public CRM_Contract_Service(ERPNextClient client) : base(_DockType.CRM_Contract, client) { }

        protected override ERP_CRM_Contract FromERPObject(ERPObject obj)
        {
            return new ERP_CRM_Contract(obj);
        }

        /* custom functions can be added here */

    }
}

