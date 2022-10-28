using Assignment_5API.Models;

namespace Assignment_5API.Interface
{
    public interface IMovieInterface
    {

        List<Movie> GetAllMovies();
        Movie GetMovieById(int movieId);
        List<Movie> GetMovieByActor(string actor);
        List<Movie> GetMovieByLanguage(string language);
        List<Movie> GetMovieByDirector(string director);
        void AddMovie(Movie movie);
        void DeleteMovie(int movieId);
        void UpdateMovie(Movie movie);
    }
}
