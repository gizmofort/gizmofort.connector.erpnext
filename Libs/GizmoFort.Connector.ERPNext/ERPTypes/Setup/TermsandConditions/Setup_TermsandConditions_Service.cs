/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Setup.TermsandConditions
{
    public class Setup_TermsandConditions_Service : SubServiceBase<ERP_Setup_TermsandConditions>
    {
        public Setup_TermsandConditions_Service(ERPNextClient client) : base(_DockType.Setup_TermsandConditions, client) { }

        protected override ERP_Setup_TermsandConditions FromERPObject(ERPObject obj)
        {
            return new ERP_Setup_TermsandConditions(obj);
        }

        /* custom functions can be added here */

    }
}
