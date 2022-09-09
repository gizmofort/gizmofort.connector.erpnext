/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.BankAccount
{
    public class Accounts_BankAccount_Service : SubServiceBase<ERP_Accounts_BankAccount>
    {
        public Accounts_BankAccount_Service(ERPNextClient client) : base(_DockType.Accounts_BankAccount, client) { }

        protected override ERP_Accounts_BankAccount FromERPObject(ERPObject obj)
        {
            return new ERP_Accounts_BankAccount(obj);
        }

        /* custom functions can be added here */

    }
}

