/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Workflow.Workflow
{
    public class Workflow_Workflow_Service : SubServiceBase<ERP_Workflow_Workflow>
    {
        public Workflow_Workflow_Service(ERPNextClient client) : base(_DockType.Workflow_Workflow, client) { }

        protected override ERP_Workflow_Workflow FromERPObject(ERPObject obj)
        {
            return new ERP_Workflow_Workflow(obj);
        }

        /* custom functions can be added here */

    }
}

