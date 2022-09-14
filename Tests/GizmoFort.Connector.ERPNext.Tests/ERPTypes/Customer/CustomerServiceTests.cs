using Xunit;
using System;
using System.Collections.Generic;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.Tests;
using GizmoFort.Connector.ERPNext.ERPTypes.Selling.Customer;

namespace GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices.Tests
{

    public class CustomerServiceTests
    {
        [Fact]
        public void CustomerServiceTest()
        {
            ERPNextServices services = TestUtils.CreateService();
            Selling_Customer_Service customer_service = services.Selling_Customer_Service;

            string test_name = Guid.NewGuid().ToString();
            string test_customer_website = Guid.NewGuid().ToString();

            ERP_Selling_Customer initial_data = ERP_Selling_Customer.CreateNew(test_name, ERP_Selling_Customer.CustomerTypeEnum.Individual, "Individual", "United States");
            initial_data.Website = test_customer_website;

            #region Test - Insert

            customer_service.Create(initial_data);

            #endregion

            #region Test - List

            var filters = new List<ERPFilter>
            {
                new ERPFilter(DocType.Selling_Customer, "name", OperatorFilter.Equals, test_name)
            };
            var list_result = customer_service.ListNames(filters);

            Assert.NotNull(list_result);
            Assert.True(list_result.Count == 1, "Customer result is not one");
            Assert.True(list_result[0] == test_name, "Customer name is invalid");

            #endregion

            #region Test - Get

            ERP_Selling_Customer? erp_customer = customer_service.Get(test_name);
            Assert.NotNull(erp_customer);
            Assert.True(erp_customer.Name == test_name, "Customer name is invalid");
            Assert.True(erp_customer.Website == test_customer_website, "Customer website is invalid");

            #endregion

            #region Test - Update

            // create update data
            var updated_customer = new ERP_Selling_Customer
            {
                Name = test_name,
                Website = Guid.NewGuid().ToString()
            };

            //
            //
            //
            updated_customer = erp_customer;
            string date = updated_customer.Object.Data.creation;
            string date2 = date.Replace(" ", "T") + "+00:00";
            DateTimeOffset date3 = DateTimeOffset.Parse(date2);
            updated_customer.Creation = date3;
            updated_customer.Modified = date3;
            updated_customer.Website = Guid.NewGuid().ToString();
            string date4 = updated_customer.Object.Data.creation;
            //
            //
            //

            // update first
            customer_service.Update(updated_customer);

            // get a new instance - after update
            var remote_updated_customer = customer_service.Get(test_name);

            // test
            Assert.NotNull(remote_updated_customer);
            Assert.True(remote_updated_customer.Website == updated_customer.Website, "Customer website is invalid - after update");
            Assert.True(remote_updated_customer.Territory == initial_data.Territory, "Customer territory is invalid - after update");

            #endregion

            #region Test - Delete

            customer_service.Delete(test_name);

            var filters1 = new List<ERPFilter>
            {
                new ERPFilter(DocType.Selling_Customer, "name", OperatorFilter.Equals, test_name)
            };
            var after_delete_result_list = customer_service.ListNames(filters1);

            Assert.NotNull(after_delete_result_list);
            Assert.True(after_delete_result_list.Count == 0, "Failed to delete customer");

            ERP_Selling_Customer? customer_after_delete = customer_service.Get(test_name);
            Assert.True(customer_after_delete == null, "Customer is not null");


            #endregion
        }
    }
}