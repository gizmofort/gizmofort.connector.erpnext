using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.WrapperTypes
{
    public abstract class WrapperObjectBase
    {
        public ERPObject Object { get; private set; }

        protected WrapperObjectBase(ERPObject obj)
        {
            this.Object = obj;
        }

        protected dynamic parameters => Object.Parameters;
    }
}