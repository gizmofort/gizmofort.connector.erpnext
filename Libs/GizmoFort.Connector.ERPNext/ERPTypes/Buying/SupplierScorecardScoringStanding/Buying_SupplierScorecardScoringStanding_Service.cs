/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Buying.SupplierScorecardScoringStanding
{
    public class Buying_SupplierScorecardScoringStanding_Service : SubServiceBase<ERP_Buying_SupplierScorecardScoringStanding>
    {
        public Buying_SupplierScorecardScoringStanding_Service(ERPNextClient client) : base(_DockType.Buying_SupplierScorecardScoringStanding, client) { }

        protected override ERP_Buying_SupplierScorecardScoringStanding FromERPObject(ERPObject obj)
        {
            return new ERP_Buying_SupplierScorecardScoringStanding(obj);
        }

        /* custom functions can be added here */

    }
}
