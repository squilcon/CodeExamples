using Examples.Gateways.RestApis;

namespace Examples.Gateways.Tests.AuthenticationApiTests.Base
{
    /// <summary>
    /// Base test class for the AuthenticationApi classe
    /// </summary>
    public abstract class AuthenticationApiBaseTest : BaseTest
    {
        /// <summary>
        /// Mock of the IRestRequestLogging interface
        /// </summary>
        protected Mock<IRestRequestLogging> MockRequestLogging { get; } = new Mock<IRestRequestLogging>();

        /// <summary>
        /// Create the instance of the class
        /// </summary>
        /// <returns>The class instance</returns>
        internal AuthenticationApi CreateInstance()
        {
            return new AuthenticationApi(MockRequestLogging.Object);
        }
    }
}
