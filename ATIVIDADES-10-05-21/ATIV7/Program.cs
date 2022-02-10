using System;

namespace ATIV7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int [3];

            Console.WriteLine($"Insira {numeros.Length}");

            for (var i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite o {(i+1)} numeros");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (var i = (numeros.Length -1); i >= 0; i--)
            {
                Console.WriteLine($"{numeros[i]}");
            }

        }
    }
}
