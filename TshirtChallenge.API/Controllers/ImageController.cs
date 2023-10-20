using Microsoft.AspNetCore.Mvc;
using TshirtChallenge.Application.Models.ImageModel;
using TshirtChallenge.Application.Services.Interfaces;

namespace TshirtChallenge.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageController : AbstractController
    {
        private readonly IImageService _imageService;
        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] ImageRequestModel requestModel)
        {
            try
            {
                await _imageService.Create(requestModel);
                return Ok("Image uploaded and saved.");
            }
            catch (Exception ex)
            {
                return HandleErrors(ex);
            }
        }

        [HttpPut]
        [Route("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _imageService.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return HandleErrors(ex);
            }
        }
    }
}
