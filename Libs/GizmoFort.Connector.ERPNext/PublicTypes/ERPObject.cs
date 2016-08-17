using System.Dynamic;

namespace GizmoFort.Connector.ERPNext.PublicTypes
{
    public class ERPObject
    {
        public DocType ObjectType { get; private set; }
        public dynamic Data { get; set; }

        public ERPObject(DocType objectType, dynamic data)
        {
            this.ObjectType = objectType;
            this.Data = data;
        }

        public ERPObject(DocType objectType) 
            : this(objectType, new ExpandoObject()) { }
    }
}