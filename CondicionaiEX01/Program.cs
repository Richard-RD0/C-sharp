Console.WriteLine($"entre com o valor do salario");
float salario = float.Parse (Console.ReadLine()!);

Console.WriteLine($"entre com o valor do gasto");
float gasto = float.Parse (Console.ReadLine()!);

if (salario > gasto)

{
    Console.WriteLine($"gasto dentro do orcamento");
}

else

{
    Console.WriteLine($"orcamento estourado"); 
}