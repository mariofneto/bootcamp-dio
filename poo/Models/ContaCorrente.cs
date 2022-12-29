using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldo)
        {
            NumeroConta = numeroConta;
            this.saldo = saldo;
        }
        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Não tem dinheiro suficiente");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponível é {saldo}");
        }
    }
}