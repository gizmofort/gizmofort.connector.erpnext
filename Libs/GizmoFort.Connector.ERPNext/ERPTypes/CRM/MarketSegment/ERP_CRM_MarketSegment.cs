/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.WrapperTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.CRM.MarketSegment
{
    /*** NOTE: This file can be modified and will not be re-generated unless deleted ***/

    public partial class ERP_CRM_MarketSegment : ERPNextObjectBase
    {
        public static ERP_CRM_MarketSegment CreateNew(string name /* add other parameters as needed */ )
        {
            ERP_CRM_MarketSegment obj = new()
            {
                Name = name
                /* set other properties from parameters here */
            };
            return obj;
        }
    }
}
