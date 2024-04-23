namespace DecimoDesafio.Pagamento
{
    internal class Produto : IPagavel
    {
        public double ValorDoProduto { get; set; }
        public void CalcularPagamento()
        {
            double valorDoProduto = ValorDoProduto;
        }
    }
}
