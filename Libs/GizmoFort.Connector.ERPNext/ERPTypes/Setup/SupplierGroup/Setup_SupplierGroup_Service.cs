/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Setup.SupplierGroup
{
    public class Setup_SupplierGroup_Service : SubServiceBase<ERP_Setup_SupplierGroup>
    {
        public Setup_SupplierGroup_Service(ERPNextClient client) : base(_DockType.Setup_SupplierGroup, client) { }

        protected override ERP_Setup_SupplierGroup FromERPObject(ERPObject obj)
        {
            return new ERP_Setup_SupplierGroup(obj);
        }

        /* custom functions can be added here */

    }
}

