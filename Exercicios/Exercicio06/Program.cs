using Exercicio06;

Aluno a1 = new Aluno("Icaro", "123456789");
a1.RegistrarNotas(7.0, 8.0, 9.0);
Console.WriteLine($"Média: {a1.CalcularMedia():f1}");
Console.WriteLine($"Aprovado: {a1.VerificarAprovacao()}");
