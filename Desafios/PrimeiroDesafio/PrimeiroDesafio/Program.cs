// 2. Criar um programa Program.cs, instanciar seus 5 filmes
// favoritos, guardá-los em uma lista e mostrar as suas informações
// no console.
using Alura.Filmes;

Filme filme1 = new("O Senhor dos Aneis - A Sociedade do Anel", 178, ["Sean Bean", "Elijah Wood", "Viggo Mortensen", "Ian McKellen"]);
Filme filme2 = new("O Senhor dos Aneis - As Duas Torres", 218, ["Sean Bean", "Elijah Wood", "Viggo Mortensen", "Ian McKellen"]);
Filme filme3 = new("O Senhor dos Aneis - O Retorno do Rei", 201, ["Sean Bean", "Elijah Wood", "Viggo Mortensen", "Ian McKellen"]);
Filme filme4 = new("Interestelar", 169, ["Matthew McConaughey", "Jessica Chanstain", "Anne Hathaway"]);
Filme filme5 = new("Forrest Gump", 142, ["Tom Hanks", "Robin Wright", "Gary Sinise"]);

List<Filme> filmeLista = new();
filmeLista.Add(filme1);
filmeLista.Add(filme2);
filmeLista.Add(filme3);
filmeLista.Add(filme4);
filmeLista.Add(filme5);

foreach(Filme filme in filmeLista)
{
    Console.WriteLine($"Filme: {filme.Titulo}\nDuração: {filme.Duracao}");
    filme.ListarElenco();
    Console.WriteLine();
}