namespace PetShop.Desafio;

internal class Consulta
{
    public Consulta(string tipoConsulta, Medico medicoConsulta, Pet petConsulta, Dono donoConsulta)
    {
        TipoConsulta = tipoConsulta;
        MedicoConsulta = medicoConsulta;
        PetConsulta = petConsulta;
        DonoConsulta = donoConsulta;
    }

    public string TipoConsulta { get; }
    public Medico MedicoConsulta { get; }
    public Pet PetConsulta { get; }
    public Dono DonoConsulta { get; }
    public string DetalhesConsulta => $"Motivo da Consulta: {TipoConsulta}\nMédico: {MedicoConsulta.NomeMedico}\nPet: {PetConsulta.NomePet} - {PetConsulta.IdadePet} anos ({PetConsulta.RacaPet})\nDono do Pet: {DonoConsulta.NomeDono}\n";
}