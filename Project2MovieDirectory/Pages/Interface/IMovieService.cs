using Project2MovieDirectory.Pages.MovieDirectory.Models;

namespace Project2MovieDirectory.Pages.MovieDirectory.Interface;

public interface IMovieService
{
    List<Movie> GetAllMovies();
    Movie? GetMovieById(int id);
}