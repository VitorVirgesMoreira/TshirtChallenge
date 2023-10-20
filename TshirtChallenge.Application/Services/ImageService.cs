using Microsoft.AspNetCore.Http;
using TshirtChallenge.Application.Models.ImageModel;
using TshirtChallenge.Application.Services.Interfaces;
using TshirtChallenge.Domain.Entities;
using TshirtChallenge.Domain.Exceptions;
using TshirtChallenge.Domain.Interfaces.Repositories;

namespace TshirtChallenge.Application.Services
{
    public class ImageService : IImageService
    {
        private readonly IImageRepository _imageRepository;
        public ImageService(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public async Task Create(ImageRequestModel requestModel)
        {
            if (requestModel.ImageFile == null)
                throw new CustomValidationException("No image file provided.");

            if (requestModel.ImageFile.Length == 0)
                throw new CustomValidationException("Image file is empty.");

            var image = new Image(ConvertFormFileToByte(requestModel.ImageFile), requestModel.TypeId);
            image.ValidateEntity();

            await _imageRepository.Create(image);
            await _imageRepository.Save();
        }

        public async Task Delete(Guid id)
        {
            var image = await _imageRepository.GetById(id);
            if (image == null)
            {
                throw new NotFoundException("Image not found.");
            }

            image.Delete();

            _imageRepository.Update(image);
            await _imageRepository.Save();
        }

        private byte[] ConvertFormFileToByte(IFormFile formfile)
        {
            byte[] imageData;
            using (var stream = formfile.OpenReadStream())
            using (var memoryStream = new MemoryStream())
            {
                stream.CopyTo(memoryStream);
                imageData = memoryStream.ToArray();
            }

            return imageData;
        }
    }
}
