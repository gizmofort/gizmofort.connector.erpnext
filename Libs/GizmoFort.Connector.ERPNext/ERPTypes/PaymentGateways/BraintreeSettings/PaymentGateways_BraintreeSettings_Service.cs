/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.PaymentGateways.BraintreeSettings
{
    public class PaymentGateways_BraintreeSettings_Service : SubServiceBase<ERP_PaymentGateways_BraintreeSettings>
    {
        public PaymentGateways_BraintreeSettings_Service(ERPNextClient client) : base(_DockType.PaymentGateways_BraintreeSettings, client) { }

        protected override ERP_PaymentGateways_BraintreeSettings FromERPObject(ERPObject obj)
        {
            return new ERP_PaymentGateways_BraintreeSettings(obj);
        }

        /* custom functions can be added here */

    }
}

