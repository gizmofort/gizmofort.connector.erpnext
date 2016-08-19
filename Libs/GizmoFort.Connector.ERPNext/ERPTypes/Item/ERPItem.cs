using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Item
{
    /// <summary>
    /// Reference: https://frappe.github.io/erpnext/current/models/stock/item
    /// </summary>
    public class ERPItem : ERPNextObjectBase
    {
        public ERPItem() : this(new ERPObject(DocType.Item)) { }
        public ERPItem(ERPObject obj) : base(obj) { }

        public static ERPItem Create(string itemCode, string itemName, string itemGroup)
        {
            ERPItem result = new ERPItem();
            result.item_code = itemCode;
            result.item_name = itemName;
            result.item_group = itemGroup;
            return result;
        }

        public string item_code
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public string item_group
        {
            get { return data.item_group; }
            set { data.item_group = value; }
        }

        public double total_projected_qty
        {
            get { return data.total_projected_qty; }
            set { data.total_projected_qty = value; }
        }

        public double last_purchase_rate
        {
            get { return data.last_purchase_rate; }
            set { data.last_purchase_rate = value; }
        }
    }
}