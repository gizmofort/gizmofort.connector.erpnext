/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.LoanManagement.LoanDisbursement
{
    public class LoanManagement_LoanDisbursement_Service : SubServiceBase<ERP_LoanManagement_LoanDisbursement>
    {
        public LoanManagement_LoanDisbursement_Service(ERPNextClient client) : base(_DockType.LoanManagement_LoanDisbursement, client) { }

        protected override ERP_LoanManagement_LoanDisbursement FromERPObject(ERPObject obj)
        {
            return new ERP_LoanManagement_LoanDisbursement(obj);
        }

        /* custom functions can be added here */

    }
}
