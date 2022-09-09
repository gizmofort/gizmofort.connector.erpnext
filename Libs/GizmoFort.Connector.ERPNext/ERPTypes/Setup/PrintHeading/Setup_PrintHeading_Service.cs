/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Setup.PrintHeading
{
    public class Setup_PrintHeading_Service : SubServiceBase<ERP_Setup_PrintHeading>
    {
        public Setup_PrintHeading_Service(ERPNextClient client) : base(_DockType.Setup_PrintHeading, client) { }

        protected override ERP_Setup_PrintHeading FromERPObject(ERPObject obj)
        {
            return new ERP_Setup_PrintHeading(obj);
        }

        /* custom functions can be added here */

    }
}
