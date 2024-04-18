namespace SetimoDesafio.Contas
{
    internal class ContaPoupanca : Conta
    {
        public double Saldo { get; set; }
        public override void MostrarSaldo(double saldo)
        {
            base.MostrarSaldo(saldo);
        }
    }
}
