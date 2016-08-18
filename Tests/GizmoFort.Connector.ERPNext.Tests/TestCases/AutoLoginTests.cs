using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GizmoFort.Connector.ERPNext.Tests.TestCases
{
    [TestClass()]
    public class AutoLoginTests
    {
        [TestMethod()]
        public void Login()
        {
            var client = TestUtils.CreateClient();

            var active_username = client.GetActiveUserName();
            Assert.IsTrue(active_username == TestConstants.TEST_USERNAME);
        }


    }
}