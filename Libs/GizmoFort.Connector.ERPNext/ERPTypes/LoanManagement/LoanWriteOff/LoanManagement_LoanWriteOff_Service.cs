/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.LoanManagement.LoanWriteOff
{
    public class LoanManagement_LoanWriteOff_Service : SubServiceBase<ERP_LoanManagement_LoanWriteOff>
    {
        public LoanManagement_LoanWriteOff_Service(ERPNextClient client) : base(_DockType.LoanManagement_LoanWriteOff, client) { }

        protected override ERP_LoanManagement_LoanWriteOff FromERPObject(ERPObject obj)
        {
            return new ERP_LoanManagement_LoanWriteOff(obj);
        }

        /* custom functions can be added here */

    }
}
