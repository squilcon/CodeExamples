using Examples.Api.Models;
using Examples.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Examples.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamplesCachingController : ControllerBase
    {
        private readonly ICachingServices _cachingServices;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="cachingServices">ICachingServices dependency</param>
        public ExamplesCachingController(ICachingServices cachingServices)
        {
            _cachingServices = cachingServices;
        }

        /// <summary>
        /// Get the value cached in the last minute
        /// </summary>
        /// <param name="valueToCache">Value to cache</param>
        /// <returns>Cached value</returns>
        [HttpGet("MemoryCache")]
        [ProducesResponseType(typeof(IEnumerable<ExampleValueGrouped>), StatusCodes.Status200OK)]
        public IActionResult GetCachedValue(string valueToCache)
        {
            var result = _cachingServices.GetExampleValue(valueToCache);
            return Ok(result);
        }

        /// <summary>
        /// Get a guid value and cache the result for one minute in the client browser 
        /// </summary>
        /// <returns>The guid</returns>
        [HttpGet("ClientCaching")]
        [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Client)] //Cache the response for 1 minute on the client side
        [ProducesResponseType(typeof(Guid), StatusCodes.Status200OK)]
        public IActionResult GetGuid()
        {
            return Ok(Guid.NewGuid());
        }
    }
}
