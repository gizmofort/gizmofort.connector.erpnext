/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Portal.HomepageSection
{
    public class Portal_HomepageSection_Service : SubServiceBase<ERP_Portal_HomepageSection>
    {
        public Portal_HomepageSection_Service(ERPNextClient client) : base(_DockType.Portal_HomepageSection, client) { }

        protected override ERP_Portal_HomepageSection FromERPObject(ERPObject obj)
        {
            return new ERP_Portal_HomepageSection(obj);
        }

        /* custom functions can be added here */

    }
}

