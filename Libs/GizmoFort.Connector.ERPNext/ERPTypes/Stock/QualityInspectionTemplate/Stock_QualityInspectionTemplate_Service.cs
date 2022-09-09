/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.QualityInspectionTemplate
{
    public class Stock_QualityInspectionTemplate_Service : SubServiceBase<ERP_Stock_QualityInspectionTemplate>
    {
        public Stock_QualityInspectionTemplate_Service(ERPNextClient client) : base(_DockType.Stock_QualityInspectionTemplate, client) { }

        protected override ERP_Stock_QualityInspectionTemplate FromERPObject(ERPObject obj)
        {
            return new ERP_Stock_QualityInspectionTemplate(obj);
        }

        /* custom functions can be added here */

    }
}
