using SetimoDesafio.Contas;

ContaCorrente conta1 = new ContaCorrente();
conta1.Nome = "Jean";
conta1.Numero = 65656;
conta1.Saldo = 5000;
conta1.MostrarSaldo(conta1.Saldo);

ContaPoupanca conta2 = new ContaPoupanca();
conta2.Nome = "Lucas";
conta2.Numero = 87884;
conta2.Saldo = 7000;
conta2.MostrarSaldo(conta2.Saldo);