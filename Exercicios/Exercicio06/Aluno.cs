namespace Exercicio06
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }


        public Aluno(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
            Nota1 = 0.0;
            Nota2 = 0.0;
            Nota3 = 0.0;
        }

        public void RegistrarNotas(double nota1, double nota2, double nota3)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public double CalcularMedia()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }

        public bool VerificarAprovacao()
        {
            if (CalcularMedia() >= 7.0)
                return true;
            else
                return false;
        }
    }
}