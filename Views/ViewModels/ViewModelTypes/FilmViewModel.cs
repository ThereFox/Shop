using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Views.ViewModels.ViewModelTypes
{
    public class FilmViewModel
    {

        public string Name { get; init; }
        public string Description { get; init; }
        public ImageData Image { get; init; }
        public Dictionary<string, string> Metadata { get; init; }
        public List<string> Tags { get; init; }


        public FilmViewModel(string name, string description, ImageData image, Dictionary<string, string> metadata, List<string> tags)
        {
            Name = name;
            Description = description;
            Image = image;
            Metadata = metadata;
            Tags = tags;
        }

    }
}
