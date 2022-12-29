using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            var amigo = $@"
                                _
                               |_|
                             ___|___
                                |
                                |
                                |
                               / \
                              /   \";
            Console.Write($"Olá, meu nome é {Nome} e tenho {Idade} anos. {amigo}");

        }
    }
}