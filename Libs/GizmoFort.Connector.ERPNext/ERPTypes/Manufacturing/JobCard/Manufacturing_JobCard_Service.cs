/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Manufacturing.JobCard
{
    public class Manufacturing_JobCard_Service : SubServiceBase<ERP_Manufacturing_JobCard>
    {
        public Manufacturing_JobCard_Service(ERPNextClient client) : base(_DockType.Manufacturing_JobCard, client) { }

        protected override ERP_Manufacturing_JobCard FromERPObject(ERPObject obj)
        {
            return new ERP_Manufacturing_JobCard(obj);
        }

        /* custom functions can be added here */

    }
}
