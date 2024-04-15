namespace PetShop.Desafio;

internal class Dono
{
    public Dono(string nomeDono, List<Pet> petDono)
    {
        NomeDono = nomeDono;
        PetsDoDono = petDono;
    }

    public string NomeDono { get; }
    public List<Pet> PetsDoDono { get; } = [];
    public void AdicionarPet(Pet pet)
    {
        PetsDoDono.Add(pet);
    }
}