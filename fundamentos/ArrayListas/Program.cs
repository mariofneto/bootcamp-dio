using System;
// ================================
//     Sintaxe Básica Array
// ================================

// int[] array = new int[4];
// int[] array = new int[] {42, 75, 74, 61};
// string[] meses = {"Jan","Fev"};

// o ruim do array é ele ter tamanho fixo, por isso prefiro listas

// ================================
//     Exemplo Array
// ================================

int[] array = new int[] { 42, 75, 774, 69 };

for (var contador = 0; contador < array.Length; contador++)
    Console.WriteLine($"O índice {contador} tem o valor {array[contador]}");


