namespace TshirtChallenge.Application.Models.ImageModel
{
    public class ImageResponseModel
    {
        public Guid ImageId { get; set; }
        public string? ImageBase64 { get; set; }

        public ImageResponseModel(Guid imageId, string? imageBase64)
        {
            ImageId = imageId;
            ImageBase64 = imageBase64;
        }
    }
}
