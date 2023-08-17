using Examples.Core.Services.Database;
using Microsoft.AspNetCore.Mvc;

namespace Examples.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Examples : ControllerBase
    {
        private readonly IExampleTableServices _exampleTableServices;

        public Examples(IExampleTableServices exampleTableServices)
        {
            _exampleTableServices = exampleTableServices;
        }

        [HttpPost("Example")]
        public async Task<IActionResult> ExampleAddAsync(string name)
        {
            var id = await _exampleTableServices.AddExampleTableAsync(name);
            return Ok(id);
        }

        [HttpGet("Example")]
        public async Task<IActionResult> ExampleGetAsync(int id)
        {
            var name = await _exampleTableServices.GetExampleTableByIDAsync(id);
            return Ok(name);
        }
    }
}
