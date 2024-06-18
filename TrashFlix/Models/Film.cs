namespace TrashFlix.Models;

public class Film
{
    private List<Artist> cast = new();

    public Film(
        string title, 
        int runningTime)
    {
        Title = title;
        RunningTime = runningTime;
    }
    public string Title { get; set; }
    public int RunningTime { get; set; }
    public List<Artist> Cast => cast;
    public string Details => $"Título:{Title} ({RunningTime} min)";

    public void AddCast(Artist person)
    {
        if (!cast.Contains(person))
        {
            cast.Add(person);
            person.AddMovie(this);
        }
    }

    public void ShowCast()
    {
        Console.WriteLine($"Elenco de {Title}");
        Cast.ForEach(cast => Console.Write($"{cast.ArtisticName}, "));
    }
}