//  ] DesafioLaco 01: Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
//O número de pessoas que responderam SIM;
//O número de pessoas que responderam NÃO;
//O número de mulheres que responderam SIM;
//A porcentagem de homens que responderam NÃO entre todos os homens analisados


Console.WriteLine(@"
*-----------------*
*  pesquisa da    *
*   empresa       *
*-----------------*
-----------------------------------------
*      ░░░░▄▄▄▄▀▀▀▀▀▀▀▀▄▄▄▄▄▄            *
*░░░░█░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░▀▀▄              *
*░░░█░░░▒▒▒▒▒▒░░░░░░░░▒▒▒░░█             *
*░░█░░░░░░▄██▀▄▄░░░░░▄▄▄░░░█             *
*░▀▒▄▄▄▒░█▀▀▀▀▄▄█░░░██▄▄█░░░█            *
*█▒█▒▄░▀▄▄▄▀░░░░░░░░█░░░▒▒▒▒▒█           *
*█▒█░█▀▄▄░░░░░█▀░░░░▀▄░░▄▀▀▀▄▒█          *  
*░█▀▄░█▄░█▀▄▄░▀░▀▀░▄▄▀░░░░█░░█           *
*░░█░░▀▄▀█▄▄░█▀▀▀▄▄▄▄▀▀█▀██░█            *
*░░░█░░██░░▀█▄▄▄█▄▄█▄████░█              *
*░░░░█░░░▀▀▄░█░░░█░███████░█             *
*░░░░░▀▄░░░▀▀▄▄▄█▄█▄█▄█▄▀░░█             *
*░░░░░░░▀▄▄░▒▒▒▒░░░░░░░░░░█              *
*░░░░░░░░░░▀▀▄▄░▒▒▒▒▒▒▒▒▒▒░█             *
*░░░░░░░░░░░░░░▀▄▄▄▄▄░░░░░█              *
-----------------------------------------*
*               BEM VINDO                *
-----------------------------------------");

int qtdGostadeProdutos = 0;
int qtdNaoGostadoProduto = 0;

int qtdHomem = 0;
int qtdMulher = 0;

Console.WriteLine($"quantas pessoas tem na sua empresa");
int qtddeEntrevistados = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= qtddeEntrevistados; i++){

    Console.WriteLine($"qual seu sexo? m/f");
    string sexo = Console.ReadLine()!;

    Console.WriteLine($"voce gostou do novo produto sim/nao?");
    string Produto = Console.ReadLine()!;

    if (sexo == "f")

    {
        qtdMulher++;
    }else
    {
        qtdHomem++;
    }

    if( Produto == "sim" ){
        qtdGostadeProdutos++;
    }

    else  {
    qtdNaoGostadoProduto++;
    }



} 
    float percentual = (100 / qtddeEntrevistados) * qtdGostadeProdutos;
    Console.WriteLine($"quantidade de mulheres: {qtdMulher}");
    Console.WriteLine($"quantidade de homens: {qtdHomem}");
    Console.WriteLine($"total de entrevistados: {qtdMulher + qtdHomem  }");
    Console.WriteLine($"total de pessoas que gostaram do produto:{qtdGostadeProdutos}");
    Console.WriteLine($"total de pessoas que nao gostaram do produto: {qtdNaoGostadoProduto}");
    Console.WriteLine($"porcentual de pessoas que gostaram do produto: { percentual}%");