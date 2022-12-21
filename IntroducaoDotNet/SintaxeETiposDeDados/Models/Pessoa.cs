using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SintaxeETiposDeDados.Models.Animais;

namespace SintaxeETiposDeDados.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public Pessoa(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public Cachorro Cachorro { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}