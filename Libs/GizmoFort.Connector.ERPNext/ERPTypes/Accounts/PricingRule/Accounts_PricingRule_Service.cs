/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.PricingRule
{
    public class Accounts_PricingRule_Service : SubServiceBase<ERP_Accounts_PricingRule>
    {
        public Accounts_PricingRule_Service(ERPNextClient client) : base(_DockType.Accounts_PricingRule, client) { }

        protected override ERP_Accounts_PricingRule FromERPObject(ERPObject obj)
        {
            return new ERP_Accounts_PricingRule(obj);
        }

        /* custom functions can be added here */

    }
}

