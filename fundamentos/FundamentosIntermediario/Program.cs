using FundamentosIntermediario.Models;

var p1 = new Pessoa("Mário", "Neto");
var p2 = new Pessoa("Eduardo", "Neves");
var p3 = new Pessoa("Julia", "Araujo");
var p4 = new Pessoa("Odila", "Zanela");

var cursoDeIngles = new Curso("Curso de Inglês", new List<Pessoa>());
var cursoDeEspanhol = new Curso("Curso de Espanhol", new List<Pessoa>());
/*
cursoDeIngles.Nome = "Curso De Inglês";
cursoDeIngles.Alunos = new List<Pessoa>(); //tem que instanciar a propriedade, eu estava esquecendo das instanciar as listas
*/
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
cursoDeIngles.ObterQuantidadeDeAlunosMatriculados();

cursoDeEspanhol.AdicionarAluno(p1);
cursoDeEspanhol.AdicionarAluno(p2);
cursoDeEspanhol.AdicionarAluno(p3);
cursoDeEspanhol.AdicionarAluno(p4);
cursoDeEspanhol.ListarAlunos();
cursoDeEspanhol.ObterQuantidadeDeAlunosMatriculados();


