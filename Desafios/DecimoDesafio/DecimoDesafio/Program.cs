using DecimoDesafio.FormaGeometrica;
using DecimoDesafio.Pagamento;
using DecimoDesafio.Veiculo;

Console.WriteLine("\nFormas\n");
Circulo circulo = new Circulo();
Retangulo retangulo = new Retangulo();
circulo.CalcularForma(8, 0);
retangulo.CalcularForma(10, 5);

Console.WriteLine("\nVeiculo\n");
Veiculo veiculo1 = new Veiculo();
veiculo1.Modelo = "Ferrari";
veiculo1.TipoVeiculo = "Carro";
veiculo1.Pilotar();
Veiculo veiculo2 = new Veiculo();
veiculo2.Modelo = "TBM900";
veiculo2.TipoVeiculo = "Avião";
veiculo2.Voar();

Console.WriteLine("\nPagamento\n");
Servico servico = new Servico(12);
servico.ValorDoProduto = 51;
servico.HorasDeServico = 4;
servico.CalcularPagamento();