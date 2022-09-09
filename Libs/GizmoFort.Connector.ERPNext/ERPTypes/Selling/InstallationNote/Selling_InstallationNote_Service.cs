/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Selling.InstallationNote
{
    public class Selling_InstallationNote_Service : SubServiceBase<ERP_Selling_InstallationNote>
    {
        public Selling_InstallationNote_Service(ERPNextClient client) : base(_DockType.Selling_InstallationNote, client) { }

        protected override ERP_Selling_InstallationNote FromERPObject(ERPObject obj)
        {
            return new ERP_Selling_InstallationNote(obj);
        }

        /* custom functions can be added here */

    }
}
