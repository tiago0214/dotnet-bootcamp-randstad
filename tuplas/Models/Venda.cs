using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tuplas.Models
{
    public class Venda
    {
        public int Id { get; set; }
        required public string Produto { get; set; }
        public double Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}