﻿//4) Escreva     um     programa     que     verifique     a     validade     de     uma     senha     fornecida pelo     usuário.     A     senha     válida     é     o     número     1234.    Devem     ser    impressas     as    seguintes     mensagens:     

   //- ACESSO    PERMITIDO    caso    a    senha    seja    válida.     
   //- ACESSO    NEGADO    caso    a    senha    seja    inválida

int Senha = 1234;
Console.WriteLine($"Digite sua Senha");
int ConfirmarSenha = int.Parse(Console.ReadLine()!);

if (Senha == ConfirmarSenha){
    Console.WriteLine($"ACESSO PERMITIDO");
}else{
    Console.WriteLine($"ACESSO NEGADO");
};
