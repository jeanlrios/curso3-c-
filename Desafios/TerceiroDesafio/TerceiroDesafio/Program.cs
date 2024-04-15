// 2. Modelar o funcionamento de uma oficina automobilistica.
using Oficina.Desafio;

Carro carro = new Carro("UNO", 1997, "Prata");
Dono dono = new Dono("Jean", new List<Carro> { carro });
Mecanico mecanico = new Mecanico("Lucas");
Ajuste ajuste = new Ajuste("Revisão", mecanico, dono, carro);
Console.WriteLine(ajuste.DetalhesAjuste);
