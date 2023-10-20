using TshirtChallenge.Application.Models.ImageModel;

namespace TshirtChallenge.Application.Models.TypeModel
{
    public class TypeResponseModel
    {
        public Guid Id { get; set; }
        public string Color { get; set; }
        public string Fabric { get; set; }
        public List<ImageResponseModel> Images { get; set; }

        public TypeResponseModel(Guid id, string color, string fabric, List<ImageResponseModel> images)
        {
            Id = id;
            Color = color;
            Fabric = fabric;
            Images = images;
        }
    }
}
