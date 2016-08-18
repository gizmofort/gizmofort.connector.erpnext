using System;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.Utils;

namespace GizmoFort.Connector.ERPNext.WrapperTypes
{
    public abstract class ERPNextObjectBase
    {
        public ERPObject Object { get; internal set; }

        internal ERPNextObjectBase()
        {
        }

        protected ERPNextObjectBase(ERPObject obj)
        {
            this.Object = obj;
        }

        protected dynamic data => Object.Data;

        public string Name
        {
            get { return Object.Name; }
            set { Object.Name = value; }
        }

        public DocType ObjectType => Object.ObjectType;

        protected static T parseEnum<T>(string enumString)
        {
            if (!typeof(T).IsEnum) {
                throw new ArgumentException("T must be an enum");
            }

            return (T)Enum.Parse(typeof(T), enumString, true);
        }
    }
}