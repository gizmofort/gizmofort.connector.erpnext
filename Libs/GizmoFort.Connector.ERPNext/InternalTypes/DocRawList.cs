using System.Collections.Generic;

namespace GizmoFort.Connector.ERPNext.InternalTypes
{
    internal class DocRawList
    {
        public List<Dictionary<string, object?>> data { get; set; } = null!;
    }

    internal class DocRaw
    {
        public Dictionary<string, object?> data { get; set; } = null!;
    }

}