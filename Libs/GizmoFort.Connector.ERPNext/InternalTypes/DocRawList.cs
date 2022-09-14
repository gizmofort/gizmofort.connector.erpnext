using System.Collections.Generic;

namespace GizmoFort.Connector.ERPNext.InternalTypes
{
    internal class DocRawList
    {
#pragma warning disable IDE1006 // Naming Styles
        public List<Dictionary<string, object?>> data { get; set; } = null!;
#pragma warning restore IDE1006 // Naming Styles
    }

    internal class DocRaw
    {
#pragma warning disable IDE1006 // Naming Styles
        public Dictionary<string, object?> data { get; set; } = null!;
#pragma warning restore IDE1006 // Naming Styles
    }

}