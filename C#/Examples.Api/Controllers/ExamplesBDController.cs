using Examples.Core.Services.Database;
using Microsoft.AspNetCore.Mvc;

namespace Examples.Api.Controllers
{
    /// <summary>
    /// Controller used for examples that use a Database
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ExamplesBDController : ControllerBase
    {
        private readonly IExampleTableServices _exampleTableServices;
        private readonly ILogger<ExamplesBDController> _logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="exampleTableServices">Instance of the interface IExampleTableServices</param>
        /// <param name="logger">Instance of the interface ILogger</param>
        public ExamplesBDController(IExampleTableServices exampleTableServices,
                                    ILogger<ExamplesBDController> logger)
        {
            _exampleTableServices = exampleTableServices;
            _logger = logger;
        }

        /// <summary>
        /// POST example used for adding the name of a record to the database
        /// </summary>
        /// <param name="name">Name to add for the record</param>
        /// <returns>The id of the record</returns>
        [HttpPost("DatabaseExample")] //Tells us how to call this endpoint.
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)] //Tells swagger that a response of type "int" will be return when the StatusCode is 200.
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)] //Tells swagger that a response of type "string" will be return when the StatusCode is 400.
        [ProducesResponseType(StatusCodes.Status500InternalServerError)] //Tells swagger that a response of type of StatusCode 500 is possible.
        public async Task<IActionResult> ExampleAddAsync(string name)
        {
            try
            {
                //If the name is null, empty or have only whitespace, we return the HttpCode 400 with a message for the caller to know why we won't process this call.
                //Generally speaking, if the caller sends us incorrect values in the parameters, HttpCode 400 is the best code to return.
                if (string.IsNullOrWhiteSpace(name))
                {
                    return BadRequest("The name can't be null");
                }

                //We call the function to add the information to the database. The controller / API project should never know what's the logic for adding to the database.
                //If we follows good principles like SOLID, we need to decouple those logic. So, the controller should only receive the call, validate parameters
                //and return a status code with information like an object containing the data. In this way, we can have other entrypoint like a console application
                //use the same functionality as the API.
                var id = await _exampleTableServices.AddExampleTableAsync(name);
                
                //We then return the id with a status code 200 (Http code 200).
                return Ok(id);
            }
            catch (Exception ex)
            {
                //In the case of an unexpeted error, we handle it.
                return UnexpectedErrorHandling(ex);
            }            
        }

        /// <summary>
        /// GET example used for getting the name of a record with it's id from the database.
        /// </summary>
        /// <param name="id">Id of the record to get</param>
        /// <returns>The name of the record</returns>
        [HttpGet("DatabaseExample")] //Tells us how to call this endpoint.
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)] //Tells swagger that a response of type "int" will be return when the StatusCode is 200.
        [ProducesResponseType(StatusCodes.Status204NoContent)] //Tells swagger that a response of type of StatusCode 204 is possible.
        [ProducesResponseType(StatusCodes.Status500InternalServerError)] //Tells swagger that a response of type of StatusCode 500 is possible.
        public async Task<IActionResult> ExampleGetAsync(int id)
        {
            try
            {
                //We call the function to add the information to the database. The controller / API project should never know what's the logic for fetching the database.
                //If we follows good principles like SOLID, we need to decouple those logic. So, the controller should only receive the call, validate parameters
                //and return a status code with information like an object containing the data. In this way, we can have other entrypoint like a console application
                //use the same functionality as the API.
                var name = await _exampleTableServices.GetExampleTableByIDAsync(id);

                //There's multiple ways to manage if the return is empty.
                //We could simply return the empty result to the caller without doing validation (Http code 200 with empty value).
                //We could return an error with a status code 404 which might not really be a good way to do it depending on the context.
                //Or we can return the status code 204 which indicate that there's no content.
                if (string.IsNullOrWhiteSpace(name))
                {
                    return NoContent();
                }

                //We then return the id with a status code 200 (Http code 200).
                return Ok(name);
            }
            catch (Exception ex)
            {
               return UnexpectedErrorHandling(ex);                
            }
        }

        /// <summary>
        /// Handle unexpected errors 
        /// </summary>
        /// <param name="ex">The exception</param>
        /// <returns>The action result which in this case is the Status code for internal server error (500)</returns>
        private IActionResult UnexpectedErrorHandling(Exception ex)
        {
            //It's never a good idea to return the error stacktrace to the caller. So in here, we simply log it for use to see and analyse later
            //and return a Http code 500. We could return a json object with some details but generaly, we keep it really short and simple so
            //that the caller won't know how it's done internally.
            _logger.LogError(ex, "An unexpected error occured");
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}
