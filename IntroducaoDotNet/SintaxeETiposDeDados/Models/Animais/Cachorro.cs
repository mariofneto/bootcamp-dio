using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SintaxeETiposDeDados.Models.Animais
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome, int idade, Pessoa pessoa)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Pessoa = pessoa;
        }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, Eu sou um cachorro. Meu nome é {Nome}, tenho {Idade} anos e meu dono é o {Pessoa.Nome}");
        }
        public void Latir()
        {
            Console.WriteLine("AU AU AU AU");
        }

        public void Deitar()
        {
            Console.WriteLine("o cãozinho deitou");
        }
    }
}