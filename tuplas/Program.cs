using tuplas.Models;





int n = 11;
bool ehPar = n % 2 == 0;


Console.WriteLine($"O número {n} é {(ehPar ? "Par" : "Impar")}");



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
