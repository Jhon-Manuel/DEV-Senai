using System;

namespace _10_05_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o ano em que nasecu:");
            int anoNasc = int.Parse(Console.ReadLine());
            
            int anoAtual = DateTime.Now.Year;
            
            int verificacao = anoAtual - anoNasc;

            if(verificacao >= 16)
            {
                Console.WriteLine("Você ja pode votar");
            } else {
            Console.WriteLine("Você ainda não tem idade pra votar");
            }



        }
    }
}
