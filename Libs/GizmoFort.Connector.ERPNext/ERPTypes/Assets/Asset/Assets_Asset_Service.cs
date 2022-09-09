/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Assets.Asset
{
    public class Assets_Asset_Service : SubServiceBase<ERP_Assets_Asset>
    {
        public Assets_Asset_Service(ERPNextClient client) : base(_DockType.Assets_Asset, client) { }

        protected override ERP_Assets_Asset FromERPObject(ERPObject obj)
        {
            return new ERP_Assets_Asset(obj);
        }

        /* custom functions can be added here */

    }
}
