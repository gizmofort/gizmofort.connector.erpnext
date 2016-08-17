using System.Dynamic;

namespace GizmoFort.Connector.ERPNext.PublicTypes
{
    public sealed class ERPObject
    {
        public DocType ObjectType { get; private set; }
        public dynamic Parameters { get; set; }

        public ERPObject(DocType objectType, dynamic parameters)
        {
            this.ObjectType = objectType;
            this.Parameters = parameters;
        }

        public ERPObject(DocType objectType) 
            : this(objectType, new ExpandoObject()) { }
    }
}