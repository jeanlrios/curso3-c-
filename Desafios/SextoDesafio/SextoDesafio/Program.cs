using SextoDesafio.Empresa;

Gerente gerente = new Gerente();
gerente.Nome = "José";
gerente.Salario = 22000;
gerente.Setor = "Comercial";
Console.WriteLine(gerente.Detalhes);

Programador programador = new Programador();
programador.Nome = "João";
programador.Salario = 7000;
programador.LinguagemProgramação = "C#";
Console.WriteLine(programador.Detalhes);

Analista analista = new Analista();
analista.Nome = "Junior";
analista.Salario = 4500;
analista.AreaDeAtuação = "Suporte";
Console.WriteLine(analista.Detalhes);