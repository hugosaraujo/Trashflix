/* 
    1- Criar uma classe que representa um filme, com dados como seu titulo, duração e elenco. Após isso, colocá-la no namespace Alura.Filmes.
    2- Criar um programa Program.cs, instanciar seus 5 filmes favoritos, guardá-los em uma lista e mostrar as suas informações no console.
    3- Criar uma classe Artista, que representa uma pessoa que atua em filmes, no namespace Alura.Filmes. A classe deve conter atributos como o nome, idade e uma lista de filmes onde o artista atuou.
    4- Modificar as classes Artista e Filme do namespace Alura.Filmes para que elas sejam consistentes uma com a outra, ou seja, sempre que for adicionado um artista a um filme, terá de ser adicionado também o filme à lista de filmes do artista.
*/

using TrashFlix.Models;

List<Film> favorites = new List<Film>();

Film carrie = new Film("Carrie", 96);
Film sleepawayCamp = new("Sleepway Camp", 84);
Film speedRacer = new Film("Speed Racer", 135);
Film braidead = new Film("Braindead", 104);
Film rocky4 = new Film("Rocky IV", 91);

favorites.Add(carrie);
favorites.Add(sleepawayCamp);
favorites.Add(speedRacer);
favorites.Add(braidead);
favorites.Add(rocky4);

//favorites.ForEach(f => Console.WriteLine(f.Details));

Artist sissy = new("Sissy", "Spacek", 74);
Artist travolta = new ("John", "Travolta", 70);

carrie.AddCast(sissy);
carrie.AddCast(travolta);
sissy.ShowMovieList();