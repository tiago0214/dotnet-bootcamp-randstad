using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tuplas.Models
{
    public class MeuArray<T>
    {
        private static int capacidade = 10;
        private T[] array = new T[capacidade];

        public T this[int i]
        {
            get => array[i];
            set => array[i] = value;
        }
    }
}