using System;
using System.Runtime.Serialization;

namespace GizmoFort.Connector.ERPNext.PublicTypes
{
    [Serializable]
    public class ERPException : Exception
    {
        public ERPException()
        {
        }

        public ERPException(string message) : base(message)
        {
        }

        public ERPException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ERPException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}