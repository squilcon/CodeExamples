using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.Core.Enums;
using OnionArchitecture.Core.Interfaces;

namespace OnionArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _productServices;
        private readonly ILogger<ProductController> _logger;

        public ProductController(
            IProductServices productServices,
            ILogger<ProductController> logger)
        {
            _productServices = productServices;
            _logger = logger;   

        }

        [HttpPost("Buy")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult BuyProduct(ProductType product)
        {
            try
            {   
                var bought = _productServices.BuyProducts(product);

                return Ok(bought);
            }
            catch (Exception ex)
            {
                return UnexpectedErrorHandling(ex);
            }
        }

        private IActionResult UnexpectedErrorHandling(Exception ex)
        {
            _logger.LogError(ex, "An unexpected error occured");
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}
