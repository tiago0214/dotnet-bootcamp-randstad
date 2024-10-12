using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Pessoa
    {
        public Pessoa() { }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public string? Nome;
        public int Idade;


        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, e tenho {Idade} anos.");
        }
    }
}