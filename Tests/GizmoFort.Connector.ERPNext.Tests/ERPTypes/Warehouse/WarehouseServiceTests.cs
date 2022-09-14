using GizmoFort.Connector.ERPNext.Tests;
using Xunit;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Warehouse.Tests
{
    public class WarehouseServiceTests
    {
        [Fact]
        public void GetRootWarehousesTest()
        {
            var services = TestUtils.CreateService();
            var root_warehouses = services.Stock_Warehouse_Service.GetRootWarehouses();

            Assert.NotNull(root_warehouses);
            Assert.True(root_warehouses.Count > 0);
        }
    }
}