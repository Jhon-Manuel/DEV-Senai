using System;

namespace Estruturas_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em que ano você nasceu?");
            int anoNasc = int.Parse(Console.ReadLine());

            int anoPessoa = DateTime.Now.Year - anoNasc;
            Console.WriteLine("Você tem: " + anoPessoa);
            int multiplicação = anoPessoa * 52;

            Console.WriteLine("Você tem :" + multiplicação + " semanas de vida");

        
        }
    }
}
