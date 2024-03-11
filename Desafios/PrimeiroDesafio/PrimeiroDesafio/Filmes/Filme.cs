// 1. Criar uma classe que representa um filme, com dados como seu
// titulo, duração e elenco. Após isso, colocá-la no namespace
// Alura.Filmes.
namespace Alura.Filmes;
class Filme
{
    private List<string> Elenco = new();
    public Filme(string titulo, int duracao, List<string> elenco)
    {
        Titulo = titulo;
        Duracao = duracao;
        if(elenco == null ) { 
            Elenco = new();
        } else
        {
            Elenco = elenco;
        }
    }

    public string Titulo { get; }
    public int Duracao { get; }
    public string Detalhes => $"Filme: {Titulo}\nDuração: {Duracao} minutos\nElenco: {string.Join(", ", Elenco)}\n";

    public void AdicionarElenco(string ator) { 
        Elenco.Add(ator);
        Console.WriteLine($"{ator} adicionado/a no elenco");
    }
    public void ListarElenco()
    {
        if( Elenco.Count == 0 )
        {
            Console.WriteLine("Elenco vazio");
        } else
        {
            Console.WriteLine("Elenco:");
            foreach(var ator in Elenco)
            {
                Console.WriteLine(ator);
            }
        }
    }
}