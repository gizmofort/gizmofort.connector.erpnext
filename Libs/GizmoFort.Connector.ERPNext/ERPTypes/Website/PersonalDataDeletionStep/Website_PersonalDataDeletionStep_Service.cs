/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Website.PersonalDataDeletionStep
{
    public class Website_PersonalDataDeletionStep_Service : SubServiceBase<ERP_Website_PersonalDataDeletionStep>
    {
        public Website_PersonalDataDeletionStep_Service(ERPNextClient client) : base(_DockType.Website_PersonalDataDeletionStep, client) { }

        protected override ERP_Website_PersonalDataDeletionStep FromERPObject(ERPObject obj)
        {
            return new ERP_Website_PersonalDataDeletionStep(obj);
        }

        /* custom functions can be added here */

    }
}
