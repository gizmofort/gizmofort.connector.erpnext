using System.Collections.Generic;
using System.Linq;
using GizmoFort.Connector.ERPNext.ERPTypes.Customer;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;

namespace GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices
{
    public abstract class SubServiceBase<T> : ISubServiceBase<T> where T : ERPNextObjectBase
    {
        public DocType ObjectType { get; }
        protected readonly ERPNextClient client;

        protected SubServiceBase(DocType objectType, ERPNextClient client)
        {
            ObjectType = objectType;
            this.client = client;
        }

        public T Create(T obj)
        {
            ERPObject result = this.client.InsertObject(obj.Object);
            return fromERPObject(result);
        }

        public T Get(string name)
        {
            ERPObject erp_object = this.client.GetObject(ObjectType, name);
            if (erp_object == null) return null;
            return fromERPObject(erp_object);
        }

        public List<string> ListNames(List<ERPFilter> filters = null, int pageSize = 0, int pageStartIndex = 0)
        {
            FetchListOption listOption = new FetchListOption();
            listOption.Filters = filters;
            listOption.PageSize = 0;
            listOption.PageStartIndex = 0;

            List<ERPObject> object_list = this.client.ListObjects(ObjectType, listOption);
            return object_list.Select(x => x.Name).ToList();
        }

        public List<ERPObject> ListObjects(FetchListOption listOption)
        {
            return this.client.ListObjects(ObjectType, listOption);
        }

        public void Update(T obj)
        {
            this.client.UpdateObject(ObjectType, obj.name, obj.Object);
        }

        public void Delete(string name)
        {
            this.client.DeleteObject(ObjectType, name);
        }

        protected abstract T fromERPObject(ERPObject obj);
    }
}