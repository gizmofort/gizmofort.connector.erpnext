using System;
using System.Collections.Generic;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GizmoFort.Connector.ERPNext.Tests.TestCases
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        public void CustomerFull()
        {
            var client = TestUtils.CreateClient();

            string test_customer_name = Guid.NewGuid().ToString();
            string test_customer_website = Guid.NewGuid().ToString();

            ERPCustomer initial_data = new ERPCustomer();
            initial_data.customer_type = CustomerType.Individual;
            initial_data.customer_name = test_customer_name;
            initial_data.customer_group = "Individual";
            initial_data.website = test_customer_website;
            initial_data.territory = "Australia";

            #region Test - Insert

            client.InsertObject(initial_data.Object);

            #endregion

            #region Test - List

            FetchListOption listOption = new FetchListOption();
            listOption.Filters.Add(new ERPFilter(DocType.Customer, "name", OperatorFilter.Equals, test_customer_name));
            listOption.IncludedFields.AddRange(new string[] {"name", "website"});
            var documents = client.ListObjects(DocType.Customer, listOption);

            Assert.IsTrue(documents.Count == 1, "Customer result is not one");
            Assert.IsTrue(documents[0].Data.name == test_customer_name, "Customer name is invalid");
            Assert.IsTrue(documents[0].Data.website == test_customer_website, "Customer website is invalid");

            #endregion

            #region Test - Get

            var full_customer_object = client.GetObject(DocType.Customer, test_customer_name);
            Assert.IsTrue(full_customer_object.Data.name == test_customer_name, "Customer name is invalid");
            Assert.IsTrue(full_customer_object.Data.website == test_customer_website, "Customer website is invalid");

            #endregion

            #region Test - Wrapper

            ERPCustomer customer = new ERPCustomer(full_customer_object);
            Assert.IsTrue(customer.customer_name == test_customer_name, "Customer name is invalid");
            Assert.IsTrue(customer.website == test_customer_website, "Customer website is invalid");
            Assert.IsTrue(customer.status == CustomerStatus.Active, "Customer website is invalid");

            #endregion

            #region Test - Update

            ERPObject updated_obj = new ERPObject(DocType.Customer);
            updated_obj.Data.website = Guid.NewGuid().ToString();

            // update first
            client.UpdateObject(DocType.Customer, test_customer_name, updated_obj);

            // get a new instance - after update
            var remote_updated_customer = client.GetObject(DocType.Customer, test_customer_name);

            // test
            Assert.IsTrue(remote_updated_customer.Data.website == updated_obj.Data.website, "Customer website is invalid - after update");
            Assert.IsTrue(remote_updated_customer.Data.territory == initial_data.territory, "Customer territory is invalid - after update");

            #endregion


            #region Test - Delete

            client.DeleteObject(DocType.Customer, test_customer_name);

            FetchListOption option = new FetchListOption();
            option.Filters.Add(new ERPFilter(DocType.Customer, nameof(ERPCustomer.customer_name), OperatorFilter.Equals,
                test_customer_name));
            var after_delete_result = client.ListObjects(DocType.Customer, option);
            Assert.IsTrue(after_delete_result.Count == 0, "Failed to delete customer");

            #endregion
        }
    }
}