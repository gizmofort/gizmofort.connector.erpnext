using RestSharp.Serializers;

namespace GizmoFort.Connector.ERPNext.Utils
{
    internal static class SerializeUtils
    {
        public static string ToString(object obj)
        {
            JsonSerializer s = new JsonSerializer();
            return s.Serialize(obj);
        }
    }
}