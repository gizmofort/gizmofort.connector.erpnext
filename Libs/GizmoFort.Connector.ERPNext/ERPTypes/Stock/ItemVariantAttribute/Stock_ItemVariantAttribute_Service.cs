/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.ItemVariantAttribute
{
    public class Stock_ItemVariantAttribute_Service : SubServiceBase<ERP_Stock_ItemVariantAttribute>
    {
        public Stock_ItemVariantAttribute_Service(ERPNextClient client) : base(_DockType.Stock_ItemVariantAttribute, client) { }

        protected override ERP_Stock_ItemVariantAttribute FromERPObject(ERPObject obj)
        {
            return new ERP_Stock_ItemVariantAttribute(obj);
        }

        /* custom functions can be added here */

    }
}
