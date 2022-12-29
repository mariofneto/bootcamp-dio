using poo.Models;

// var pessoa = new Pessoa("Julia", 52);
// pessoa.Apresentar();

var conta = new ContaCorrente(1, 1500.00M);
conta.Sacar(1000.00M);
conta.ExibirSaldo();

