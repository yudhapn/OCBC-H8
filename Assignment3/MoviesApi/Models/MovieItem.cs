namespace MoviesApi.Models
{
    public class MovieItem
    {
        public int id { get; set; }
        public string title { get; set; }
        public string overview { get; set; }
        public bool adult { get; set; }
        public double voteAverage { get; set; }
        public int voteCount { get; set; }
    }
}