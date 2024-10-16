namespace tuplas.Models
{
    public class LeituraArquivo
    {
        public (bool Successo, string[] Linhas, int QuantidadeDeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] arquivo = File.ReadAllLines(caminho);
                return (true, arquivo, arquivo.Length);
            }
            catch (Exception)
            {
                return (false, new string[0], 0);
            }

        }

    }
}
