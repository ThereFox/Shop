namespace WebApplication1.Models.DataSourses.Types
{
    public class FilmFiltr
    {
        public string Name { get; set; }
        public List<string> Tags { get; set; }
        public OrderType sortingType { get; set; }
    }
}
