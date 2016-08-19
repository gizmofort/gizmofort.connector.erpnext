using GizmoFort.Connector.ERPNext.PublicInterfaces;

namespace GizmoFort.Connector.ERPNext.Tests
{
    public static class TestUtils
    {
        public static ERPNextClient CreateClient()
        {
            return new ERPNextClient(TestConstants.TEST_DOMAIN, TestConstants.TEST_USERNAME, TestConstants.TEST_PASSWORD);
        }

        public static ERPNextServices CreateService()
        {
            return new ERPNextServices(TestConstants.TEST_DOMAIN, TestConstants.TEST_USERNAME, TestConstants.TEST_PASSWORD);
        }
    }
}