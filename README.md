# gizmofort.connector.erpnext
Simple C# REST API Client for ERPNext


--------------
Features
--------------

* Easy to use API
* Auto-login
* Dynamic attributes allow to use whole erpnext system.
* WORK-IN-PROGRESS! HELP WANTED! - Implements ERP specific types such as ERPCustomer, ERPSalesInvoice, etc. See below for more details. If interested - PM me.

--------------
Recommended Installation
--------------

Use Nuget:

			Install-Package GizmoFort.Connector.ERPNext.dll

or git-clone, compile.
			
			
--------------
General Usage
--------------

            var client = new ERPNextClient("https://your.erpnext.com", "username", "password");

            var active_username = client.GetActiveUserName();

--------------
RPC - Remote Procedural Call
--------------

            // you can also pass parameters like this: 
			// dynamic data = client.RPC("yourMethod", Method.POST, new { arg1 = "val1", arg2 = "val2" });
            dynamic data = client.RPC("frappe.auth.get_logged_user", Method.GET);
            string active_username = data.message;

--------------
Inserting a Record
--------------
			
            ERPObject new_erp_object = new ERPObject(DocType.Customer);
            new_erp_object.Data.customer_type = "Individual";
            new_erp_object.Data.customer_name = "John Doe";
            new_erp_object.Data.customer_group = "Individual";
            new_erp_object.Data.website = "http://yourcustomerwebsite.com";
            new_erp_object.Data.territory = "Australia";

            client.InsertObject(new_erp_object);

			
--------------
Updating a Record
--------------

            ERPObject updated_data = new ERPObject(DocType.Customer);
            updated_data.Data.website = "http://new-website.com";
			
            client.UpdateObject(DocType.Customer, "John Doe", updated_data);

--------------
Getting a Record
--------------

            ERPObject customer_object = client.GetObject(DocType.Customer, "John Doe");
            string customer_website = customer_object.Data.website;

--------------
Listing Records
--------------
			
            FetchListOption listOption = new FetchListOption();
			
            // you can use filter
            listOption.Filters.Add(new ERPFilter(DocType.Customer, "name", OperatorFilter.Equals, "John Doe"));
			
            // by default, list only return field "name" only.
            // you can include specific fields in the listing operation by doing following:
            listOption.IncludedFields.AddRange(new string[] { "name", "website" });
			
            // You can also paginate listing result
            listOption.PageSize = 50;
            listOption.PageStartIndex = 20;
			
            // finally perform listing operation
            List<ERPObject> object_list = client.ListObjects(DocType.Customer, listOption);

--------------
Deleting a Record
--------------

            client.DeleteObject(DocType.Customer, "John Doe");

			
--------------
Strong typed ERPNext specific type - ERPCustomer has been partially implemented
--------------

            ERPNextServiceCollection service = new ERPNextServiceCollection("https://your.erpnext.com", "username", "password");
			
            CustomerService customer_service = service.Customer;

			// inserting data
            ERPCustomer initial_data = new ERPCustomer();
            initial_data.customer_type = CustomerType.Individual;
            initial_data.customer_name = "John Doe";
            initial_data.customer_group = "Individual";
            initial_data.website = "Customer Website";
            initial_data.territory = "Australia";
            customer_service.Create(initial_data);

			// getting data
            ERPCustomer erp_customer = customer_service.Get("John Doe");

			// updating
            ERPCustomer updated_customer = new ERPCustomer();
            updated_customer.Name = "John Doe";
            updated_customer.website = "http://new-website.com";
            customer_service.Update(updated_customer);

			// deleting
            customer_service.Delete("John Doe");
			
--------------
HELP WANTED! Implements other ERPNext specific types such as ERPSalesInvoice, ERPSupplier, etc
--------------

Step 1: Extends New_ERP_Object_Type from ERPNextObjectBase. For example,

    public class ERPCustomer : ERPNextObjectBase
    {
		// check model specification from https://frappe.github.io/erpnext/current/models/selling/customer
		// do it like this:

        public string customer_group
        {
            get { return data.customer_group; }
            set { data.customer_group = value; }
        }

        public string website
        {
            get { return data.website; }
            set { data.website = value; }
        }
		
        public CustomerStatus status
        {
            get { return parseEnum<CustomerType>(data.status); }
            set { data.status = value.ToString(); }
        }

		// so on
	}
	
Step 2: Extends New_ERP_Service from SubServiceBase<New_ERP_Object_Type>. For example,

    public class CustomerService : SubServiceBase<ERPCustomer>
    {
        public CustomerService(ERPNextClient client) : base(DocType.Customer, client)
        {
        }

        protected override ERPCustomer fromERPObject(ERPObject obj)
        {
            return new ERPCustomer(obj);
        }
    }

Step 3: Add your new service to class ERPNextServiceCollection.

    public class ERPNextServiceCollection
    {
        private readonly ERPNextClient _client;
        public CustomerService Customer { get; }
		
        public ERPNextServiceCollection(string domain, string username, string password)
        {
            this._client = new ERPNextClient(domain, username, password);
            this.Customer = new CustomerService(_client);
        }
	}

	
Done! There are about 200 different models needs to be done. PM me, if you are interested.