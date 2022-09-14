using System.Collections.Generic;
using System.Dynamic;
using GizmoFort.Connector.ERPNext.Utils;

namespace GizmoFort.Connector.ERPNext.PublicTypes
{
    public sealed class ERPObject
    {
        public DocType ObjectType { get; private set; }
        private ExpandoObject _data;

        public ERPObject(DocType objectType) 
            : this(objectType, new ExpandoObject()) { }

        public ERPObject(DocType objectType, ExpandoObject data)
        {
            this.ObjectType = objectType;
            this._data = data ?? new ExpandoObject();
        }

        public dynamic Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public string Name
        {
            get { return Data.name; }
            set { Data.name = value; }
        }

        public bool TryGetValue(string propertyName, out object? val)
        {
            var dict = (IDictionary<string, object?>)_data;
            return dict.TryGetValue(propertyName, out val);
        }

        public object? GetValue(string propertyName)
        {
            var dict = (IDictionary<string, object?>)_data;
            return dict[propertyName];
        }

        public ERPObject Clone()
        {
            ERPObject result = (ERPObject)MemberwiseClone();
            result._data = DynamicObjectUtils.CloneObject(_data);

            return result;
        }
    }
}