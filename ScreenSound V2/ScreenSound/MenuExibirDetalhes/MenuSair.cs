using ScreenSound.Modelos;
 
namespace ScreenSound.MenuExibirDetalhes
{
    internal class MenuSair : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas) 
        {
            Console.WriteLine("Adeus!");
        }
    }
}
