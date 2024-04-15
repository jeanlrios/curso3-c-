namespace Oficina.Desafio;

internal class Ajuste
{
    public Ajuste(string tipoAjuste, Mecanico mecanicoNome, Dono donoNome, Carro carroNome)
    {
        TipoAjuste = tipoAjuste;
        MecanicoNome = mecanicoNome;
        DonoNome = donoNome;
        CarroNome = carroNome;
    }

    public string TipoAjuste { get; }
    public Mecanico MecanicoNome { get; }
    public Dono DonoNome { get; }
    public Carro CarroNome { get; }
    public string DetalhesAjuste => $"Tipo de Ajuste: {TipoAjuste}\nCarro: {CarroNome.ModeloCarro}\nAno de Fabricação: {CarroNome.AnoCarro}\nCor do Carro: {CarroNome.CorCarro}\nMecânico responsável: {MecanicoNome.NomeMecanico}\nDono do Carro: {DonoNome.NomeDono}";
}