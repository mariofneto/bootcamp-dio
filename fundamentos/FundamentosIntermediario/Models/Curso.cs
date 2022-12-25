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
            foreach (var aluno in Alunos)
            {
                Console.WriteLine($"{aluno.NomeCompleto}");
            }
            Console.WriteLine("------------------------");
        }
        public void ObterQuantidadeDeAlunosMatriculados()
        {
            Console.WriteLine("Temos essa quantidade de alunos no curso de " + Nome + ": " + Alunos.Count() + " alunos");
        }
    }
}