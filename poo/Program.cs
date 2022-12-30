using poo.Models;

// var pessoa = new Pessoa("Julia", 52);
// pessoa.Apresentar();

// var conta = new ContaCorrente(1, 1500.00M);
// conta.Sacar(1000.00M);
// conta.ExibirSaldo();

// [Herança de Pessoa]

// var pessoa = new Pessoa("Julia", 52);
// pessoa.Apresentar();

// var aluno = new Aluno("Felipe", 29, 7.5);
// aluno.Apresentar();

// var professor = new Professor("Eduardo", 54, 1500.00M);
// professor.Apresentar();

var cc = new Corrente();
cc.Creditar(1000);
cc.ExibirSaldo();
cc.Creditar(600);
cc.ExibirSaldo();




