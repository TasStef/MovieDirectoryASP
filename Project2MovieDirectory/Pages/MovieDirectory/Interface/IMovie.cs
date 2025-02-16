namespace Project2MovieDirectory.Pages.MovieDirectory.Interface;

public interface IMovie
{
    int Id { get; }
    string Title { get; }
    string Genre { get; }
    decimal Rating { get; }
    int Year { get; }
    string Description { get; }
}