/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.CustomDocPerm
{
    public class Core_CustomDocPerm_Service : SubServiceBase<ERP_Core_CustomDocPerm>
    {
        public Core_CustomDocPerm_Service(ERPNextClient client) : base(_DockType.Core_CustomDocPerm, client) { }

        protected override ERP_Core_CustomDocPerm FromERPObject(ERPObject obj)
        {
            return new ERP_Core_CustomDocPerm(obj);
        }

        /* custom functions can be added here */

    }
}

