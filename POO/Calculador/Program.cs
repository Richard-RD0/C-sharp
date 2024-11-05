using Calculador.Classes;
Console.Clear();
Console.WriteLine("Bem vinda a Calculadora");

Calculadora calculadora = new Calculadora ();

Console.WriteLine($"Digite o primeiro numero: ");
calculadora.numero1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o segundo numero: ");
calculadora.numero2 = float.Parse(Console.ReadLine()!);

calculadora.Somar(0);
Console.WriteLine();

calculadora.Subtrair(0);
Console.WriteLine();

calculadora.Multiplicar(0);
Console.WriteLine();

calculadora.Dividir(0);
Console.WriteLine();

