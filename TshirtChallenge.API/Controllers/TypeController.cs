using Microsoft.AspNetCore.Mvc;
using TshirtChallenge.Application.Services.Interfaces;

namespace TshirtChallenge.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TypeController : AbstractController
    {
        private readonly ITypeService _typeService;
        public TypeController(ITypeService typeService)
        {
            _typeService = typeService;
        }

        [HttpGet("{tshirtId}")]
        public async Task<IActionResult> GetTypesByTshirtId(Guid tshirtId)
        {
            try
            {
                return Ok(await _typeService.GetTypesByTshirtId(tshirtId));
            }
            catch (Exception ex)
            {
                return HandleErrors(ex);
            }
        }
    }
}
