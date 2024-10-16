namespace tuplas.Models
{
  public class Pessoa
  {
    private string Nome { get; set; }
    private string SobreNome { get; set; }

    public Pessoa(string nome, string sobreNome)
    {
      Nome = nome;
      SobreNome = sobreNome;
    }

    public void Deconstruct(out string nome, out string sobreNome)
    {
      nome = Nome;
      sobreNome = SobreNome;
    }

    public void Apresentar()
    {
      Console.WriteLine($"Olá meu nome é: {Nome} e meu sobrenome é: {SobreNome}");
    }

  }
}