using System.ComponentModel.DataAnnotations;
using Project2MovieDirectory.Pages.MovieDirectory.Interface;

namespace Project2MovieDirectory.Pages.MovieDirectory.Models;

public class Movie : IMovie
{
    public int Id { get; set; }
    
    [DataType(DataType.Text)]
    [Required(ErrorMessage = "Title is required")]
    [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters.")]
    public string Title { get; set;  }
    
    [DataType(DataType.Text)]
    [Required(ErrorMessage = "Genre is required")]
    [StringLength(100, ErrorMessage = "Genre cannot be longer than 100 characters.")]
    public string Genre { get; set; }
    
    // [DataType((DataType)decimal)]
    [Required(ErrorMessage = "Rating is required")]
    [Range(0.0, 10.0, ErrorMessage = "Rating must be between 0 and 10")]
    public decimal Rating { get; set; }
    
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "Year is required")]
    [Range(1800, 2100, ErrorMessage = "Year must be between 1800 and the current year")]
    public int Year { get; set; }
    
    [DataType(DataType.Text)]
    [Required(ErrorMessage = "Description is required")]
    public string Description { get; set; }
    
}