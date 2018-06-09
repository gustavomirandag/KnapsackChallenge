using FractionalKnapsack.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionalKnapsack
{
    class Program
    {
        static void Main(string[] args)
        {
            Mochila minhaMochila; //Declaro a variável
            minhaMochila = new Mochila(); //Instancio a Mochila

            List<Diamante> casaOurives = new List<Diamante>();
            casaOurives.Add(new Diamante("Jubilee", 100000, 3)); //3kg de Safira
            casaOurives.Add(new Diamante("Centenary", 300000, 2)); //2kg de Rubi
            casaOurives.Add(new Diamante("Millennium Star", 1000000, 1)); //1kg de Rubi
            casaOurives.Add(new Diamante("Red Cross", 300000, 3)); //3kg de Red Cross
            casaOurives.Add(new Diamante("Diamante Vermelho", 50000, 8)); //8kg de Diamante Vermelho
            casaOurives.Add(new Diamante("Berílio", 20000, 10)); //10kg de Berílio
            casaOurives.Add(new Diamante("Benitoíte", 800000, 3)); //3kg de Benitoíte

            minhaMochila.PreencheMochilaValorMax(casaOurives);
            minhaMochila.ImprimirDiamantes();
            Console.WriteLine("Total carregado na mochila: R$" + minhaMochila.ObterValorTotal());

            Console.ReadLine();
        }
    }
}
