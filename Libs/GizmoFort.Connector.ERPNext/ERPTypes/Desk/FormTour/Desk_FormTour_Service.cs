/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Desk.FormTour
{
    public class Desk_FormTour_Service : SubServiceBase<ERP_Desk_FormTour>
    {
        public Desk_FormTour_Service(ERPNextClient client) : base(_DockType.Desk_FormTour, client) { }

        protected override ERP_Desk_FormTour FromERPObject(ERPObject obj)
        {
            return new ERP_Desk_FormTour(obj);
        }

        /* custom functions can be added here */

    }
}
