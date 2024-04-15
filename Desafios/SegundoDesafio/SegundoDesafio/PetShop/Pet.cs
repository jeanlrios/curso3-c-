namespace PetShop.Desafio;

internal class Pet
{
    public Pet(string nomePet, string racaPet, int idadePet)
    {
        NomePet = nomePet;
        RacaPet = racaPet;
        IdadePet = idadePet;
    }

    public string NomePet { get; }
    public string RacaPet { get; }
    public int IdadePet { get; }
}