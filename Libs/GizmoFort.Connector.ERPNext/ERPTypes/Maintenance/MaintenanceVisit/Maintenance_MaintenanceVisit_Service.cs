/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Maintenance.MaintenanceVisit
{
    public class Maintenance_MaintenanceVisit_Service : SubServiceBase<ERP_Maintenance_MaintenanceVisit>
    {
        public Maintenance_MaintenanceVisit_Service(ERPNextClient client) : base(_DockType.Maintenance_MaintenanceVisit, client) { }

        protected override ERP_Maintenance_MaintenanceVisit FromERPObject(ERPObject obj)
        {
            return new ERP_Maintenance_MaintenanceVisit(obj);
        }

        /* custom functions can be added here */

    }
}
