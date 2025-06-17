namespace Exercicio05
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double VelocidadeAtual { get; set; }

        public Carro(string marca, string modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            VelocidadeAtual = 0;
        }

        public void Acelerar(double incremento)
        {
            VelocidadeAtual += incremento;
        }

        public void Frear(double decremento)
        {
            if (decremento <= VelocidadeAtual)
            {
                VelocidadeAtual -= decremento;
            }
            else
            {
                Console.WriteLine("Decremento de velocidade precisa ser menor ou igual a velocidade atual.");
            }
        }

        public void ExibirStatus()
        {
            Console.WriteLine("DETALHES DO CARRO:");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Velocidade: {VelocidadeAtual:f1}");
        }
    }
}