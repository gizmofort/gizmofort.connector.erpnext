/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.POSInvoiceMergeLog
{
    public class Accounts_POSInvoiceMergeLog_Service : SubServiceBase<ERP_Accounts_POSInvoiceMergeLog>
    {
        public Accounts_POSInvoiceMergeLog_Service(ERPNextClient client) : base(_DockType.Accounts_POSInvoiceMergeLog, client) { }

        protected override ERP_Accounts_POSInvoiceMergeLog FromERPObject(ERPObject obj)
        {
            return new ERP_Accounts_POSInvoiceMergeLog(obj);
        }

        /* custom functions can be added here */

    }
}

