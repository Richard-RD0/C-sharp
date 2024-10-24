Console.WriteLine(@"
------------------------------
*       Bem Vindos ao        *
*         FutResults         *
*----------------------------*          ");

int Real Madrid;
int Barcelona;

Console.WriteLine($"diga quantos gols o Real Madrid fez");
 Real Madrid = int.Parse (console.ReadLine());


Console.WriteLine($"diga quantos gols o Barcelona fez");
Barcelona = int.Parse (console.ReadLine());

if(Real Madrid > Barcelona)
{
    Console.WriteLine($"A vitoria e do Real Madrid");
}

else if (Real Madrid > Barcelona)
{
   Console.WriteLine($"A vitoria e do Barcelon");
}

else 

{
    Cosole.WriteLine("O resultado foi empate");
};
