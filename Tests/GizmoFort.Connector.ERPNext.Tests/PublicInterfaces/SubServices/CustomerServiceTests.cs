using Microsoft.VisualStudio.TestTools.UnitTesting;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GizmoFort.Connector.ERPNext.ERPTypes.Customer;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.Tests;
using GizmoFort.Connector.ERPNext.WrapperTypes;

namespace GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices.Tests
{
    [TestClass()]
    public class CustomerServiceTests
    {
        [TestMethod()]
        public void CustomerServiceTest()
        {
            ERPNextServiceCollection serviceCollection = TestUtils.CreateService();
            CustomerService customer_service = serviceCollection.Customer;

            string test_customer_name = Guid.NewGuid().ToString();
            string test_customer_website = Guid.NewGuid().ToString();

            ERPCustomer initial_data = new ERPCustomer();
            initial_data.customer_type = CustomerType.Individual;
            initial_data.customer_name = test_customer_name;
            initial_data.customer_group = "Individual";
            initial_data.website = test_customer_website;
            initial_data.territory = "Australia";

            #region Test - Insert

            customer_service.Create(initial_data);

            #endregion

            #region Test - List

            List<ERPFilter> filters = new List<ERPFilter>();
            filters.Add(new ERPFilter(DocType.Customer, "name", OperatorFilter.Equals, test_customer_name));
            var list_result = customer_service.ListNames(filters);

            Assert.IsTrue(list_result.Count == 1, "Customer result is not one");
            Assert.IsTrue(list_result[0] == test_customer_name, "Customer name is invalid");

            #endregion

            #region Test - Get

            ERPCustomer erp_customer = customer_service.Get(test_customer_name);
            Assert.IsTrue(erp_customer.Name == test_customer_name, "Customer name is invalid");
            Assert.IsTrue(erp_customer.website == test_customer_website, "Customer website is invalid");

            #endregion

            #region Test - Update

            // create update data
            ERPCustomer updated_customer = new ERPCustomer();
            updated_customer.Name = test_customer_name;
            updated_customer.website = Guid.NewGuid().ToString();

            // update first
            customer_service.Update(updated_customer);

            // get a new instance - after update
            var remote_updated_customer = customer_service.Get(test_customer_name);

            // test
            Assert.IsTrue(remote_updated_customer.website == updated_customer.website, "Customer website is invalid - after update");
            Assert.IsTrue(remote_updated_customer.territory == initial_data.territory, "Customer territory is invalid - after update");

            #endregion

            #region Test - Delete

            customer_service.Delete(test_customer_name);

            List<ERPFilter> filters1 = new List<ERPFilter>();
            filters1.Add(new ERPFilter(DocType.Customer, "name", OperatorFilter.Equals, test_customer_name));
            var after_delete_result_list = customer_service.ListNames(filters1);
            Assert.IsTrue(after_delete_result_list.Count == 0, "Failed to delete customer");

            ERPCustomer customer_after_delete = customer_service.Get(test_customer_name);
            Assert.IsTrue(customer_after_delete == null, "Customer is not null");


            #endregion
        }
    }
}