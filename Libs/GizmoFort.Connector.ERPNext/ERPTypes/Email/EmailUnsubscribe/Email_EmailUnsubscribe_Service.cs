/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Email.EmailUnsubscribe
{
    public class Email_EmailUnsubscribe_Service : SubServiceBase<ERP_Email_EmailUnsubscribe>
    {
        public Email_EmailUnsubscribe_Service(ERPNextClient client) : base(_DockType.Email_EmailUnsubscribe, client) { }

        protected override ERP_Email_EmailUnsubscribe FromERPObject(ERPObject obj)
        {
            return new ERP_Email_EmailUnsubscribe(obj);
        }

        /* custom functions can be added here */

    }
}
