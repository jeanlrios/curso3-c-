namespace DecimoDesafio.Veiculo
{
    internal class Veiculo : IPilotavel, IVoavel
    {
        public string Modelo { get; set; }
        public string TipoVeiculo { get; set; }
        public void Pilotar()
        {
            Console.WriteLine($"O {TipoVeiculo} está pilotando");
        }
        public void Voar()
        {
            Console.WriteLine($"O {TipoVeiculo} está voando");
        }
    }
}
