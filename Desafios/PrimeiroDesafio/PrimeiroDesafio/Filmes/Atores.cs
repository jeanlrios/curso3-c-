// 3.
namespace Alura.Filmes;
class Atores
{
    public string Nome { get; set; }
    public int Idade {  get; set; }
    public List<Filme> FilmesAtuados = new();
    public int TotalFilme => FilmesAtuados.Count;

    public Atores(string nome, int idade, List<Filme> filmesAtuados)
    {
        Nome = nome;
        Idade = idade;
        FilmesAtuados = new List<Filme>();
    }
}

