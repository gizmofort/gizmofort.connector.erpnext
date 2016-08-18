using System.Dynamic;
using GizmoFort.Connector.ERPNext.Utils;

namespace GizmoFort.Connector.ERPNext.PublicTypes
{
    public sealed class ERPObject
    {
        public DocType ObjectType { get; private set; }
        private ExpandoObject data;

        public ERPObject(DocType objectType) 
            : this(objectType, new ExpandoObject()) { }

        public ERPObject(DocType objectType, ExpandoObject data)
        {
            this.ObjectType = objectType;
            this.data = data ?? new ExpandoObject();
        }

        public dynamic Data
        {
            get { return data; }
            set { data = value; }
        }

        public string Name
        {
            get { return Data.name; }
            set { Data.name = value; }
        }

        public ERPObject Clone()
        {
            ERPObject result = (ERPObject)MemberwiseClone();
            result.data = DynamicObjectUtils.CloneObject(data);

            return result;
        }
    }
}