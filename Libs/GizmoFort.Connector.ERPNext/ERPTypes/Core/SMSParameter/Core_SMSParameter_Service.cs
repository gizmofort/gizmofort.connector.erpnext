/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.SMSParameter
{
    public class Core_SMSParameter_Service : SubServiceBase<ERP_Core_SMSParameter>
    {
        public Core_SMSParameter_Service(ERPNextClient client) : base(_DockType.Core_SMSParameter, client) { }

        protected override ERP_Core_SMSParameter FromERPObject(ERPObject obj)
        {
            return new ERP_Core_SMSParameter(obj);
        }

        /* custom functions can be added here */

    }
}
