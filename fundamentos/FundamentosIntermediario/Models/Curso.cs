using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosIntermediario.Models
{
    public class Curso
    {
        public Curso(string nome, List<Pessoa> alunos)
        {
            this.Nome = nome;
            this.Alunos = alunos;
        }
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
            => Alunos.Add(aluno);

        public void RemoverAluno(Pessoa aluno)
            => Alunos.Remove(aluno);

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {Nome}\n");
            for (int contador = 0; contador < Alunos.Count; contador++)
            {
                Console.WriteLine($"Nº{contador+1} - {Alunos[contador].NomeCompleto}");
            }
            Console.WriteLine("------------------------");
        }
        public void ObterQuantidadeDeAlunosMatriculados()
        {
            Console.WriteLine("Temos essa quantidade de alunos no curso de " + Nome + ": " + Alunos.Count() + " alunos");
        }
    }
}