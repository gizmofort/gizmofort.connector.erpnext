/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Support.Issue
{
    public class Support_Issue_Service : SubServiceBase<ERP_Support_Issue>
    {
        public Support_Issue_Service(ERPNextClient client) : base(_DockType.Support_Issue, client) { }

        protected override ERP_Support_Issue FromERPObject(ERPObject obj)
        {
            return new ERP_Support_Issue(obj);
        }

        /* custom functions can be added here */

    }
}
