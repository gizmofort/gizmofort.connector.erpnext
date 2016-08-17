using System;

namespace GizmoFort.Connector.ERPNext.PublicTypes
{
    public struct DocType
    {
        public static readonly DocType Customer = new DocType("Customer");

        #region Internal

        public string Name { get; }

        public DocType(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        #endregion

        #region Equality implementation

        public static bool operator==(DocType a, DocType b)
        {
            return Equals(a, b);
        }

        public static bool operator !=(DocType a, DocType b)
        {
            return !(a == b);
        }

        public bool Equals(DocType other)
        {
            return string.Equals(Name, other.Name);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is DocType && Equals((DocType)obj);
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }

        #endregion
    }
}