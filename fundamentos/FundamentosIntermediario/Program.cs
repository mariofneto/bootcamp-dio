using FundamentosIntermediario.Models;

var p1 = new Pessoa("Mário", "Neto");
var p2 = new Pessoa("Eduardo", "Neves");
var p3 = new Pessoa("Julia", "Araujo");
var p4 = new Pessoa("Odila", "Zanela");

Console.WriteLine("Digite um nome: ");
var nome = Console.ReadLine();
Console.WriteLine("Digite um sobrenome: ");
var sobrenome = Console.ReadLine();
var pessoaEspecial = new Pessoa(nome, sobrenome);

Console.WriteLine("Digite um Curso: ");
var nomeCurso = Console.ReadLine();

var cursoEspecial = new Curso(nomeCurso, new List<Pessoa>());

var cursoDeIngles = new Curso("Curso de Inglês", new List<Pessoa>());
var cursoDeEspanhol = new Curso("Curso de Espanhol", new List<Pessoa>());
/*
cursoDeIngles.Nome = "Curso De Inglês";
cursoDeIngles.Alunos = new List<Pessoa>(); //tem que instanciar a propriedade, eu estava esquecendo das instanciar as listas
*/

cursoEspecial.AdicionarAluno(pessoaEspecial);
cursoEspecial.ListarAlunos();
cursoEspecial.ObterQuantidadeDeAlunosMatriculados();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(pessoaEspecial);
cursoDeIngles.ListarAlunos();
cursoDeIngles.ObterQuantidadeDeAlunosMatriculados();

cursoDeEspanhol.AdicionarAluno(p1);
cursoDeEspanhol.AdicionarAluno(p2);
cursoDeEspanhol.AdicionarAluno(p3);
cursoDeEspanhol.AdicionarAluno(p4);
cursoDeEspanhol.ListarAlunos();
cursoDeEspanhol.RemoverAluno(p2);
cursoDeEspanhol.ListarAlunos();
cursoDeEspanhol.ObterQuantidadeDeAlunosMatriculados();



