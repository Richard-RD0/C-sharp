using Banco.Classes;

Console.Clear();

Console.WriteLine($"Bem vindo agiota");
Console.WriteLine();

ContaCR contaEmilly = new ContaCR();
ContaCR contaClara = new ContaCR();

contaEmilly.Titular = "Emilly";
contaEmilly.Depositar (100000);

contaClara.Titular = "Clara";
contaClara.Depositar (10000);

Console.WriteLine($"conta da {contaEmilly.Titular} tem R$ {contaEmilly.Saldo}");
Console.WriteLine($"conta da {contaClara.Titular} tem R$ {contaClara.Saldo}");

contaClara.sacar(2500f);

Console.WriteLine($"voce sacou e su conta ficou com R${contaClara.Saldo}");

