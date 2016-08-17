using System.Collections.Generic;
using System.Dynamic;

namespace GizmoFort.Connector.ERPNext.Utils
{
    internal static class DynamicObjectUtils
    {
        public static ExpandoObject CloneObject(ExpandoObject source)
        {
            ExpandoObject target = new ExpandoObject();
            var target_iface = (IDictionary<string, object>)target;
            foreach (var kvp in (IDictionary<string, object>)source) {
                target_iface.Add(kvp);
            }

            return target;
        }
    }
}