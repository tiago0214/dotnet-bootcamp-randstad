
namespace POO.Models
{
    public class Aluno : Pessoa
    {
        public Aluno() { }

        public Aluno(string nome) : base(nome) { }

        public double Nota;

        public override void Apresentar()
        {
            Console.WriteLine("Chamei");
            base.Apresentar();
        }
    }
}