using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosIntermediario.Models
{
    public class MeuArray<T>
    {
        private static int capacidade = 10;
        private int contador = 0;
        private T[] array = new T[capacidade];

        public void AdicionarElemento(T elemento)
        {
            if(contador + 1 < capacidade + 1)
                array[contador] = elemento;
            contador++;
        }

        public T this[int index]
        {
            get { return array [index];}
            set { array[index] = value;}
        }
        
    }
}