/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.QualityManagement.QualityReviewObjective
{
    public class QualityManagement_QualityReviewObjective_Service : SubServiceBase<ERP_QualityManagement_QualityReviewObjective>
    {
        public QualityManagement_QualityReviewObjective_Service(ERPNextClient client) : base(_DockType.QualityManagement_QualityReviewObjective, client) { }

        protected override ERP_QualityManagement_QualityReviewObjective FromERPObject(ERPObject obj)
        {
            return new ERP_QualityManagement_QualityReviewObjective(obj);
        }

        /* custom functions can be added here */

    }
}
