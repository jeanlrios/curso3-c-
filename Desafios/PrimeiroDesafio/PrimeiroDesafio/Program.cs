// 2. Criar um programa Program.cs, instanciar seus 5 filmes
// favoritos, guardá-los em uma lista e mostrar as suas informações
// no console.
using Alura.Filmes;

Filme filme1 = new("O Senhor dos Aneis - A Sociedade do Anel")
{
    Ano = 2001,
    Duracao = 178
};

Filme filme2 = new("O Senhor dos Aneis - As Duas Torres")
{
    Ano = 2002,
    Duracao = 218
};

Filme filme3 = new("O Senhor dos Aneis - O Retorno do Rei")
{
    Ano = 2003,
    Duracao = 201
};

Filme filme4 = new("Interestelar")
{
    Ano = 2014,
    Duracao = 169
};
Filme filme5 = new("Forrest Gump")
{
    Ano = 1994,
    Duracao = 142
};

filme1.AdicionarFilmes(filme1);
filme2.AdicionarFilmes(filme2);
filme3.AdicionarFilmes(filme3);
filme4.AdicionarFilmes(filme4);
filme5.AdicionarFilmes(filme5);

Console.WriteLine(filme1.Detalhes);
Console.WriteLine(filme2.Detalhes);
Console.WriteLine(filme3.Detalhes);
Console.WriteLine(filme4.Detalhes);
Console.WriteLine(filme5.Detalhes);

