/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.WrapperTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.DocShare
{
    /*** NOTE: This file can be modified and will not be re-generated unless deleted ***/

    public partial class ERP_Core_DocShare : ERPNextObjectBase
    {
        public static ERP_Core_DocShare CreateNew(long name /* add other parameters as needed */ )
        {
            ERP_Core_DocShare obj = new()
            {
                Name = name
                /* set other properties from parameters here */
            };
            return obj;
        }
    }
}

