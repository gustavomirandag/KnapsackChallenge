using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionalKnapsack.Modelo
{
    public class Diamante
    {
        public string Nome { get; set; }
        public int Valor { get; set; }
        public int Peso { get; set; }

        public Diamante(string nome, int valor, int peso)
        {
            Nome = nome;
            Valor = valor;
            Peso = peso;
        }
    }
}
