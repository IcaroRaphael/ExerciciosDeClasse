namespace Exercicio01
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }

        public Pessoa(string nome, int idade, double altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }

        public string Apresentar()
        {
            return string.Format($"Olá, meu nome é {Nome}, tenho {Idade} anos e {Altura}m de altura.");
        }
    }
}