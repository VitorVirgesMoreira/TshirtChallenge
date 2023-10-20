using Microsoft.AspNetCore.Mvc;
using TshirtChallenge.Application.Services.Interfaces;

namespace TshirtChallenge.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TshirtController : AbstractController
    {
        private readonly ITshirtService _tshirtService;
        public TshirtController(ITshirtService tshirtService)
        {
            _tshirtService = tshirtService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _tshirtService.GetAll());
            }
            catch (Exception ex)
            {
                return HandleErrors(ex);
            }
        }
    }
}
