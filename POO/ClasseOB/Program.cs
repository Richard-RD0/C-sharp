
//importante das classes de dentro da pasta Classes.


using ClasseOB.Classes;
Console.Clear();
Animal Cachorro = new Animal();

Cachorro.Nome = "Thor";
Cachorro.Raca = "Pitbull";
Cachorro.Cor = "Cinza e Marrom";
Cachorro.Idade = 1;


// Console.WriteLine($"Nome do Cachorrinho: {Cachorro.Nome}");
// Console.WriteLine($"Raca do Cachorrinho {Cachorro.Nome}: {Cachorro.Raca}");
// Console.WriteLine($"Cor do Cachorrinho {Cachorro.Nome}: {Cachorro.Cor}");
// Console.WriteLine($"Idade do {Cachorro.Nome}: {Cachorro.Idade}");
// Console.WriteLine($"o {Cachorro.Nome} ele faz {Cachorro.fazerBarulho}");


Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Animal Gato = new Animal();
 

 Gato.Nome = "Safira";
Gato.Raca = "Gato";
Gato.Cor = "Laranja";
Gato.Idade = 2;


// Console.WriteLine($"Nome do Gato: {Gato.Nome}");
// Console.WriteLine($"Raca do {Gato.Nome}: {Gato.Raca}");
// Console.WriteLine($"Cor do  {Gato.Nome}: {Gato.Cor}");
// Console.WriteLine($"Idade do {Gato.Nome}: {Gato.Idade}"); 
// Console.WriteLine($"o {Gato.Nome} ela faz {Gato.fazerBarulho}");
// Console.WriteLine(@"

//   ∧,,,∧
// (  ̳• · • ̳)
// /    づ♡ I love you


// ");
Gato.FazerBarulho("miau, miau, miau");
Console.WriteLine($"a idade da {Gato.Nome} antiga  é {Gato.Idade}");
Console.WriteLine();

Gato.Maisvelho();
Console.WriteLine($"aidade da {Gato.Nome} agora e {Gato.Idade}");
Console.WriteLine();

Cachorro.FazerBarulho("au, au, au");
Console.WriteLine($"a idade do {Cachorro.Nome}  antiga e {Cachorro.Idade}");
Console.WriteLine();


Cachorro.Maisvelho();
Console.WriteLine($"a idade do {Cachorro.Nome}  agora e {Cachorro.Idade}");

