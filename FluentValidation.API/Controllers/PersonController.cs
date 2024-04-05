using FluentValidation.API.Application.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidation.API.Controllers
{
    [Route("api/person")]
    public class PersonController : ControllerBase
    {
        [HttpPost] 
        public IActionResult PostPerson([FromBody] CreatePersonInputModel inputModel)
        {
            // Checking can be action by action, but it makes the code repetitive. 
            // Creating the filter, optimize this problem.

            /*if(!ModelState.IsValid)
            {
                var messages = ModelState
                    .SelectMany(ms => ms.Value.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();

                return BadRequest(messages);
            }*/

            return Ok(inputModel);
        }
    }
}
