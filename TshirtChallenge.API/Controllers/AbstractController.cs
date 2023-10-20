using Microsoft.AspNetCore.Mvc;
using TshirtChallenge.Domain.Exceptions;

namespace TshirtChallenge.API.Controllers
{
    public abstract class AbstractController : Controller
    {
        protected ActionResult HandleErrors(Exception ex)
        {
            if (ex is CustomValidationException)
            {
                return BadRequest(ex.Message);
            }

            if (ex is NotFoundException)
            {
                return NotFound(ex.Message);
            }

            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}
