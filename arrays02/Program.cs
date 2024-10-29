//  ] DesafioArray01: Faça um programa que carregue 1 array tamanho 6 com números inteiros. Calcule e imprima a quantidade de números ímpares e a quantidade de números pares.

int [] numeros = new int [6];
int Par = 0, Impar = 0 ;

for (int i = 0; i < numeros.Length; i++){

    Console.WriteLine($"digite um {i + 1}º numero");
    int NumeroDigitado = int .Parse (   Console.ReadLine()!);
    numeros[i] = NumeroDigitado;

    if (NumeroDigitado % 2 == 0)
    {
        Par++;
    }

    else{
        Impar++;
    }
}
Console.Clear();
Console.WriteLine($"{Par} numero(s) par(es)");

Console.WriteLine();

Console.WriteLine($"numero(s) par(es)");

for (int i = 0; i < numeros.Length ; i++)
{
  if (numeros[i] % 2 == 0)
     {
        Console.Write($"{numeros[i]} ");
     }

}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($" {Impar} numero(s) impar(es) ");
for(int i = 0; i < numeros.Length; i++){

    if (numeros [i] % 2 == 1){

        Console.Write($"{numeros[i]} ");
    }
}
Console.WriteLine();