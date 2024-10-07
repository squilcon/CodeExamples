using Examples.Gateways.Models;
using Examples.Gateways.Tests.AuthenticationApiTests.Base;
using System.Net;
using System.Text;
using System.Text.Json;

namespace Examples.Gateways.Tests.AuthenticationApiTests
{
    /// <summary>
    /// Tests for function GetTokenAsync of the AuthenticationApi class
    /// </summary>
    public class GetTokenAsyncTests : AuthenticationApiBaseTest
    {
        /// <summary>
        /// Verify that the function GetTokenAsync returns the right informations.
        /// </summary>
        [Fact]
        public async Task GetTokenAsync_RequestSuccessful_ReturnTokenWithInformation()
        {
            // Arrange
            var url = Fixture.Create<string>();
            var httpContent = Fixture.Create<StringContent>();
            var token = Fixture.Create<Token>();
            var jsonContent = JsonSerializer.Serialize(token);
            var responseContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response = new HttpResponseMessage()
            {
                Content = responseContent,
                StatusCode = HttpStatusCode.OK
            };

            MockRequestLogging.Setup(x => x.PostAsync(It.IsAny<string>(), It.IsAny<HttpContent>()))
                              .ReturnsAsync(response);

            // Act
            var result = await CreateInstance().GetTokenAsync(url, httpContent);

            // Assert
            Assert.Equivalent(token, result, true);
        }

        /// <summary>
        /// Verify that the function GetTokenAsync returns the right informations.
        /// </summary>
        [Fact]
        public async Task GetTokenAsync_RequestUnSuccessful_ReturnTokenWithInformation()
        {
            // Arrange
            var url = Fixture.Create<string>();
            var httpContent = Fixture.Create<StringContent>();
            var token = Fixture.Create<Token>();
            var jsonContent = JsonSerializer.Serialize(token);
            var responseContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response = new HttpResponseMessage()
            {
                Content = responseContent,
                StatusCode = HttpStatusCode.BadRequest
            };

            MockRequestLogging.Setup(x => x.PostAsync(It.IsAny<string>(), It.IsAny<HttpContent>()))
                              .ReturnsAsync(response);

            // Act-Assert
            await Assert.ThrowsAsync<HttpRequestException>(async () => await CreateInstance().GetTokenAsync(url, httpContent));
        }
    }
}
