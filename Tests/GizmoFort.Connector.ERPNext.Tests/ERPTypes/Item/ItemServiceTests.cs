using GizmoFort.Connector.ERPNext.ERPTypes.Stock.Item;
using System;
using Xunit;

namespace GizmoFort.Connector.ERPNext.Tests.ERPTypes.Item
{

    public class ItemServiceTests
    {
        [Fact]
        public void ItemServiceTest()
        {
            var service_collection = TestUtils.CreateService();
            var item_service = service_collection.Stock_Item_Service;

            var item_code = Guid.NewGuid().ToString();

            var item = ERP_Stock_Item.CreateNew(item_code, "Hydration Water bag variant", "Products");

            var created_erp_item = item_service.Create(item);

            Assert.NotNull(created_erp_item);
            Assert.True(created_erp_item.ItemCode == item_code);
        }
    }
}