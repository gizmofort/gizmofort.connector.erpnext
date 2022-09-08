using System.Collections.Generic;

namespace GizmoFort.Connector.ERPNext.PublicTypes
{
    public class FetchListOption
    {
        public List<ERPFilter> Filters { get; private set; }
        public List<string> IncludedFields { get; private set; }
        public int PageSize { get; private set; }
        public int PageStartIndex { get; private set; }

        public FetchListOption()
        {
            Filters = new List<ERPFilter>();
            IncludedFields = new List<string>();
        }

        public void ClearFilters()
        {
            Filters = new List<ERPFilter>();
        }

        public void SetFilters(List<ERPFilter> filters)
        {
            Filters = filters;
        }

        public void SetPagination(int pageSize, int pageStartIndex)
        {
            PageSize = pageSize;
            PageStartIndex = pageStartIndex;
        }

    }
}