/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Ecommerce.ItemReview
{
    public class Ecommerce_ItemReview_Service : SubServiceBase<ERP_Ecommerce_ItemReview>
    {
        public Ecommerce_ItemReview_Service(ERPNextClient client) : base(_DockType.Ecommerce_ItemReview, client) { }

        protected override ERP_Ecommerce_ItemReview FromERPObject(ERPObject obj)
        {
            return new ERP_Ecommerce_ItemReview(obj);
        }

        /* custom functions can be added here */

    }
}

