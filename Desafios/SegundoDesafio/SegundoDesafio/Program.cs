using PetShop.Desafio;
// 1. Modelar um Pet Shop com classes como Pet, Dono, Consulta e médico.
Pet pet1 = new("Rex", "Cachorro", 4);
Pet pet2 = new("Kitty", "Gato", 2);

Dono dono1 = new("Jean", new([pet1, pet2]));

Medico medico1 = new("Lucas");

Consulta consulta1 = new("Consulta Geral", medico1, pet1, dono1);
Consulta consulta2 = new("Banho", medico1 , pet2, dono1);
Console.WriteLine(consulta1.DetalhesConsulta);
Console.WriteLine(consulta2.DetalhesConsulta);