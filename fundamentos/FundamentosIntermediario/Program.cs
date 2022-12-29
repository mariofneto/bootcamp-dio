using System.Globalization;
using FundamentosIntermediario.Models;
using Newtonsoft.Json;
// Console.Clear();
// var p1 = new Pessoa("Mário", "Neto");
// var p2 = new Pessoa("Eduardo", "Neves");
// var p3 = new Pessoa("Julia", "Araujo");
// var p4 = new Pessoa("Odila", "Zanela");

// Console.WriteLine("Digite um nome: ");
// var nome = Console.ReadLine();
// Console.WriteLine("Digite um sobrenome: ");
// var sobrenome = Console.ReadLine();
// var pessoaEspecial = new Pessoa(nome, sobrenome);

// Console.WriteLine("Digite um Curso: ");
// var nomeCurso = Console.ReadLine();

// var cursoEspecial = new Curso(nomeCurso, new List<Pessoa>());

// var cursoDeIngles = new Curso("Curso de Inglês", new List<Pessoa>());
// var cursoDeEspanhol = new Curso("Curso de Espanhol", new List<Pessoa>());
// /*
// cursoDeIngles.Nome = "Curso De Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>(); //tem que instanciar a propriedade, eu estava esquecendo das instanciar as listas
// */
// Console.Clear();
// cursoEspecial.AdicionarAluno(pessoaEspecial);
// cursoEspecial.ListarAlunos();
// cursoEspecial.ObterQuantidadeDeAlunosMatriculados();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.AdicionarAluno(pessoaEspecial);
// cursoDeIngles.ListarAlunos();
// cursoDeIngles.ObterQuantidadeDeAlunosMatriculados();

// cursoDeEspanhol.AdicionarAluno(p1);
// cursoDeEspanhol.AdicionarAluno(p2);
// cursoDeEspanhol.AdicionarAluno(p3);
// cursoDeEspanhol.AdicionarAluno(p4);
// cursoDeEspanhol.ListarAlunos();
// cursoDeEspanhol.RemoverAluno(p2);
// cursoDeEspanhol.ListarAlunos();
// cursoDeEspanhol.ObterQuantidadeDeAlunosMatriculados();

// var valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("C"));

// var porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// var dataString = "2022-04-20 18:00";
// var dataAtual = DateTime.Now;
// var dataConvertida = DateTime.TryParse(dataString, out dataAtual);
// Console.WriteLine(dataAtual);
// Console.WriteLine(dataAtual.ToString("[dd/MM/yyyy]-[HH:mm:ss]"));

// try
// {
//     Console.Clear();
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (var linha in linhas)
//     {
//         Console.WriteLine($"Linha {linha}");
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"[ERRO] Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"[ERRO] Diretório não encontrado. {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"[ERRO] Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("---------------------------");
//     Console.WriteLine("Dando erro ou não sempre vai chegar aqui no [finally]");
// }

// var exemplo = new ExemploExcecao();

// exemplo.Metodo1();

// Fila no C# [FIFO]

// var fila = new Queue<int>();

// fila.Enqueue(11);
// fila.Enqueue(22);
// fila.Enqueue(33);
// fila.Enqueue(44);

// foreach (var item in fila)
//     Console.WriteLine(item);

// Console.WriteLine("------------------------");

// fila.Dequeue();
// fila.Dequeue();

// foreach (var item in fila)
//     Console.WriteLine(item);

// Pilha no C# [LIFO]

// var pilha = new Stack<int>();

// pilha.Push(2);
// pilha.Push(54);
// pilha.Push(232);
// pilha.Push(21);

// foreach(var item in pilha)
//     Console.WriteLine(item);

// Console.WriteLine("------------------------");

// pilha.Pop();
// pilha.Pop();

// foreach(var item in pilha)
//     Console.WriteLine(item);

// Dictionary no C# [Garante que suas chaves sejam unicas]

// var estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("MG", "Minas Gerais");
// estados.Add("RJ", "Rio De Janeiro");

// foreach (var estado in estados)
//     Console.WriteLine($"Chave: {estado.Key}, Valor: {estado.Value}");

// Console.WriteLine("----------");

// estados.Remove("MG");
// estados["SP"] = "São Paulo - valor alterado";

// foreach (var estado in estados)
//     Console.WriteLine($"Chave: {estado.Key}, Valor: {estado.Value}");

// Exemplo de Tupla [São variáveis que armazena muitos items se for requerido]

// (int, string, string, decimal) tupla = (10, "Mário", "Neto", 1.77M);

// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");

// var ler = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = ler.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     // Console.WriteLine($"Quantidade de linhas no arquivo: {quantidadeLinhas}");
//     foreach (var linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }

// IF NÃO TERNÁRIO

// if(numero % 2 == 0)
// {
//     Console.Clear();
//     Console.Write($"{numero} é par");
// }
// else
// {
//     Console.Clear();
//     Console.Write($"{numero} é impar");
// }


// IF TERNÁRIO

// var numero = 20;
// var ehPar = false;

// ehPar = numero % 2 == 0;

// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));


// Usando [JSON] Serializando

// var dataAtual = DateTime.Now;

// var vendas = new List<Venda>();

// var venda1 = new Venda(1, "Martelo", 25.00M, dataAtual);
// var venda2 = new Venda(2, "Pregos", 2.00M, dataAtual);
// var venda3 = new Venda(3, "Serrotes", 40.00M, dataAtual);
// var venda4 = new Venda(4, "Porcas", 28.00M, dataAtual);

// vendas.Add(venda1);
// vendas.Add(venda2);
// vendas.Add(venda3);
// vendas.Add(venda4);

// var listaSerializada = JsonConvert.SerializeObject(vendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", listaSerializada);

// Console.WriteLine(listaSerializada);

// Usando [JSON] Deserializando

// var conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// var listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (var venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preco: {venda.Preco}, Data: {venda.DataVenda}");
// }

// bool? desejarReceberEmail = null;

// var saudacao = desejarReceberEmail.HasValue ? "Fala comigo true" : "Fala comigo null";
// Console.WriteLine(saudacao);

// Tipo Dynamic

// dynamic variavelDinamica = 4;
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
// variavelDinamica = "testando";
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
// variavelDinamica = true;
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// Tipos Genéricos <T>

// var arrayDeStrings = new MeuArray<string>();

// arrayDeStrings.AdicionarElemento("Mário");
// arrayDeStrings.AdicionarElemento("Júlia");
// arrayDeStrings.AdicionarElemento("Odila");

// Console.WriteLine(arrayDeStrings[0]);
// Console.WriteLine(arrayDeStrings[1]);
// Console.WriteLine(arrayDeStrings[2]);

// var arrayDeInt = new MeuArray<int>();

// arrayDeInt.AdicionarElemento(22);
// arrayDeInt.AdicionarElemento(554);
// arrayDeInt.AdicionarElemento(96);

// Console.WriteLine(arrayDeInt[0]);
// Console.WriteLine(arrayDeInt[1]);
// Console.WriteLine(arrayDeInt[2]);

// Métodos de extensão

// int numero = 15;
// bool par = false;

// par = numero.EhPar();

// Console.WriteLine(par);

// decimal salario = 2000M;
// bool salarioBom = false;

// salarioBom = salario.SalarioBom();

// Console.WriteLine(salarioBom);

// Conceitos Teóricos

// Stack e Heap

// Stack => quando declaro uma variável ela vai para o Stack(é armazenado o nome e o valor que representa)

// Heap => armazena o próprio objeto do tipo mais complexo(objeto referencia fica na stack e o original na heap)

// Garbage Collector => é quem limpa a memória Heap

// Atribuindo tipo de valor
// // um cria uma cópia do outro

// var a = 5;
// var b = a;

// Console.WriteLine("Antes da alteração");
// Console.WriteLine($"A = {a} e B = {b}");

// a = 10;

// Console.WriteLine("Depois da alteração");
// Console.WriteLine($"A = {a} e B = {b}");

// // Atribuindo tipo de referência
// // os dois estão apontando para a mesma referência

// var array = new List<int>();
// array.Add(10);
// array.Add(55);

// var array2 = array;

// array.Add(4);
// array.Add(666);

// foreach (var valor in array2)
// {
//     Console.WriteLine(valor);
// }

// class minhaClasse { 

//   static void Main(string[] args) {  

//     double salario = 0.00; 
//     double reajuste = 0.00; 
//     double novoSalario = 0.00; 
//     double percentual = 0.00; 
  
//     salario = Convert.ToDouble(Console.ReadLine()); 

// //TODO: Complete os espaços em branco com uma possível solução para o problema:
   
//     if(salario < 0) { 
//       return; 

//     } else if (salario <= 400.00) { 
//       percentual = 0.15; 
//       reajuste =  salario * percentual; 
//       novoSalario =  salario + reajuste ; 


//     } else if ( salario <= 800.00) { 
//       percentual =  0.12 ; 
//       reajuste = salario * percentual ;         
//       novoSalario = salario + reajuste; 

//     } else if ( salario   <= 1200.00) { 
//       percentual = 0.10; 
//       reajuste = salario * percentual; 
//       novoSalario = salario + reajuste ; 

//     } else if (  salario <= 2000.00) { 
//       percentual = 0.07 ; 
//       reajuste =  salario * percentual ; 
//       novoSalario =  salario + reajuste; 

//     } else { 
//       percentual = 0.04 ; 
//       reajuste = salario * percentual; 
//       novoSalario = salario + reajuste; 

//     } 

//     Console.WriteLine("Novo salario: {0:0.00}", novoSalario); 
//     Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste); 
//     Console.WriteLine("Em percentual: {0} %", percentual * 100); 

//   } 
// }
  



   


