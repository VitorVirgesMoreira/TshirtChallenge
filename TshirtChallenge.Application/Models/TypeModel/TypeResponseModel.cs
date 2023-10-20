namespace TshirtChallenge.Application.Models.TypeModel
{
    public class TypeResponseModel
    {
        public string Color { get; set; }
        public string Fabric { get; set; }
        public string? ImageBase64 { get; set; }

        public TypeResponseModel(string color, string fabric, string? imageBase64)
        {
            Color = color;
            Fabric = fabric;
            ImageBase64 = imageBase64;
        }
    }
}
