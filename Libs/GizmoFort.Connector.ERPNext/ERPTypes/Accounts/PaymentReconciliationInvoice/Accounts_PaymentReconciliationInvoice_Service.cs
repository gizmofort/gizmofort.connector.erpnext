/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.PaymentReconciliationInvoice
{
    public class Accounts_PaymentReconciliationInvoice_Service : SubServiceBase<ERP_Accounts_PaymentReconciliationInvoice>
    {
        public Accounts_PaymentReconciliationInvoice_Service(ERPNextClient client) : base(_DockType.Accounts_PaymentReconciliationInvoice, client) { }

        protected override ERP_Accounts_PaymentReconciliationInvoice FromERPObject(ERPObject obj)
        {
            return new ERP_Accounts_PaymentReconciliationInvoice(obj);
        }

        /* custom functions can be added here */

    }
}
