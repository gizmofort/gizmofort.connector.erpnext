/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.WrapperTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Workflow.WorkflowState
{
    /*** NOTE: This file can be modified and will not be re-generated unless deleted ***/

    public partial class ERP_Workflow_WorkflowState : ERPNextObjectBase
    {
        public static ERP_Workflow_WorkflowState CreateNew(string name /* add other parameters as needed */ )
        {
            ERP_Workflow_WorkflowState obj = new()
            {
                Name = name
                /* set other properties from parameters here */
            };
            return obj;
        }
    }
}
