using System;
using GizmoFort.Connector.ERPNext.ERPTypes.Selling.Customer;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.Serialization;
using Xunit;

namespace GizmoFort.Connector.ERPNext.Tests.TestCases
{
    public class CustomerTests
    {
        [Fact()]
        public void CustomerFull()
        {
            var client = TestUtils.CreateClient();

            string test_customer_name = Guid.NewGuid().ToString();
            string test_customer_website = Guid.NewGuid().ToString();

            var initial_data = new ERP_Selling_Customer
            {
                CustomerTypeViaEnum = ERP_Selling_Customer.CustomerTypeEnum.Individual,
                CustomerName = test_customer_name,
                CustomerGroup = "Individual",
                Website = test_customer_website,
                Territory = "United States"
            };

            #region Test - Insert

            client.InsertObject(initial_data.Object);

            #endregion

            #region Test - List

            var listOption = new FetchListOption();
            listOption.Filters.Add(new ERPFilter(DocType.Selling_Customer, "name", OperatorFilter.Equals, test_customer_name));
            listOption.IncludedFields.AddRange(new string[] {"name", "website"});
            var documents = client.ListObjects(DocType.Selling_Customer, listOption);

            Assert.NotNull(documents);
            Assert.True(documents.Count == 1, "Customer result is not one");
            Assert.True(documents[0].Data.name == test_customer_name, "Customer name is invalid");
            Assert.True(documents[0].Data.website == test_customer_website, "Customer website is invalid");

            #endregion

            #region Test - Get

            var full_customer_object = client.GetObject(DocType.Selling_Customer, test_customer_name);

            Assert.NotNull(full_customer_object);
            Assert.True(full_customer_object.Data.name == test_customer_name, "Customer name is invalid");
            Assert.True(full_customer_object.Data.website == test_customer_website, "Customer website is invalid");

            #endregion

            #region Test - Wrapper

            var customer = new ERP_Selling_Customer(full_customer_object);
            Assert.True(customer.CustomerName == test_customer_name, "Customer name is invalid");
            Assert.True(customer.Website == test_customer_website, "Customer website is invalid");
            //Assert.True(customer.status == CustomerStatus.Active, "Customer website is invalid");

            #endregion

            #region Test - Update

            var updated_obj = new ERPObject(DocType.Selling_Customer);
            updated_obj.Data.website = Guid.NewGuid().ToString();

            // update first
            client.UpdateObject(DocType.Selling_Customer, test_customer_name, updated_obj);

            // get a new instance - after update
            var remote_updated_customer = client.GetObject(DocType.Selling_Customer, test_customer_name);

            // test
            Assert.NotNull(remote_updated_customer);
            Assert.True(remote_updated_customer.Data.website == updated_obj.Data.website, "Customer website is invalid - after update");
            Assert.True(remote_updated_customer.Data.territory == initial_data.Territory, "Customer territory is invalid - after update");

            #endregion


            #region Test - Delete

            client.DeleteObject(DocType.Selling_Customer, test_customer_name);

            var option = new FetchListOption();
            var columnInfo = ERPNextConverter.GetColumnInfoByPropertyName<ERP_Selling_Customer>(nameof(ERP_Selling_Customer.CustomerName));
            option.Filters.Add(new ERPFilter(DocType.Selling_Customer,
                                             columnInfo?.ColumnName!,
                                             OperatorFilter.Equals,
                                             test_customer_name));

            var after_delete_result = client.ListObjects(DocType.Selling_Customer, option);
            
            Assert.NotNull(after_delete_result);
            Assert.True(after_delete_result.Count == 0, "Failed to delete customer");

            #endregion
        }
    }
}