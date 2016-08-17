using System;

namespace GizmoFort.Connector.ERPNext.Utils
{
    internal static class EnumUtils
    {
        public static T Parse<T>(string enumString)
        {
            return (T) Enum.Parse(typeof(T), enumString, true);
        }
    }
}