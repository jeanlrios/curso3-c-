namespace Oficina.Desafio;

internal class Dono
{
    public Dono(string nomeDono, List<Carro> carrosDono)
    {
        NomeDono = nomeDono;
        if (carrosDono == null )
        {
            CarrosDono = new List<Carro>();
        } else
        {
            CarrosDono = carrosDono;
        }
    }
    public string NomeDono { get;  }
    public List<Carro> CarrosDono { get;  }
}