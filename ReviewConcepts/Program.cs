using System.Security.AccessControl;

Console.Write(@"
  *******************************************
  !         Programa de cadastro            !                  
  +-----------------------------------------+
  !          Vamos programar! :)            !
  +*****************************************+");

Console.WriteLine();

Console.WriteLine($"ola, digite seu nome? ");
string nome = Console.ReadLine()!;

Console.WriteLine($"ola, {nome} digite seu sobrenome");
string sobrenome= Console.ReadLine()!;

Console.WriteLine($"ola qual a sua idade?");
UInt128 idade = UInt128.Parse (Console.ReadLine()!)

Console.WriteLine($"ola, digite seu Email");
string Email = Console.ReadLine()!;

Console.WriteLine($"ola, digite seu Telefone");
UInt128 Telefone = UInt128.Parse (Console.ReadLine()!);

Console.WriteLine($"ola, digite seu CPF");
UInt128 CPF =   UInt128.Parse (Console.ReadLine()!);

Console.WriteLine($"ola, digite seu Endereço");
string Endereço = Console.ReadLine()!;

Console.WriteLine($"ola, digite seu Estado Civil");
string EstadoCivil = Console.ReadLine()!;

Console.WriteLine($"em que ano voce nasceu");
int anoNascimento = int.Parse(Console.ReadLine()!);
int anoAtual = DateTime.Now.Year;
int idade = anoAtual - anoNascimento;

Console.Clear();
Console.WriteLine($"nome completo: {nome} {sobrenome}");
Console.WriteLine($"idade: {idade}");
Console.WriteLine($"anoNascimento: {anoNascimento}");
Console.WriteLine($"Telefone: {Telefone}");
Console.WriteLine($"CPF: {CPF}");
Console.WriteLine($"Endereço: {Endereço}");
Console.WriteLine($" EstadoCivil: { EstadoCivil}");


