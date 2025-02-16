using Microsoft.AspNetCore.Mvc.RazorPages;
using Project2MovieDirectory.Pages.MovieDirectory.Interface;
using Project2MovieDirectory.Pages.MovieDirectory.Models;


namespace Project2MovieDirectory.Pages.MovieDirectory;

public class Index : PageModel
{
    private readonly IMovieService _movieService;

    public Index(IMovieService movieService)
    {
        _movieService = movieService;
    }

    public List<Movie>? Movies { get; set; }

    public void OnGet()
    {
        Movies = _movieService.GetAllMovies();
    }
}