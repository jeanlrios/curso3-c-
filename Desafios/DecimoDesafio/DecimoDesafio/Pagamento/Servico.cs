namespace DecimoDesafio.Pagamento
{
    internal class Servico : Produto, IPagavel
    {
        public Servico(double valorDaHora)
        {
            ValorDaHora = valorDaHora;
        }

        public int HorasDeServico { get; set; }
        public double ValorDaHora { get; }

        public void CalcularPagamento()
        {
            int horasDeServico = HorasDeServico;
            double valorDaHora = HorasDeServico * ValorDaHora;
            double valorDoProduto = ValorDoProduto;
            double valorPagamento = valorDoProduto + valorDaHora;
            Console.WriteLine($"Valor do produto: R${valorDoProduto}\nTotal de horas: {horasDeServico}h (R${ValorDaHora}/h)\nValor total: R${valorPagamento}\n");
        }
    }
}