/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Utilities.SMSLog
{
    public class Utilities_SMSLog_Service : SubServiceBase<ERP_Utilities_SMSLog>
    {
        public Utilities_SMSLog_Service(ERPNextClient client) : base(_DockType.Utilities_SMSLog, client) { }

        protected override ERP_Utilities_SMSLog FromERPObject(ERPObject obj)
        {
            return new ERP_Utilities_SMSLog(obj);
        }

        /* custom functions can be added here */

    }
}
