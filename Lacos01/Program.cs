Console.WriteLine(@"
*------------------------*
*         Qual           *
*         Seu            *
*        Genero          *
*------------------------*                      
                                        ooooooooo
        oooooooo                        o........o    
       o........o                         o......o
      o........o     ooooooooooooooooo     o.....o
      o.......o  oooo ...............00000 o.....o
      o......o o      o...............o   o.....o

");

int qtdGostadeEsportes = 0;
int qtdNaoGostadeEsportes = 0;

int qtdHomem = 0;
int qtdMulher = 0;
Console.WriteLine($"quantas pessoas tem na sua mesa");
int qtddeEntrevistados = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= qtddeEntrevistados; i++){

    Console.WriteLine($"qual seu sexo? m/f");
    string sexo = Console.ReadLine()!;

    Console.WriteLine($"voce gosta de esportes sim/nao?");
    string esportes = Console.ReadLine()!;

    if (sexo == "f")

    {
        qtdMulher++;
    }else
    {
        qtdHomem++;
    }

    if( esportes == "sim" ){
        qtdGostadeEsportes++;
    }

    else  {
    qtdNaoGostadeEsportes++;
    }



} 
    float percentual = (100 / qtddeEntrevistados) * qtdGostadeEsportes;
    Console.WriteLine($"quantidade de mulheres: {qtdMulher}");
    Console.WriteLine($"quantidade de homens: {qtdHomem}");
    Console.WriteLine($"total de entrevistados: {qtdMulher + qtdHomem  }");
    Console.WriteLine($"total dde pessoas que gostam de esporte:{ qtdGostadeEsportes}");
    Console.WriteLine($"total dde pessoas que nao gostam de esporte: { qtdNaoGostadeEsportes}");
    Console.WriteLine($"porcentual de pessoas que gostam de esportes: { percentual}%");