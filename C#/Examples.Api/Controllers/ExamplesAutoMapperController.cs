using AutoMapper;
using Examples.Api.Models;
using Examples.Api.Models.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Examples.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamplesAutoMapperController : ControllerBase
    {
        private readonly IMapper _mapper;

        public ExamplesAutoMapperController(IMapper mapper)
        {
            _mapper = mapper;
        }

        /// <summary>
        /// AutoMapper example with converter
        /// </summary>
        [HttpGet("ConvertUsing")]
        [ProducesResponseType(typeof(IEnumerable<ExampleValueGrouped>), StatusCodes.Status200OK)]
        public IActionResult ConvertUsingExample()
        {
            var originalObject = new List<ExampleValue>()
            {
                new() { Value = "1", Description = "Description 1", Language = LanguageType.LanguageOne },
                new() { Value = "1", Description = "Description 2", Language = LanguageType.LanguageTwo },
                new() { Value = "2", Description = "Description 3", Language = LanguageType.LanguageOne },
                new() { Value = "3", Description = "Description 4", Language = LanguageType.LanguageTwo }
            };

            var result = _mapper.Map<IEnumerable<ExampleValueGrouped>>(originalObject);
            return Ok(result);
        }

        /// <summary>
        /// AutoMapper example with resolver
        /// </summary>
        [HttpGet("Resolve")]
        [ProducesResponseType(typeof(IEnumerable<ExampleValueTwoMapped>), StatusCodes.Status200OK)]
        public IActionResult ResolveExample()
        {
            var originalObject = new List<ExampleValueTwo>()
            {
                new() { Value = "1", DescriptionLanguageOne = "Description 1", DescriptionLanguageTwo = string.Empty, Language = LanguageType.LanguageOne },
                new() { Value = "2", DescriptionLanguageOne = string.Empty, DescriptionLanguageTwo = "Description 2", Language = LanguageType.LanguageTwo }
            };

            var result = _mapper.Map<IEnumerable<ExampleValueTwoMapped>>(originalObject);
            return Ok(result);
        }
    }
}
