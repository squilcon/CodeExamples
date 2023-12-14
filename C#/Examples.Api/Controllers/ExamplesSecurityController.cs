using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Examples.Api.Controllers
{
    /// <summary>
    /// Controller used for examples that use security on the endpoints
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ExamplesSecurityController : ControllerBase
    {
        /// <summary>
        /// GET example on how to secure an endpoint.
        /// </summary>
        /// <returns>A succes message</returns>
        [HttpGet]
        [Authorize("SecureEndpoint")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)] //Tells swagger that a response of type "string" will be return when the StatusCode is 200.
        [ProducesResponseType(StatusCodes.Status401Unauthorized)] //Tells swagger that a response of StatusCode 401 is possible.
        public IActionResult ExampleSecureEndpoint()
        {
            return Ok("You have acces to the endpoint!");
        }
    }
}
