using System;
using GizmoFort.Connector.ERPNext.ERPTypes.Item;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GizmoFort.Connector.ERPNext.Tests.ERPTypes.Item
{
    [TestClass()]
    public class ItemServiceTests
    {
        [TestMethod()]
        public void ItemServiceTest()
        {
            var service_collection = TestUtils.CreateService();
            var item_service = service_collection.ItemService;

            var item_code = Guid.NewGuid().ToString();

            var item = ERPItem.Create(item_code, "Hydration Water bag variant", "Products");

            var created_erp_item = item_service.Create(item);

            Assert.IsTrue(created_erp_item.item_code == item_code);
        }
    }
}