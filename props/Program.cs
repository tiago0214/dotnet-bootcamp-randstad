// using props.Models;
// using System.Globalization;





Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("pr", "Parana");
estados.Add("go", "Goias");
estados.Add("sp", "São Paulo");

foreach (KeyValuePair<string, string> item in estados)
{
  Console.WriteLine(item.Key);
}







// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//   Console.WriteLine(item);
// }


// Console.WriteLine($"Removendo {fila.Dequeue()}");


// foreach (int item in fila)
// {
//   Console.WriteLine(item);
// }









// DateTime data = DateTime.Parse("01/12/2010");
// int n = 12312;


// Console.WriteLine(data);


// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// // Pessoa p = new Pessoa();

// // p.Nome = "Tiago";
// // p.Idade = 30;
// // p.Apresentar();

// double porcetagem = .3421;

// Console.WriteLine(porcetagem.ToString("P"));

// decimal valorMonetario = 40.89m;

// Console.WriteLine($"{valorMonetario:C}");