/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.BulkTransaction.BulkTransactionLog
{
    public class BulkTransaction_BulkTransactionLog_Service : SubServiceBase<ERP_BulkTransaction_BulkTransactionLog>
    {
        public BulkTransaction_BulkTransactionLog_Service(ERPNextClient client) : base(_DockType.BulkTransaction_BulkTransactionLog, client) { }

        protected override ERP_BulkTransaction_BulkTransactionLog FromERPObject(ERPObject obj)
        {
            return new ERP_BulkTransaction_BulkTransactionLog(obj);
        }

        /* custom functions can be added here */

    }
}
