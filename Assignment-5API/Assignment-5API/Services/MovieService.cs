using Assignment_5API.Interface;
using Assignment_5API.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment_5API.Services
{
    public class MovieService : IMovieInterface
    {
        public static List<Movie> list = new List<Movie>();
        
        public void AddMovie(Movie movie)
        {

            list.Add(movie);
        }

        public void DeleteMovie(int movieId)
        {
            Movie movieToDel = list.SingleOrDefault(x => x.MovieId == movieId);
            list.Remove(movieToDel);
        }

        public List<Movie> GetAllMovies()
        {
            return list;
        }

        public List<Movie> GetMovieByActor(string actor)
        {
            List<Movie> moviesByActor = list.FindAll(x => x.Actor == actor);
            return moviesByActor;
        }

        public List<Movie> GetMovieByDirector(string director)
        {
            List<Movie> moviesByDirector= list.FindAll(x => x.Director == director);
            return moviesByDirector;
        }

        public Movie GetMovieById(int movieId)
        {
            Movie movieById = list.SingleOrDefault(x => x.MovieId == movieId);
            return movieById;
        }

        public List<Movie> GetMovieByLanguage(string language)
        {
            List<Movie> moviesByLanguage= list.FindAll(x => x.Language== language);
            return moviesByLanguage;
        }

        public void UpdateMovie(Movie movie)
        {
            var existingMovie = GetMovieById(movie.MovieId);
            existingMovie.MovieName = (movie.MovieName != null) ? movie.MovieName : existingMovie.MovieName;

            existingMovie.Actor = (movie.Actor != null) ? movie.Actor : existingMovie.Actor;

            existingMovie.Director = (movie.Director != null) ? movie.Director : existingMovie.Director;

            existingMovie.Language = (movie.Language != null) ? movie.Language : existingMovie.Language;

            existingMovie.ReleaseYear = (movie.ReleaseYear != null) ? movie.ReleaseYear : existingMovie.ReleaseYear;
        }
    }
}
