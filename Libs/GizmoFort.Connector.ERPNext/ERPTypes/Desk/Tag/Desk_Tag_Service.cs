/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Desk.Tag
{
    public class Desk_Tag_Service : SubServiceBase<ERP_Desk_Tag>
    {
        public Desk_Tag_Service(ERPNextClient client) : base(_DockType.Desk_Tag, client) { }

        protected override ERP_Desk_Tag FromERPObject(ERPObject obj)
        {
            return new ERP_Desk_Tag(obj);
        }

        /* custom functions can be added here */

    }
}
