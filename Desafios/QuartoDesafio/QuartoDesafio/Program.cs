void Calculadora() {
    Titulo("Calculadora");
    Console.WriteLine("Agora escolha a operação que deseja realizar:\n");
    Console.WriteLine("Adição: Digite +\nSubtração: Digite -\nDivisão: Digite /\nMultiplicação: Digite *\n");
    Console.Write("Qual operação deseja? ");
    string operaçãoEscolhida = Console.ReadLine()!;
    switch (operaçãoEscolhida)
    {
        case "+": RealizarAdicao();
            break;
        case "-": RealizarSubtracao();
            break;
        case "/": RealizarDivisao();
            break;
        case "*": RealizarMultiplicacao();
            break;
        default:
            Console.WriteLine("Opção invalida!");
            break;
    }
}

int resultado = 0;

void RealizarAdicao()
{
    Console.Clear();
    Titulo("Adição");
    Console.Write("Informe o primeiro valor: ");
    int primeiroValor = int.Parse(Console.ReadLine()!);
    Console.Write("Informe o segundo valor: ");
    int segundoValor = int.Parse(Console.ReadLine()!);
    resultado = (primeiroValor + segundoValor);
    Console.WriteLine($"\nO valor calculado é {resultado}\n");
    VoltarMenu();
}

void RealizarSubtracao()
{
    Console.Clear();
    Titulo("Subtração");
    Console.Write("Informe o primeiro valor: ");
    int primeiroValor = int.Parse(Console.ReadLine()!);
    Console.Write("Informe o segundo valor: ");
    int segundoValor = int.Parse(Console.ReadLine()!);
    resultado = (primeiroValor - segundoValor);
    Console.WriteLine($"\nO valor calculado é {resultado}\n");
    VoltarMenu();
}

void RealizarDivisao()
{
    Console.Clear();
    Titulo("Divisão");
    Console.Write("Informe o primeiro valor: ");
    int primeiroValor = int.Parse(Console.ReadLine()!);
    Console.Write("Informe o segundo valor: ");
    int segundoValor = int.Parse(Console.ReadLine()!);
    resultado = (primeiroValor / segundoValor);
    Console.WriteLine($"\nO valor calculado é {resultado}\n");
    VoltarMenu();
}

void RealizarMultiplicacao()
{
    Console.Clear();
    Titulo("Multiplicação");
    Console.Write("Informe o primeiro valor: ");
    int primeiroValor = int.Parse(Console.ReadLine()!);
    Console.Write("Informe o segundo valor: ");
    int segundoValor = int.Parse(Console.ReadLine()!);
    resultado = (primeiroValor * segundoValor);
    Console.WriteLine($"\nO valor calculado é {resultado}\n");
    VoltarMenu();
}

void VoltarMenu()
{
    Thread.Sleep(1000);
    Console.WriteLine("Para voltar ao menu digite qualquer tecla");
    Console.ReadKey();
    Console.Clear();
    Calculadora();
}

void Titulo(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '-');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

Calculadora();