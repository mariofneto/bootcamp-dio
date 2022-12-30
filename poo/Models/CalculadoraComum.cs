using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using poo.Interfaces;

namespace poo.Models
{
    public class CalculadoraComum : ICalculadora
    {
        public double Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}