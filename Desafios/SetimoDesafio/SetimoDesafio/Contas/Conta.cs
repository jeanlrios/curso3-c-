namespace SetimoDesafio.Contas
{
    internal class Conta
    {
        public string Nome { get; set; }
        public int Numero { get; set; }
        public virtual void MostrarSaldo(double saldo)
        {
            Console.WriteLine($"Titular: {Nome}\nConta: {Numero}\nSaldo: R$" + saldo + "\n");
        } 
    }
}
