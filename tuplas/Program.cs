using tuplas.Models;

LeituraArquivo arquivo = new LeituraArquivo();

var loja = arquivo.LerArquivo("./arquivoTest.txt");

Console.WriteLine(loja);

// everthing is a different ways of writing a tuple: tuples is a good way when I don't want to use class.

// var outroExemplo = Tuple.Create(1, "Tiago", "Souza");
// Console.WriteLine(outroExemplo.Item1);

// ValueTuple<int, string, string> outroExemplo = (1, "Tiago", "Souza");
// Console.WriteLine(outroExemplo.Item1);

// (int id, string nome, string sobreNome) tupla = (1, "Tiago", "Souza");
// Console.WriteLine(tupla.id);


// (int, string, string) tupla = (1, "Tiago", "Souza");
// Console.WriteLine(tupla.Item1);
