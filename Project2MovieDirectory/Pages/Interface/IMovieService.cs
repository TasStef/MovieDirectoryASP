using Project2MovieDirectory.Pages.MovieDirectory.Models;

namespace Project2MovieDirectory.Pages.Interface;

public interface IMovieService
{
    List<Movie> GetAllMovies();
    Movie? GetMovieById(int id);
    void AppendMovie(Movie movie);
}