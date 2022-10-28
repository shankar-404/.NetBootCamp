using Assignment_5API.Models;
using Assignment_5API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_5API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MovieController : Controller
    {
        private readonly MovieService _service;
        public MovieController () 
        {
            _service = new MovieService();
        }

        [HttpGet]
        [Route("GetAllMovies")]
        public IActionResult GetAllMovies()
        {
            try
            {
                List<Movie> movies = _service.GetAllMovies();
                return Ok(movies);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);            }
        }
        [HttpGet]
        [Route("GetMovieById/{movieId}")]
        public IActionResult GetMovieById(int movieId)
        {
            try
            {
                Movie movie = _service.GetMovieById(movieId);
                return Ok(movie);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetMovieByActor/{actor}")]
        public IActionResult GetMovieByActor(string actor)
        {
            try
            {
                List<Movie> movies = _service.GetMovieByActor(actor);
                return Ok(movies);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetMovieByDirector/{director}")]
        public IActionResult GetMovieByDirector(string director)
        {
            try
            {
                List<Movie> movies = _service.GetMovieByDirector(director);
                return Ok(movies);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetMovieByLanguage/{language}")]
        public IActionResult GetMovieByLanguage(string language)
        {
            try
            {
                List<Movie> movies = _service.GetMovieByLanguage(language);
                return Ok(movies);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteMovie/{movieId}")]
        public IActionResult DeleteMovie(int movieId)
        {
            try
            {
                _service.DeleteMovie(movieId);
                return Ok("Record Deleted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("AddMovie")]
        public IActionResult Addmovie(Movie movie)
        {
            try
            {
                _service.AddMovie(movie);
                return Ok("Record Added");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPatch]
        [Route("EditMovie")]
        public IActionResult EditMovie(Movie movie)
        {
            try
            {
                _service.UpdateMovie(movie);
                return Ok("Record Updated");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
