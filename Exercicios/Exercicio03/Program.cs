using Exercicio03;

ContaBancaria cb1 = new ContaBancaria("123465789");
cb1.ConsultarSaldo();
cb1.Depositar(1652.87);
cb1.ConsultarSaldo();
Console.WriteLine($"Saque Realizado: {cb1.Sacar(500.00)}");
cb1.ConsultarSaldo();
