namespace TshirtChallenge.Application.Models.TshirtModel
{
    public class TshirtResponseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int ColorsNumber { get; set; }
        public int FabricsNumber { get; set; }
        public int ImagesNumber { get; set; }

        public TshirtResponseModel(Guid id, string name, int colorsNumber, int fabricsNumber, int imagesNumber)
        {
            Id = id;
            Name = name;
            ColorsNumber = colorsNumber;
            FabricsNumber = fabricsNumber;
            ImagesNumber = imagesNumber;
        }
    }
}
