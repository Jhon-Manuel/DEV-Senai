using System;

namespace ATIV5___revisão_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"\nTabuada do {i}");
                for (var c = 1; c < 11; c++)
                {
                    Console.WriteLine($"{i} x {c} = {(1*c)}");
                }
            }
        }
    }
}
