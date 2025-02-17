using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project2MovieDirectory.Pages.Interface;
using Project2MovieDirectory.Pages.MovieDirectory.Models;

namespace Project2MovieDirectory.Pages.MovieDirectory;

public class AddMovie : PageModel
{
    [BindProperty]
    public Movie Movie { get; set; }
    private readonly IMovieService _movieService;
    
    public AddMovie(IMovieService movieService)
    {
        _movieService = movieService;
    }
    public void OnGet()
    {
    }
    
    public IActionResult OnPost(Movie movie)
    {   
        movie.Id = _movieService.GetAllMovies().Count + 1;
        _movieService.AppendMovie(movie);
        return RedirectToPage("/MovieDirectory/Index");
    }
    
}