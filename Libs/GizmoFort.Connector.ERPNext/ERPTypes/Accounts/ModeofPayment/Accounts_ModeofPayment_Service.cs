/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.ModeofPayment
{
    public class Accounts_ModeofPayment_Service : SubServiceBase<ERP_Accounts_ModeofPayment>
    {
        public Accounts_ModeofPayment_Service(ERPNextClient client) : base(_DockType.Accounts_ModeofPayment, client) { }

        protected override ERP_Accounts_ModeofPayment FromERPObject(ERPObject obj)
        {
            return new ERP_Accounts_ModeofPayment(obj);
        }

        /* custom functions can be added here */

    }
}
