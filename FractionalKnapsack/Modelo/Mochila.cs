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
        private List<Diamante> _diamantes;

        public Mochila()
        {
            _diamantes = new List<Diamante>();
        }

        public int ObterPesoTotal()
        {
            //Retorna a quantidade total de quilos de diamante.
            int pesoTotal = 0; //Em quilos
            for (int i=0; i<_diamantes.Count; i++)
            {
                pesoTotal += _diamantes[i].Peso;
            }

            return pesoTotal;
        }

        public int ObterValorTotal()
        {
            int valorTotal = 0; //Em quilos
            for (int i = 0; i < _diamantes.Count; i++)
            {
                valorTotal += _diamantes[i].Peso* _diamantes[i].Valor;
            }
            return valorTotal;
        }

        public void ImprimirDiamantes()
        {

            for (int i = 0; i < _diamantes.Count; i++)
            {
                Console.WriteLine($"{_diamantes[i].Nome} - R${_diamantes[i].Valor} - {_diamantes[i].Peso}kg ");
            }
        }

        public bool Adicionar(Diamante diamante)
        {
            //Já estou na capacidade máxima
            if (ObterPesoTotal() == capacidade)
                return false;

            //Ajusto se não da para colocar o objeto todo
            if (ObterPesoTotal() + diamante.Peso > capacidade)
            {
                diamante.Peso = capacidade - ObterPesoTotal();
            }

            _diamantes.Add(diamante);
            return true; //Conseguiu adicionar
        }

        public void PreencheMochilaValorMax(List<Diamante> diamantes)
        {
            BubbleSortDecrescente(diamantes);
            foreach (var diamante in diamantes)
                Adicionar(diamante);
        }

        public void BubbleSortDecrescente(List<Diamante> diamantes)
        {
            for (int i=0; i<diamantes.Count; i++)
            {
                for (int j=0; j<diamantes.Count-i-1; j++)
                {
                    if (diamantes[j].Valor < diamantes[j + 1].Valor)
                    {
                        Diamante aux;
                        aux = diamantes[j + 1];
                        diamantes[j + 1] = diamantes[j];
                        diamantes[j] = aux;
                    }
                }
            }
        }
    }
}
