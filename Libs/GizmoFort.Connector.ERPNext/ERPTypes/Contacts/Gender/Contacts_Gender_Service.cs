/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Contacts.Gender
{
    public class Contacts_Gender_Service : SubServiceBase<ERP_Contacts_Gender>
    {
        public Contacts_Gender_Service(ERPNextClient client) : base(_DockType.Contacts_Gender, client) { }

        protected override ERP_Contacts_Gender FromERPObject(ERPObject obj)
        {
            return new ERP_Contacts_Gender(obj);
        }

        /* custom functions can be added here */

    }
}

