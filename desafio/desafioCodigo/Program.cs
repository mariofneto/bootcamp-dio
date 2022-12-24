using System;

class Solution
{
    public static void Main(string[] args)
    {
        int numero = int.Parse(Console.ReadLine());
        int contador = 0;

        for (int index = 1; index <= numero; index++)
        {
            if (numero % index == 0)
            {
                contador++;
            }
            if (contador > index)
            {
                Console.WriteLine(false);
            }
        }
        Console.WriteLine(contador == 3);
    }
}



