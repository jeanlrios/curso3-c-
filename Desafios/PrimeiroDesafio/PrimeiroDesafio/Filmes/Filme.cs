// 1. Criar uma classe que representa um filme, com dados como seu
// titulo, duração e elenco. Após isso, colocá-la no namespace
// Alura.Filmes.
namespace Alura.Filmes;
class Filme
{
    private List<Filme> listaFilmes = new();
    public Filme(string titulo)
    {
        Titulo = titulo;
    }
    public string Titulo { get; }
    public int Ano { get; set; }
    public int Duracao { get; set; }
    public Atores Ator { get; set; }
    public string Detalhes => $"Filme: {Titulo}\nAno: {Ano}\nDuração: {Duracao} minutos\n";
    public void AdicionarFilmes(Filme filme)
    {
        listaFilmes.Add(filme);
    }

}