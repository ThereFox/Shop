using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Views.ViewModels.ViewModelTypes
{
    public class ImageData
    {
        public string Name { get; init; }
        public FileContentResult Image { get
            {
                return new FileContentResult(_imageData, _imageType);
            } }

        private string _imageType { get; init; }
        private byte[] _imageData { get; init; }

        public ImageData(string name, byte[] imageData, string imageType)
        {
            Name= name;
            _imageData = imageData;
            _imageType = imageType;
        }

    }
}
