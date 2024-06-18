namespace TrashFlix.Models;

public class Artist
{
    private List<Film> films = new List<Film>();

    public Artist(
        string name, 
        string lastName, 
        int age)
    {
        Name = name;
        LastName = lastName;
        Age = age;
    }
    
    public string Name { get; }
    public string LastName { get; }
    public int Age { get; }
    public string ArtisticName => $"{Name} {LastName}";
    
    public List<Film> Films => films;

    public void AddMovie(Film film)
    {
        if (!films.Contains(film))
        { 
            films.Add(film);
            film.AddCast(this);
        }
    }

    public void ShowMovieList()
    {
        Console.WriteLine($"Lista de filmes {ArtisticName}");
        Films.ForEach(f => Console.Write($"-> {f.Title}"));
    }
}