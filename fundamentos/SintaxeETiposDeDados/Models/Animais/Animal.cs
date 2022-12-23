using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SintaxeETiposDeDados.Models.Animais
{
    public class Animal
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public Pessoa Pessoa { get; set; }


        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, Eu sou um animal não expecificado. Meu nome é {Nome}, tenho {Idade} anos e meu dono é o {Pessoa.Nome}");
        }
    }
}