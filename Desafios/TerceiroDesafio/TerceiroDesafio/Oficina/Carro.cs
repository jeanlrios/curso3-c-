namespace Oficina.Desafio;

internal class Carro
{
    public Carro(string modeloCarro, int anoCarro, string corCarro)
    {
        ModeloCarro = modeloCarro;
        AnoCarro = anoCarro;
        CorCarro = corCarro;
    }

    public string ModeloCarro { get; }
    public int AnoCarro { get; }
    public string CorCarro { get; }
}