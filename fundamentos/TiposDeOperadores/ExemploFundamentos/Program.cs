using System;
// =======================================
//        Operadores de Atribuição
// =======================================

// int a = 10;
// int b = 20;

// int c = a + b;

// Console.WriteLine(c);
// Console.WriteLine(c + 5);

// var a = Convert.ToInt32("100055");

// Console.Write(a);

// =======================================
//        Operadores Condicionais
// =======================================

// var quantidadeEstoque = 10;
// var quantidadeCompra = 4;

// if(quantidadeCompra <= quantidadeEstoque)
//     Console.WriteLine("Compra feita com sucesso!");
// else
//     Console.WriteLine($"Não temos essa quantidade de produto, temos apenas {quantidadeEstoque}");

// =======================================
//        Operadores Lógicos
// =======================================

//          OR(||), AND(&&) e NOT(!)
//
//  OR é uma condição ou outra, alguma tem que ser verdadeira
//  AND é que as duas condições sejam verdadeiras
//  NOT é o contrário da condição,se ela é true sera false, se for false sera true

// =======================================
//        Operadores Aritméticos
//                  &
//             Classe Math
// =======================================

// Operadores básicos: +, -, *, /

// Potência com Classe Math: Math.Pow()
// Para arredondar os digitos: Math.Round(numero, quantos digitos depois da vírgula)
// 
// =======================================
//         Laços de Repetição
// =======================================

// Tipos de Laços de Repetição: FOR, FOR EACH, WHILE e DO WHILE

// FOR vai ter a declaração, condição e incremento 

// var numeroParaTabuada = 50;

// for(var contador = 1; contador <= 10; contador++)
//  Console.WriteLine($"{numeroParaTabuada} x {contador} = {numeroParaTabuada * contador}");


// WHILE vai ter so a condição entre os parenteses, o restante é no bloco do código

// var numeroParaTabuada = 6;
// var contador = 1;

// while (contador <= 10)
// {
//     Console.WriteLine($"{numeroParaTabuada} x {contador} = {numeroParaTabuada * contador}");
//     contador++;
// }

// DO WHILE vai ter seu teste lógico no final, enquanto o WHILE é no começo
// entao mesmo que seja falsa a condição é executada pelo menos uma vez!

// var numeroParaTabuada = 6;
// var contador = 1;

// do
// {
//     Console.WriteLine($"{numeroParaTabuada} x {contador} = {numeroParaTabuada * contador}");
//     contador++;
// }
// while (contador <= 10);

// =======================================
//         Um Exemplo Legal 
// =======================================

// Console.WriteLine("||Digite vários números para somar|| (0 para encerrar o programa)");
// var numeroDigitado = 0;
// List<int> numerosParaSomar = new List<int>();

// do
// {
//     Console.WriteLine("Escreva o número: ");
//     numeroDigitado = Convert.ToInt32(Console.ReadLine());

//     numerosParaSomar.Add(numeroDigitado);
// }
// while (numeroDigitado != 0);

// Console.WriteLine($"A soma dos números que você escreveu é igual a {numerosParaSomar.Sum()}");

// Environment.Exit(0) vai sair do programa sem executar nada que tem depois!