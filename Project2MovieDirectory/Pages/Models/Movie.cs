using Project2MovieDirectory.Pages.MovieDirectory.Interface;

namespace Project2MovieDirectory.Pages.MovieDirectory.Models;

public class Movie : IMovie
{
    public int Id { get; set; }
    public string Title { get; set;  }
    public string Genre { get; set; }
    public decimal Rating { get; set; }
    public int Year { get; set; }
    public string Description { get; set; }
    
}