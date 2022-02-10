using System;

namespace ATIV6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[3];

            Console.WriteLine($"Digite o nome de {nomes.Length} pessoas");

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Digite o nome da {(i + 1)}ª pessoa");
                nomes[i] = Console.ReadLine();
            }
            Console.WriteLine("Digite o nome que deseja buscar:");
            string nomeBusca = Console.ReadLine();

            bool encontrado = false;

            foreach (var cadaNome in nomes)
            {
                if (nomeBusca == cadaNome)
                {

                    encontrado = true;

                }
            }
            if (encontrado)
            {

                Console.WriteLine("ACHEII");
            }
            else
            {
                Console.WriteLine("NÃO ACHEI");
            }
        }
    }
}
