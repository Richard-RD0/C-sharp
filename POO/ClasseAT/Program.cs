using AtividadesClasses.veiculos;
Console.WriteLine("Bem vindo ao programa veiculos");

veiculos carro1 = new veiculos();

Console.WriteLine($"Digite a marca do carro");
carro1.marca = Console.ReadLine();

Console.WriteLine($"Digite o modelo do carro");
carro1.modelo = Console.ReadLine();

Console.WriteLine($"Digite a cor do carro");
carro1.cor = Console.ReadLine();

Console.WriteLine($"Digite a potência do carro");
carro1.potencia = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a quantidade de portas do carro");
carro1.qtdPortas = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Clear();


Console.WriteLine($"o carro é da marca {carro1.marca}");
Console.WriteLine($"o carro da {carro1.marca} é do modelo {carro1.modelo}");
Console.WriteLine($"o carro {carro1.modelo} tem a cor {carro1.cor}");
Console.WriteLine($"o carro {carro1.modelo} possui {carro1.potencia} cv de potencia");
Console.WriteLine($"o carro {carro1.modelo} tem {carro1.qtdPortas} portas");
Console.WriteLine();



Console.WriteLine($"O carro {carro1.modelo} ligando ");
carro1.ligar();
Console.WriteLine();


Console.WriteLine($"O carro {carro1.modelo} Acelerando ");
carro1.acelerar();
Console.WriteLine();


Console.WriteLine($"O carro {carro1.modelo} freiando ");
carro1.freiar();
Console.WriteLine();


Console.WriteLine($"O carro {carro1.modelo} desligando ");
carro1.desligar();
Console.WriteLine();




