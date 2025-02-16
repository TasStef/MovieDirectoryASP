using Microsoft.AspNetCore.Mvc.RazorPages;
using Project2MovieDirectory.Pages.MovieDirectory.Models;
using static Project2MovieDirectory.Pages.MovieDirectory.Models.MovieList;

namespace Project2MovieDirectory.Pages.MovieDirectory;

public class MovieDetails : PageModel
{
    public Movie? Movie { get; set; }

    public void OnGet(int? id)
    {
        Movie = id.HasValue ? GetMovieById(id.Value) : null;
    }
}