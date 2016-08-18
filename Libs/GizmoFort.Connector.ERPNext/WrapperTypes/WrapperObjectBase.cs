using System;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.Utils;

namespace GizmoFort.Connector.ERPNext.WrapperTypes
{
    public abstract class WrapperObjectBase
    {
        public ERPObject Object { get; private set; }

        protected WrapperObjectBase(ERPObject obj)
        {
            this.Object = obj;
        }

        protected dynamic data => Object.Data;

        protected static T parseEnum<T>(string enumString)
        {
            if (!typeof(T).IsEnum) {
                throw new ArgumentException("T must be an enum");
            }

            return (T)Enum.Parse(typeof(T), enumString, true);
        }
    }
}