/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.LoyaltyProgram
{
    public class Accounts_LoyaltyProgram_Service : SubServiceBase<ERP_Accounts_LoyaltyProgram>
    {
        public Accounts_LoyaltyProgram_Service(ERPNextClient client) : base(_DockType.Accounts_LoyaltyProgram, client) { }

        protected override ERP_Accounts_LoyaltyProgram FromERPObject(ERPObject obj)
        {
            return new ERP_Accounts_LoyaltyProgram(obj);
        }

        /* custom functions can be added here */

    }
}
