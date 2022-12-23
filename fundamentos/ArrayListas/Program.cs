// ================================
//     Sintaxe Básica Array
// ================================

// int[] array = new int[4];
// int[] array = new int[] {42, 75, 74, 61};
// string[] meses = {"Jan","Fev"};

// o ruim do array é ele ter tamanho fixo, por isso prefiro listas

// ================================
//     Exemplo Array com FOR
// ================================

// int[] array = new int[] { 42, 75, 774, 69 };

// for (var contador = 0; contador < array.Length; contador++)
//     Console.WriteLine($"O índice {contador} tem o valor {array[contador]}");

// ================================
// Mesmo Exemplo Array com FOREACH
// ================================

// var contador = 0;
// foreach (var valor in array)
// {
//     Console.WriteLine($"No índice {contador}, o valor do Array é {valor}");
//     contador++;
// }

// =============================================
//    Sintaxe Básica List (Um array melhorado)
// =============================================

var pessoa = new List<string>();

pessoa.Add("Mário");
pessoa.Add("Odila");
pessoa.Add("Julia");

foreach(var nomePessoa in pessoa)
    Console.WriteLine(nomePessoa.ToLower().Contains("i")); // saber se cada nome tem a letra "i"






