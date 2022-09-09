/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Assets.AssetValueAdjustment
{
    public class Assets_AssetValueAdjustment_Service : SubServiceBase<ERP_Assets_AssetValueAdjustment>
    {
        public Assets_AssetValueAdjustment_Service(ERPNextClient client) : base(_DockType.Assets_AssetValueAdjustment, client) { }

        protected override ERP_Assets_AssetValueAdjustment FromERPObject(ERPObject obj)
        {
            return new ERP_Assets_AssetValueAdjustment(obj);
        }

        /* custom functions can be added here */

    }
}
