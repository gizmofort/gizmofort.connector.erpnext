# gizmofort.connector.erpnext
Simple C# REST API Client for ERPNext


--------------
Features
--------------

* Easy to use API
* Auto-login
* Dynamic attributes allow to use whole erpnext system.

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

			