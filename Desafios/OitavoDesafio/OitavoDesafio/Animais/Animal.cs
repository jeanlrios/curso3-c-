namespace OitavoDesafio.Animais
{
    internal class Animal
    {
        public string NomeAnimal { get; set; }
        public virtual void EmitirSomUrso(string som)
        {
            Console.WriteLine($"O {NomeAnimal} emite o seguinte som {som}");
        }
        public virtual void EmitirSomUrubu(string som)
        {
            Console.WriteLine($"O {NomeAnimal} emite o seguinte som {som}");
        }
        public virtual void EmitirSomPeixe(string som)
        {
            Console.WriteLine($"O {NomeAnimal} emite o seguinte som {som}");
        }
    }
}
