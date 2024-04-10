using Alura.Filmes;

Filme filme1 = new Filme("Um sonho de liberdade", 142, new List<Artista> {new Artista("Tim Robbins"), new Artista("Morgan Freeman") });
Filme filme2 = new Filme("O poderoso chefão", 175, new List<Artista> { new Artista("Marlon Brando"), new Artista("Al Pacino"), new Artista("Talia Shire") });
Filme filme3 = new Filme("Batman - O Cavaleiro das Trevas", 152, new List<Artista> { new Artista("Christian Bale"), new Artista("Heath Ledger"), new Artista("Maggie Gyleenhaal") });
Filme filme4 = new Filme("Senhor dos Anéis - O Retorno do Rei", 201, new List<Artista> { new Artista("Elijah Wood"), new Artista("Ian McKellen"), new Artista("Viggo Mortensen") });
Filme filme5 = new Filme("Green Book - O Guia", 130, new List<Artista> { new Artista("Viggo Mortensen"), new Artista("Mahershala Ali") });
Filme filme6 = new Filme("O Lobo de Wall Street", 200, new List<Artista>());

Artista artista1 = new Artista("Leonardo DiCaprio");
artista1.AdicionarFilme(filme6);


List<Filme> meusFilmesFavoritos = new List<Filme>();
meusFilmesFavoritos.Add(filme1);
meusFilmesFavoritos.Add(filme2);
meusFilmesFavoritos.Add(filme3);
meusFilmesFavoritos.Add(filme4);
meusFilmesFavoritos.Add(filme5);
meusFilmesFavoritos.Add(filme6);

foreach (Filme filme in meusFilmesFavoritos)
{
    Console.WriteLine($"Filme: {filme.Titulo}");
    Console.WriteLine($"Duracao: {filme.Duracao} minutos");
    filme.ListarElenco();
    Console.WriteLine();
}


