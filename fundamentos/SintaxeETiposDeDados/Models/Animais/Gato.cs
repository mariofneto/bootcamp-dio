using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SintaxeETiposDeDados.Models.Animais
{
    public class Gato : Animal
    {
        public Gato(string nome, int idade, Pessoa pessoa)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Pessoa = pessoa;
        }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, eu sou um gato. Meu nome é {Nome}, tenho {Idade} anos e meu dono é o {Pessoa.Nome}");
        }
    }
}