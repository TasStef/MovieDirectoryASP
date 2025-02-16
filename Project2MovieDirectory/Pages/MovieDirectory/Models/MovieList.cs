namespace Project2MovieDirectory.Pages.MovieDirectory.Models;

public class MovieList
{
     private static List<Movie> Movies = new List<Movie>
    {
        new Movie
        {
            Id = 1, Title = "The Shawshank Redemption", Genre = "Drama", Rating = 9.3m, Year = 1994,
            Description =
                "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."
        },
        new Movie
        {
            Id = 2, Title = "The Godfather", Genre = "Crime", Rating = 9.2m, Year = 1972,
            Description =
                "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."
        },
        new Movie
        {
            Id = 3, Title = "The Dark Knight", Genre = "Action", Rating = 9.0m, Year = 2008,
            Description =
                "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham."
        },
        new Movie
        {
            Id = 4, Title = "The Godfather: Part II", Genre = "Crime", Rating = 9.0m, Year = 1974,
            Description =
                "The early life and career of Vito Corleone in 1920s New York is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate."
        },
        new Movie
        {
            Id = 5, Title = "The Lord of the Rings: The Return of the King", Genre = "Adventure", Rating = 8.9m,
            Year = 2003,
            Description =
                "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring."
        },
        new Movie
        {
            Id = 6, Title = "Pulp Fiction", Genre = "Crime", Rating = 8.9m, Year = 1994,
            Description =
                "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption."
        },
        new Movie
        {
            Id = 7, Title = "Schindler's List", Genre = "Biography", Rating = 8.9m, Year = 1993,
            Description =
                "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis."
        },
    };

    public static List<Movie> GetAllMovies()
    {
        return Movies;
    }
     
     public static Movie? GetMovieById(int id)
     {
         return Movies.FirstOrDefault(x => x.Id == id);
     }
}