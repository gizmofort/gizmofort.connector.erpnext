using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

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
