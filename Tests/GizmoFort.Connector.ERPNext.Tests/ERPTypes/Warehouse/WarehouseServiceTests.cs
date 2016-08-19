using Microsoft.VisualStudio.TestTools.UnitTesting;
using GizmoFort.Connector.ERPNext.ERPTypes.Warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GizmoFort.Connector.ERPNext.Tests;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Warehouse.Tests
{
    [TestClass()]
    public class WarehouseServiceTests
    {
        [TestMethod()]
        public void GetRootWarehousesTest()
        {
            var services = TestUtils.CreateService();
            var root_warehouses = services.WarehouseService.GetRootWarehouses();

            Assert.IsTrue(root_warehouses.Count > 0);
        }
    }
}