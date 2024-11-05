namespace AtividadesClasses.veiculos
{
    public class veiculos
    {
        public string marca;

        public string modelo;

        public string cor;

        public float potencia;

        public int qtdPortas;


        public void acelerar()
        {Console.WriteLine($"vrum vrum");
        }

        public void ligar()
        {Console.WriteLine($"vrum");}

        public void desligar()
        {Console.WriteLine($"desvrum");}

        public void freiar()
        {Console.WriteLine($"skrr");}
    }
}

