using System;

namespace GizmoFort.Connector.ERPNext.PublicTypes
{
    public class ERPFilter
    {
        public DocType DocType { get; set; }
        public string TargetField { get; set; }
        public OperatorFilter OperatorFilter { get; set; }
        public string Operand { get; set; }

        public ERPFilter(DocType docType, string targetField, OperatorFilter @operator, string operand)
        {
            DocType = docType;
            TargetField = targetField;
            Operand = operand;
            OperatorFilter = @operator;
        }
    }

    public enum OperatorFilter
    {
        Equals,
        NotEquals,
        GreaterThan,
        LessThan,
        GreaterThanOrEqual,
        LessThanOrEqual,
    }

    internal class OperatorFilterUtils
    {
        internal static string ToString(OperatorFilter opFilter) {
            switch (opFilter)
            {
                case OperatorFilter.Equals:
                    return "=";
                case OperatorFilter.NotEquals:
                    return "!=";
                case OperatorFilter.GreaterThan:
                    return ">";
                case OperatorFilter.LessThan:
                    return "<";
                case OperatorFilter.GreaterThanOrEqual:
                    return ">=";
                case OperatorFilter.LessThanOrEqual:
                    return "<=";
                default:
                    throw new ArgumentOutOfRangeException(nameof(opFilter), opFilter, null);
            }
        }
    }
}