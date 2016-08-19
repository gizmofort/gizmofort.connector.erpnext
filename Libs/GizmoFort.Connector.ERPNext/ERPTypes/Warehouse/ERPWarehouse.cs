using GizmoFort.Connector.ERPNext.ERPTypes.Item;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Warehouse
{
    public class ERPWarehouse : ERPNextObjectBase
    {
        public ERPWarehouse() : this(new ERPObject(DocType.Item)) { }
        public ERPWarehouse(ERPObject obj) : base(obj) { }

        public static ERPItem Create(string itemName, string itemGroup)
        {
            ERPItem result = new ERPItem();
            result.item_name = itemName;
            result.item_group = itemGroup;
            return result;
        }

        public string parent_warehouse
        {
            get { return data.parent_warehouse; }
            set { data.parent_warehouse = value; }
        }

        public string warehouse_name
        {
            get { return data.warehouse_name; }
            set { data.warehouse_name = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

    }
}
