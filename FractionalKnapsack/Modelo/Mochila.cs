using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionalKnapsack.Modelo
{
    public class Mochila
    {
        private const int capacidade = 20; //20kg máximo
        public List<Diamante> Diamantes { get; set; }

        public Mochila()
        {
            Diamantes = new List<Diamante>();
        }
    }
}
