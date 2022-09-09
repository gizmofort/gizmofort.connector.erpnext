/********************************************************************
    This file has been auto-generated by GenerateDoceFromSchemaJason
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.WrapperTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.Item
{
    /*** NOTE: This file can be modified and will not be re-generated unless deleted ***/

    public partial class ERP_Stock_Item : ERPNextObjectBase
    {
        public static ERP_Stock_Item CreateNew(string name /* add other parameters as needed */ )
        {
            ERP_Stock_Item obj = new()
            {
                Name = name
                /* set other properties from parameters here */
            };
            return obj;
        }

        public static ERP_Stock_Item CreateNew(string itemCode, string itemName, string itemGroup)
        {
            ERP_Stock_Item obj = new()
            {
                Name = itemName,
                ItemCode = itemCode,
                ItemName = itemName,
                ItemGroup = itemGroup
            };
            return obj;
        }

    }
}
