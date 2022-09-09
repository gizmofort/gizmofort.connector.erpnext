/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.PutawayRule
{
    public class Stock_PutawayRule_Service : SubServiceBase<ERP_Stock_PutawayRule>
    {
        public Stock_PutawayRule_Service(ERPNextClient client) : base(_DockType.Stock_PutawayRule, client) { }

        protected override ERP_Stock_PutawayRule FromERPObject(ERPObject obj)
        {
            return new ERP_Stock_PutawayRule(obj);
        }

        /* custom functions can be added here */

    }
}

