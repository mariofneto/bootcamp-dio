using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.Models
{
    public sealed class Professor : Pessoa
    {
        public Professor(string nome, int idade, decimal salario)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }

        public decimal Salario { get; set; }

        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}. Sou um Professor, meu salário é igual a {Salario}");
        }
    }
}