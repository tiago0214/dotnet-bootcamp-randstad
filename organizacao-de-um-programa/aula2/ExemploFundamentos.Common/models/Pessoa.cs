using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.models
{
    /// <summary>
    /// Representa uma pessoa física
    /// </summary>
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        /// <summary>
        /// Faz uma pessoa se apresentar, dizend o nome e idade
        /// </summary>
        /// <param name="test">Um parametro qualquer</param>
        /// <param name="mesmo">Outro parametro</param>
        /// <returns>Retorna o texto, precisa colocar em um Console</returns>
        public string Apresentar(int test, int mesmo)
        {
            return $"Olá meu nome é {Nome} e, tenho {Idade} anos de idade";
        }

    }
}