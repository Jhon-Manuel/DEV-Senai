using System;
using Aula_25.Classes;

namespace Aula_25
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan m = new MegaMan();
            Zero z = new Zero();

            Console.WriteLine("Mega-Man:");
            Console.WriteLine(m.Correr());
            Console.WriteLine(m.Pular());
            
            Console.WriteLine("\nZero:");
            Console.WriteLine(z.Correr());
            Console.WriteLine(z.Pular());


        }
    }
}
