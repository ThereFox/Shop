using WebApplication1.Views.ViewModels.ViewModelTypes;

namespace WebApplication1.Views.ViewModels
{
    public class RelevantsFilmsViewModel
    {
        public List<string> UsedSelectors { get; init; }
        public List<FilmViewModel> Films { get; init; }

        public RelevantsFilmsViewModel(List<string> usedSelectors, List<FilmViewModel> films)
        {
            UsedSelectors= usedSelectors;
            Films= films;
        }

    }
}
