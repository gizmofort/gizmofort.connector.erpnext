using GizmoFort.Connector.ERPNext.DataAnnotations;
using GizmoFort.Connector.ERPNext.ERPTypes.Selling.Customer;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.Serialization;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Xunit.Extensions;
using Xunit.Sdk;
using GizmoFort.Connector.ERPNext.ERPTypes.UnitTestingOnly.TestType;
using System.Dynamic;
using GizmoFort.Connector.ERPNext.PublicInterfaces;

namespace GizmoFort.Connector.ERPNext.Tests.TestCases
{
    public class SerializationTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public SerializationTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void PropertyInternalSetterTesting()
        {
            // Arrange

            var refDateTime = DateTimeOffset.Parse("2022-09-12T14:46:12.8456195Z");

            var t = new ERP_UnitTestingOnly_TestType();
            t.Name = "Test Class Name";
            t.Flag = true;
            t.IntWidthEight = 12345678;
            t.IntWidthEleven = int.MinValue;
            t.NullableIntWidthEleven = int.MinValue;
            t.BigintWidth20 = long.MinValue;
            t.NullableDate = DateOnly.FromDateTime(refDateTime.UtcDateTime);
            t.NullableDatetimeWidthSix = refDateTime.UtcDateTime;
            t.NullableTimeWidthSix = refDateTime.UtcDateTime.TimeOfDay;
            t.DecimalTwentyoneByNine = 123456789012.123456789m; //ref: https://stackoverflow.com/a/3271831/2758185
            t.NullableDecimalTwentyoneByNine = 210987654321.987654321m; //ref: https://stackoverflow.com/a/3271831/2758185
            t.NullableDecimalThreeByTwo = 1.23m;
            t.NullableLongtext = "long text";
            t._NullableTextUnderscore = "just text";
            t.NullableVarcharWidthFour = "1234";
            t.NulableVarcharWidthNineNineFive = "text that is not 995 characters long";
            t.VarcharWidthOneFourZero = "text that is not 140 characters long";
            t.VarcharWidthTwoFiveFive = "text that is not 255 characters long";

            // Act

            var actual = JsonSerializer.Serialize(t.Object.Data);

            // Assert 

            var expected = @"{""name"":""Test Class Name"",""flag"":1,""int_width_eight"":12345678,""int_width_eleven"":-2147483648,""nullable_int_width_eleven"":-2147483648,""bigint_width_20"":-9223372036854775808,""nullable_date"":""2022-09-12"",""nullable_datetime_width_six"":""2022-09-12 14:46:12.845619"",""nullable_time_width_six"":""14:46:12.845619"",""decimal_twentyone_by_nine"":123456789012.123456789,""nullable_decimal_twentyone_by_nine"":210987654321.987654321,""nullable_decimal_three_by_two"":1.23,""nullable_longtext"":""long text"",""_nullable_text_underscore"":""just text"",""nullable_varchar_width_four"":""1234"",""nulable_varchar_width_nine_nine_five"":""text that is not 995 characters long"",""varchar_width_one_four_zero"":""text that is not 140 characters long"",""varchar_width_two_five_five"":""text that is not 255 characters long""}";
            Assert.Equal(expected, actual);

        }

        private class DocRaw
        {
#pragma warning disable IDE1006 // Naming Styles
            public Dictionary<string, object?> data { get; set; } = null!;
#pragma warning restore IDE1006 // Naming Styles
        }

        private static ExpandoObject ConvertToData(IDictionary<string, object?> vals)
        {
            var result = new ExpandoObject();

            var resultViaIDictionary = (IDictionary<string, object?>)result;

            foreach (var pair in vals)
            {
                object? value;

                if (pair.Value is JsonElement)
                    value = ERPNextClient.JsonElementValue((JsonElement)pair.Value);
                else
                    value = pair.Value;

                if (value is IDictionary<string, object?>)
                    value = ConvertToData((IDictionary<string, object?>)value);

                resultViaIDictionary[pair.Key] = value;
            }

            return result;
        }

        [Fact]
        public void PropertyInternalGetterTesting()
        {
            // Arrange

            //var refDateTime = DateTimeOffset.Parse("2022-09-12T14:46:12.8456195Z");
            var refDateTimeWidthSix = DateTimeOffset.Parse("2022-09-12T14:46:12.845619Z");

            var content = @"{""name"":""Test Class Name"",""flag"":1,""int_width_eight"":12345678,""int_width_eleven"":-2147483648,""nullable_int_width_eleven"":-2147483648,""bigint_width_20"":-9223372036854775808,""nullable_date"":""2022-09-12"",""nullable_datetime_width_six"":""2022-09-12 14:46:12.845619"",""nullable_time_width_six"":""14:46:12.845619"",""decimal_twentyone_by_nine"":123456789012.123456789,""nullable_decimal_twentyone_by_nine"":210987654321.987654321,""nullable_decimal_three_by_two"":1.23,""nullable_longtext"":""long text"",""_nullable_text_underscore"":""just text"",""nullable_varchar_width_four"":""1234"",""nulable_varchar_width_nine_nine_five"":""text that is not 995 characters long"",""varchar_width_one_four_zero"":""text that is not 140 characters long"",""varchar_width_two_five_five"":""text that is not 255 characters long""}";

            // Act

            DocRaw data_json = JsonSerializer.Deserialize<DocRaw>($"{{\"data\":{content}}}")!;
            var obj = new ERPObject(DocType.Accounts_Account /* dummy value */, ConvertToData(data_json.data));
            var t = new ERP_UnitTestingOnly_TestType(obj);

            // Assert 

            Assert.Equal("Test Class Name", t.Name);
            Assert.True(t.Flag);
            Assert.Equal(12345678, t.IntWidthEight);
            Assert.Equal(int.MinValue, t.IntWidthEleven);
            Assert.Equal(int.MinValue, t.NullableIntWidthEleven);
            Assert.Equal(long.MinValue, t.BigintWidth20);
            Assert.Equal(DateOnly.FromDateTime(refDateTimeWidthSix.UtcDateTime), t.NullableDate);
            Assert.Equal(refDateTimeWidthSix.UtcDateTime, t.NullableDatetimeWidthSix);
            Assert.Equal(refDateTimeWidthSix.UtcDateTime.TimeOfDay, t.NullableTimeWidthSix);
            Assert.Equal(123456789012.123456789m, t.DecimalTwentyoneByNine);  //ref: https://stackoverflow.com/a/3271831/2758185
            Assert.Equal(210987654321.987654321m, t.NullableDecimalTwentyoneByNine);  //ref: https://stackoverflow.com/a/3271831/2758185
            Assert.Equal(1.23m, t.NullableDecimalThreeByTwo);
            Assert.Equal("long text", t.NullableLongtext);
            Assert.Equal("just text", t._NullableTextUnderscore);
            Assert.Equal("1234", t.NullableVarcharWidthFour);
            Assert.Equal("text that is not 995 characters long", t.NulableVarcharWidthNineNineFive);
            Assert.Equal("text that is not 140 characters long", t.VarcharWidthOneFourZero);
            Assert.Equal("text that is not 255 characters long", t.VarcharWidthTwoFiveFive);


        }



        [Fact]
        public void SellingCustomerSerializationTest()
        {
            // Arrange

            var customer = new ERP_Selling_Customer();
            customer.Name = "Generic Test Customer";
            customer.Owner = "admin@my.erpnext.com";
            customer.Creation = DateTime.Parse("2022-09-12T14:46:12.845619Z");
            customer.Disabled = false;
            customer.IsFrozen = true;
            customer.Language = "en-US";
            customer.Modified = DateTime.Parse("2022-09-12T14:46:12.845619Z");
            customer.Docstatus = Docstatus.Cancelled;
            customer.Territory = "United States";
            customer.DnRequired = true;
            customer.ModifiedBy = "admin@my.erpnext.com";
            customer.SoRequired = true;
            customer.CustomerName = "Generic Test Customer";
            customer.CustomerType = "Company";
            customer.NamingSeries = "CUST-.YYYY.-";
            customer.CustomerGroup = "Individual";
            customer.ExemptFromSalesTax = false;
            customer.DefaultCommissionRate = 0;

            // Act

            var actual = ERPNextObjectBase.Serialize(customer)!;

            // Assert 

            var expected = "{\"Name\":\"Generic Test Customer\",\"Owner\":\"admin@my.erpnext.com\",\"Creation\":\"2022-09-12T14:46:12.8456190Z\",\"Disabled\":false,\"IsFrozen\":true,\"Language\":\"en-US\",\"Modified\":\"2022-09-12T14:46:12.8456190Z\",\"Docstatus\":2,\"Territory\":\"United States\",\"DnRequired\":true,\"ModifiedBy\":\"admin@my.erpnext.com\",\"SoRequired\":true,\"CustomerName\":\"Generic Test Customer\",\"CustomerType\":\"Company\",\"NamingSeries\":\"CUST-.YYYY.-\",\"CustomerGroup\":\"Individual\",\"ExemptFromSalesTax\":false,\"DefaultCommissionRate\":0}";
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void SellingCustomerDeserializationTest()
        {
            // Arrange

            // {
            //     "Idx": 0,
            //     "Name": "Generic Test Customer",
            //     "Owner": "admin@my.erpnext.com",
            //     "Creation": "2022-09-12 14:46:12.845619",
            //     "Disabled": 0,
            //     "IsFrozen": 0,
            //     "Language": "en-US",
            //     "Modified": "2022-09-12 14:46:12.845619",
            //     "Docstatus": 0,
            //     "Territory": "United States",
            //     "DnRequired": 0,
            //     "ModifiedBy": "admin@my.erpnext.com",
            //     "SoRequired": 0,
            //     "CustomerName": "Generic Test Customer",
            //     "CustomerType": "Company",
            //     "NamingSeries": "CUST-.YYYY.-",
            //     "CustomerGroup": "Individual",
            //     "ExemptFromSalesTax": 0,
            //     "IsInternalCustomer": 0,
            //     "DefaultCommissionRate": 0
            // }
            var json = "{\"Name\":\"Generic Test Customer\",\"Owner\":\"admin@my.erpnext.com\",\"Creation\":\"2022-09-12T14:46:12.8456190Z\",\"Disabled\":false,\"IsFrozen\":true,\"Language\":\"en-US\",\"Modified\":\"2022-09-12T14:46:12.8456190Z\",\"Docstatus\":2,\"Territory\":\"United States\",\"DnRequired\":true,\"ModifiedBy\":\"admin@my.erpnext.com\",\"SoRequired\":true,\"CustomerName\":\"Generic Test Customer\",\"CustomerType\":\"Company\",\"NamingSeries\":\"CUST-.YYYY.-\",\"CustomerGroup\":\"Individual\",\"ExemptFromSalesTax\":false,\"DefaultCommissionRate\":0}";

            // Act

            var customer = ERPNextObjectBase.Deserialize<ERP_Selling_Customer>(json)!;

            // Assert 

            var actualDateTimeOffset = customer.Creation;

            var expectedDateTimeLocal = DateTime.Parse("2022-09-12T14:46:12.8456190Z"); //local by default
            var expectedDateTimeOffsetLocal = new DateTimeOffset(expectedDateTimeLocal);
            var expectedDateTimeUtc = expectedDateTimeLocal.ToUniversalTime();
            var expectedDateTimeOffsetUtc = new DateTimeOffset(expectedDateTimeUtc);
            
            //
            // DateTimeOffset rocks!
            //
            Assert.Equal(expectedDateTimeOffsetLocal, expectedDateTimeOffsetUtc);
            Assert.Equal(expectedDateTimeUtc, actualDateTimeOffset);
            Assert.Equal(expectedDateTimeLocal, actualDateTimeOffset);
            Assert.True(expectedDateTimeUtc == actualDateTimeOffset);
            Assert.True(expectedDateTimeLocal == actualDateTimeOffset);

            //
            // DateTime sucks... cannot be compared if kind is different between matched instances
            //
            Assert.NotEqual(expectedDateTimeLocal.Kind, expectedDateTimeUtc.Kind);
            Assert.NotEqual(expectedDateTimeLocal.Ticks, expectedDateTimeUtc.Ticks);
            Assert.False(expectedDateTimeLocal == expectedDateTimeUtc);

            Assert.Equal("Generic Test Customer", customer.Name);
            Assert.Equal("admin@my.erpnext.com", customer.Owner);
            //Assert.Equal(DateTime.Parse("2022-09-12T14:46:12.8456190Z"), customer.Creation);
            Assert.False(customer.Disabled);
            Assert.True(customer.IsFrozen);
            Assert.Equal("en-US", customer.Language);
            Assert.Equal(DateTime.Parse("2022-09-12T14:46:12.8456190Z").ToUniversalTime(), customer.Modified);
            Assert.Equal(Docstatus.Cancelled, customer.Docstatus);
            Assert.Equal("United States", customer.Territory);
            Assert.True(customer.DnRequired);
            Assert.Equal("admin@my.erpnext.com", customer.ModifiedBy);
            Assert.True(customer.SoRequired);
            Assert.Equal("Generic Test Customer", customer.CustomerName);
            Assert.Equal("Company", customer.CustomerType);
            Assert.Equal("CUST-.YYYY.-", customer.NamingSeries);
            Assert.Equal("Individual", customer.CustomerGroup);
            Assert.False(customer.ExemptFromSalesTax);
            Assert.Equal(0, customer.DefaultCommissionRate);

            Assert.ThrowsAny<Exception>(() => customer.IsInternalCustomer);

        }




    }
}
