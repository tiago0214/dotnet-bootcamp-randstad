using ExemploFundamentos.Common.models;

Pessoa p = new Pessoa();
p.Apresentar(1, 1);

List<string> estados = new List<string>();

estados.Add("GO");
estados.Add("MG");
estados.Add("MT");

for (int contador = 0; contador < estados.Count; contador++)
{
  Console.WriteLine(estados[contador]);
};
