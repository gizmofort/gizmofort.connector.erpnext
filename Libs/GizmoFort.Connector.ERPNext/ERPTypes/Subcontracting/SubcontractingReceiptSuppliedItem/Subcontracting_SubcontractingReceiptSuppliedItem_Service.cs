/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Subcontracting.SubcontractingReceiptSuppliedItem
{
    public class Subcontracting_SubcontractingReceiptSuppliedItem_Service : SubServiceBase<ERP_Subcontracting_SubcontractingReceiptSuppliedItem>
    {
        public Subcontracting_SubcontractingReceiptSuppliedItem_Service(ERPNextClient client) : base(_DockType.Subcontracting_SubcontractingReceiptSuppliedItem, client) { }

        protected override ERP_Subcontracting_SubcontractingReceiptSuppliedItem FromERPObject(ERPObject obj)
        {
            return new ERP_Subcontracting_SubcontractingReceiptSuppliedItem(obj);
        }

        /* custom functions can be added here */

    }
}
