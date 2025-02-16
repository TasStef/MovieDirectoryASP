using Microsoft.AspNetCore.Mvc.RazorPages;
using Project2MovieDirectory.Pages.MovieDirectory.Models;
using static Project2MovieDirectory.Pages.MovieDirectory.Models.MovieList;


namespace Project2MovieDirectory.Pages.MovieDirectory;

public class List : PageModel
{
    
   public List<Movie> Movies { get; set; }

    public void OnGet()
    {
        Movies = GetAllMovies(); 
    }
}