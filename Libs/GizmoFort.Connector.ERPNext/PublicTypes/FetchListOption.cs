using System.Collections.Generic;

namespace GizmoFort.Connector.ERPNext.PublicTypes
{
    public class FetchListOption
    {
        public List<ERPFilter> Filters { get; set; } = new List<ERPFilter>();

        public List<string> IncludedFields = new List<string>();

        public int PageSize { get; set; }
        public int PageStartIndex { get; set; }
    }
}