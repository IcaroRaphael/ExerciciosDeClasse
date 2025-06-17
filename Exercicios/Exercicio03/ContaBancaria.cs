namespace Exercicio03
{
    public class ContaBancaria
    {
        public string NumeroConta { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(string numeroConta)
        {
            NumeroConta = numeroConta;
            Saldo = 0;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Saldo: {Saldo}");
        }
    }
}
