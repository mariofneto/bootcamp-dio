using FundamentosIntermediario.Models;

var p1 = new Pessoa();
p1.Nome = "Mário";
p1.Sobrenome = "Neto";

var p2 = new Pessoa();
p2.Nome = "Eduardo";
p2.Sobrenome = "Neves";

var cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Curso De Inglês";
cursoDeIngles.Alunos = new List<Pessoa>(); //tem que instanciar a propriedade, eu estava esquecendo das instanciar as listas

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

cursoDeIngles.ObterQuantidadeDeAlunosMatriculados();


