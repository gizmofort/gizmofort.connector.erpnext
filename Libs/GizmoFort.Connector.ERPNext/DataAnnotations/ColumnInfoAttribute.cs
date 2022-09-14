using System;

namespace GizmoFort.Connector.ERPNext.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ColumnInfoAttribute : Attribute
    {
        public string ColumnName { get; private set; }
        public string ColumnType { get; private set; }
        public bool IsNullable { get; private set; }

        public string DataType
        {
            get
            {
                var index = ColumnType.IndexOf("(");
                if (index < 0)
                    return ColumnType;
                else
                    return ColumnType[..(index + 1)];
            }
        }

        public ColumnInfoAttribute(string columnName, string columnType, bool isNullable)
        {
            ColumnName = columnName;
            ColumnType = columnType;
            IsNullable = isNullable;
        }
    }
}
