/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.CashierClosing
{
    public class Accounts_CashierClosing_Service : SubServiceBase<ERP_Accounts_CashierClosing>
    {
        public Accounts_CashierClosing_Service(ERPNextClient client) : base(_DockType.Accounts_CashierClosing, client) { }

        protected override ERP_Accounts_CashierClosing FromERPObject(ERPObject obj)
        {
            return new ERP_Accounts_CashierClosing(obj);
        }

        /* custom functions can be added here */

    }
}
