using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseOB.Classes
{
    public class Animal
    {
        public string Raca;
         public string Cor;

          public string Nome;

           public int Idade = 0;

           public void FazerBarulho(string Barulho ){
        Console.WriteLine($"som do animal {Barulho}");
           }

           public void Maisvelho(){
                Idade = Idade + 1;
           }
    }
}