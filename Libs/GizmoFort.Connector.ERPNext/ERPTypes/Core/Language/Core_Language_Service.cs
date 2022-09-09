/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.Language
{
    public class Core_Language_Service : SubServiceBase<ERP_Core_Language>
    {
        public Core_Language_Service(ERPNextClient client) : base(_DockType.Core_Language, client) { }

        protected override ERP_Core_Language FromERPObject(ERPObject obj)
        {
            return new ERP_Core_Language(obj);
        }

        /* custom functions can be added here */

    }
}
