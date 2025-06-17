namespace Exercicio02
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }


        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEmEstoque = 0;
        }

        public void AdicionarEstoque(int quantidade)
        {
            QuantidadeEmEstoque += quantidade;
        }

        public void RemoverEstoque(int quantidade)
        {
            if (quantidade <= QuantidadeEmEstoque)
            {
                QuantidadeEmEstoque -= quantidade;
            }
            else
            {
                Console.WriteLine("Quantidade para remover do estoque precisa ser menor ou igual a Quantidade em Estoque atual.");
            }
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine("DETALHES DO PRODUTO:");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preco: {Preco:f2}");
            Console.WriteLine($"Quantidade em Estoque: {QuantidadeEmEstoque}");
        }
    }
}