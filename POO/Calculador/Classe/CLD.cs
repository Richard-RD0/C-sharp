namespace Calculador.Classes
{
    public class Calculadora
    {
        public float numero1;

        public float numero2;


        public void Somar(float numero){
            numero = numero1 + numero2 ;
            Console.WriteLine(numero);
        }   
        
        public void Subtrair(float numero){
            numero = numero1 - numero2 ;
            Console.WriteLine(numero);
        }
            
        
        
        public void Multiplicar(float numero){
            numero = numero1 * numero2;
            Console.WriteLine(numero);
        }
        
        
        public void Dividir(float numero){
            numero = numero1 / numero2;
            Console.WriteLine(numero);
        }
    }
}