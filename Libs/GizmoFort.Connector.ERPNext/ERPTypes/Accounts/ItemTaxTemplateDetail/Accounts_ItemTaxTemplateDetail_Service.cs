/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.ItemTaxTemplateDetail
{
    public class Accounts_ItemTaxTemplateDetail_Service : SubServiceBase<ERP_Accounts_ItemTaxTemplateDetail>
    {
        public Accounts_ItemTaxTemplateDetail_Service(ERPNextClient client) : base(_DockType.Accounts_ItemTaxTemplateDetail, client) { }

        protected override ERP_Accounts_ItemTaxTemplateDetail FromERPObject(ERPObject obj)
        {
            return new ERP_Accounts_ItemTaxTemplateDetail(obj);
        }

        /* custom functions can be added here */

    }
}
