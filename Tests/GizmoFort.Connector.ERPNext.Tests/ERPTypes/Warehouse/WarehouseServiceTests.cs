using GizmoFort.Connector.ERPNext.ERPTypes.Warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var root_warehouses = services.WarehouseService.GetRootWarehouses();

            Assert.NotNull(root_warehouses);
            Assert.True(root_warehouses.Count > 0);
        }
    }
}