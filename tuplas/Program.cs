using tuplas.Models;
using Newtonsoft.Json;





string conteudoArquivo = File.ReadAllText("Vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

var listaAnonima = listaVenda.Select(x => new { x.Produto, x.Preco });



foreach (var item in listaAnonima)
{
  Console.WriteLine("{");
  Console.WriteLine(" " + item.Produto);
  Console.WriteLine(" " + item.Preco);
  Console.WriteLine("}");

}










// // tipos anonimos
// var tipoAnonimo = new { Nome = "Tiago", Idade = 30 };

// Console.WriteLine(tipoAnonimo.Nome);
// Console.WriteLine(tipoAnonimo.Idade);








// bool? desejaReceberImail = true;


// if (desejaReceberImail.HasValue && desejaReceberImail.Value)
// {
//   Console.WriteLine("User want to receive email");
// }
// else
// {
//   Console.WriteLine("User don't want to receive email");
// }




// string conteudoArquivo = File.ReadAllText("Vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda item in listaVenda)
// {
//   Console.WriteLine($"{{\n  Id:{item.Id}\n  Produto : {item.Produto}\n  Preço: {item.Preco}\n  Data de Venda: {item.DataVenda}\n  {(item.Desconto.HasValue ? $"Desconto: {item.Desconto}\n" : "")}}}");
// }













// string conteudoArquivo = File.ReadAllText("Vendas.json");

// // o nome das propriedades da minha classe tem que ser exatamente as mesma do meu arquivo que eu estou mapeando, caso contrário, o valor do campo vai ficar vazio.
// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda item in listaVenda)
// {
//   Console.WriteLine($"{{\n  Id:{item.Id}\n  Produto : {item.Produto}\n  Preço: {item.Preco}\n  Data de Venda: {item.DataVenda}\n}}");
// }

// Venda v1 = new Venda();
// v1.Produto = "Algo";

// Console.WriteLine(v1.Produto);




// List<Venda> vendas = new List<Venda>();

// DateTime dataAtual = DateTime.Now;

// Venda v1 = new Venda(1, "Material para construção", 300.00M, dataAtual);
// Venda v2 = new Venda(1, "Software", 700.00M, dataAtual);

// vendas.Add(v1);
// vendas.Add(v2);

// foreach (Venda item in vendas)
// {
//   Console.WriteLine(item.DataVenda);
// }

// string serialize = JsonConvert.SerializeObject(vendas);

// File.WriteAllText("Vendas.json", serialize);



// int n = 11;
// bool ehPar = n % 2 == 0;


// Console.WriteLine($"O número {n} é {(ehPar ? "Par" : "Impar")}");



// Pessoa p = new Pessoa("Tiago", "Souza");
// p.Apresentar();

// // desconstruindo o retorno da classe;
// (string nome, string sobreNome) = p;

// Console.WriteLine(nome);














// LeituraArquivo arquivo = new LeituraArquivo();

// // descontruindo a tupla
// var (sucesso, linhas, quantidadeDeLinhas) = arquivo.LerArquivo("./arquivoTest.txt");

// // Posso utilizar o operador de discarte _
// // var (sucesso, linhas, _) = arquivo.LerArquivo("./arquivoTest.txt");

// if (sucesso)
// {
//   Console.WriteLine("Quantidade de linhas do arquivo: " + quantidadeDeLinhas);

//   foreach (string linha in linhas)
//   {
//     Console.WriteLine(linha);
//   }
// }
// else
// {
//   Console.WriteLine("Erro ao ler o arquivo");
// }










// everthing is a different ways of writing a tuple: tuples is a good way when I don't want to use class.

// var outroExemplo = Tuple.Create(1, "Tiago", "Souza");
// Console.WriteLine(outroExemplo.Item1);

// ValueTuple<int, string, string> outroExemplo = (1, "Tiago", "Souza");
// Console.WriteLine(outroExemplo.Item1);

// (int id, string nome, string sobreNome) tupla = (1, "Tiago", "Souza");
// Console.WriteLine(tupla.id);


// (int, string, string) tupla = (1, "Tiago", "Souza");
// Console.WriteLine(tupla.Item1);
