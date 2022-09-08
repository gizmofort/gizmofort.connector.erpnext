using Xunit;

namespace GizmoFort.Connector.ERPNext.Tests.TestCases
{
    public class AutoLoginTests
    {
        [Fact()]
        public void Login()
        {
            var client = TestUtils.CreateClient();

            var active_username = client.GetActiveUserName();
            Assert.True(active_username == TestConstants.TEST_USERNAME);
        }


    }
}