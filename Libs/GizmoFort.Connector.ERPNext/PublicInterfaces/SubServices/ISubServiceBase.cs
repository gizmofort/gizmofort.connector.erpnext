using System.Collections.Generic;
using GizmoFort.Connector.ERPNext.ERPTypes.Customer;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;

namespace GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices
{
    public interface ISubServiceBase<T> where T : ERPNextObjectBase
    {
        DocType ObjectType { get; }
        void Create(ERPCustomer newObject);
        T Get(string name);
        List<string> ListNames(List<ERPFilter> filters);
        void Update(ERPCustomer customer);
        void Delete(string name);
    }
}