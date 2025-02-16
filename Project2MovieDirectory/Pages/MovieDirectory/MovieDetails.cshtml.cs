using Microsoft.AspNetCore.Mvc.RazorPages;
using Project2MovieDirectory.Pages.MovieDirectory.Interface;
using Project2MovieDirectory.Pages.MovieDirectory.Models;
using static Project2MovieDirectory.Pages.MovieDirectory.Models.StaticMovieService;

namespace Project2MovieDirectory.Pages.MovieDirectory;

public class MovieDetails : PageModel
{
    public Movie? Movie { get; set; }
    private readonly IMovieService _movieService; 
    
    public MovieDetails(IMovieService movieService)
    {
        _movieService = movieService;
    }

    public void OnGet(int? id)
    {
        Movie = id.HasValue ? _movieService.GetMovieById(id.Value) : null;
    }
}