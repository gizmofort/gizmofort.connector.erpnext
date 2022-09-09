/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Projects.Timesheet
{
    public class Projects_Timesheet_Service : SubServiceBase<ERP_Projects_Timesheet>
    {
        public Projects_Timesheet_Service(ERPNextClient client) : base(_DockType.Projects_Timesheet, client) { }

        protected override ERP_Projects_Timesheet FromERPObject(ERPObject obj)
        {
            return new ERP_Projects_Timesheet(obj);
        }

        /* custom functions can be added here */

    }
}

