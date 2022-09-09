/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.PriceList
{
    public class Stock_PriceList_Service : SubServiceBase<ERP_Stock_PriceList>
    {
        public Stock_PriceList_Service(ERPNextClient client) : base(_DockType.Stock_PriceList, client) { }

        protected override ERP_Stock_PriceList FromERPObject(ERPObject obj)
        {
            return new ERP_Stock_PriceList(obj);
        }

        /* custom functions can be added here */

    }
}

