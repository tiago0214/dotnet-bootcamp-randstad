using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tuplas.Models
{
    // Class name can be anything. It doesn't matter what name it is. One thing to remember is, should be an static class and method.
    public static class IntExtentions
    {
        // this : means that I'm using the same value that is calling the method. // this string: significa que eu estou estendendo o comportamento da string
        public static void MeuMetodo(this string text)
        {
            // siginifica que eu acabei de extender o meu comportamento para o minhas strings. Ou seja, não somente a minha classe pode usar esse método, mas também toda string
            Console.WriteLine(text.ToUpper());
        }
    }
}

// metodo de extesão =: significa que eu posso extender o comportamento de um método para minha string