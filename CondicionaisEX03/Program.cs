int lados;

Console.WriteLine($"Quantos lados iguais tem o triângulo (2, 3 ou 0)?");
lados = int.Parse(Console.ReadLine()!);

if(lados == 3) {
    Console.WriteLine($"Ele é um triângulo Equilátero");
}else if (lados == 2){
    Console.WriteLine($"Ele é um triângulo Isócele");
}else{
    Console.WriteLine($"Ele é umm  triângulo Escaleno");
}