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
        protected readonly ERPNextClient _client;

        protected SubServiceBase(DocType objectType, ERPNextClient client)
        {
            ObjectType = objectType;
            _client = client;
        }

        public void Create(ERPCustomer newObject)
        {
            this._client.InsertObject(newObject.Object);
        }

        public T Get(string name)
        {
            ERPObject erp_object = this._client.GetObject(ObjectType, name);
            if (erp_object == null) return null;
            return fromERPObject(erp_object);
        }

        public List<string> ListNames(List<ERPFilter> filters = null)
        {
            FetchListOption listOption = new FetchListOption();
            listOption.Filters = filters;

            List<ERPObject> object_list = this._client.ListObjects(ObjectType, listOption);
            return object_list.Select(x => x.Name).ToList();
        }

        public void Update(ERPCustomer customer)
        {
            this._client.UpdateObject(ObjectType, customer.Name, customer.Object);
        }

        public void Delete(string name)
        {
            this._client.DeleteObject(ObjectType, name);
        }

        protected abstract T fromERPObject(ERPObject obj);
    }
}