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
        public void Login()
        {
            var client = TestConstants.CreateClient();
            client.Login(TestConstants.TEST_USERNAME, TestConstants.TEST_PASSWORD);

            var active_username = client.GetActiveUserName();
            Assert.IsTrue(active_username == TestConstants.TEST_USERNAME);
        }

        [TestMethod()]
        public void CustomerFull()
        {
            var client = TestConstants.CreateClient();
            client.Login(TestConstants.TEST_USERNAME, TestConstants.TEST_PASSWORD);

            string test_customer_name = Guid.NewGuid().ToString();
            string test_customer_website = Guid.NewGuid().ToString();

            ERPCustomer insert_data = new ERPCustomer();
            insert_data.customer_type = CustomerType.Individual;
            insert_data.customer_name = test_customer_name;
            insert_data.customer_group = "Individual";
            insert_data.website = test_customer_website;
            insert_data.territory = "Australia";

            client.InsertObject(insert_data.Object);

            FetchListOption listOption = new FetchListOption();
            listOption.Filters.Add(new ERPFilter(DocType.Customer, "name", OperatorFilter.Equals, test_customer_name));
            listOption.IncludedFields.AddRange(new string[] { "name", "website" });
            var documents = client.ListObjects(DocType.Customer, listOption);

            Assert.IsTrue(documents.Count == 1, "Customer result is not one");
            Assert.IsTrue(documents[0].Parameters.name == test_customer_name, "Customer name is invalid");
            Assert.IsTrue(documents[0].Parameters.website == test_customer_website, "Customer website is invalid");

            var full_customer_object = client.GetObject(DocType.Customer, test_customer_name);
            Assert.IsTrue(full_customer_object.Parameters.name == test_customer_name, "Customer name is invalid");
            Assert.IsTrue(full_customer_object.Parameters.website == test_customer_website, "Customer website is invalid");

            ERPCustomer customer = new ERPCustomer(full_customer_object);
            Assert.IsTrue(customer.customer_name == test_customer_name, "Customer name is invalid");
            Assert.IsTrue(customer.website == test_customer_website, "Customer website is invalid");
            Assert.IsTrue(customer.status == CustomerStatus.Active, "Customer website is invalid");

            client.DeleteObject(DocType.Customer, test_customer_name);

            FetchListOption option = new FetchListOption();
            option.Filters.Add(new ERPFilter(DocType.Customer, nameof(ERPCustomer.customer_name), OperatorFilter.Equals, test_customer_name));
            var after_delete_result = client.ListObjects(DocType.Customer, option);
            Assert.IsTrue(after_delete_result.Count == 0, "Failed to delete customer");
        }
    }
}