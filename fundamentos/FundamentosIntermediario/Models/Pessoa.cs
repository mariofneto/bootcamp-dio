using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosIntermediario.Models
{
    // [links de ajuda]
    // [GET/SET PRIVADOS] https://www.w3schools.com/cs/cs_properties.php
    public class Pessoa
    {
        private string _nome;
        public string Nome
        {
            get => _nome.ToUpper();
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        private int _idade;
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade não pode ser menor que 0");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}