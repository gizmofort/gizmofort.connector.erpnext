using System;

namespace GizmoFort.Connector.ERPNext.PublicTypes
{
    public struct DocType
    {
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
            return String.Equals(Name, other.Name);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is DocType && Equals((DocType)obj);
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }

        #endregion

        public static readonly DocType Customer = new DocType("Customer");
        public static readonly DocType Item = new DocType("Item");
        public static readonly DocType StockLedgerEntry = new DocType("Stock Ledger Entry");
        public static readonly DocType User = new DocType("User");
        public static readonly DocType PurchaseInvoice = new DocType("Purchase Invoice");
        public static readonly DocType SalesInvoice = new DocType("Sales Invoice");
        public static readonly DocType SalesInvoicePayment = new DocType("Sales Invoice Payment");
        public static readonly DocType Warehouse = new DocType("Warehouse");
        public static readonly DocType PaymentEntry = new DocType("Payment Entry");


    }
}