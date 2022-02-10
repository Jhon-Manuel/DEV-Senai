using System;

namespace ATIV4
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] quant = new int[10];
            Console.WriteLine($"Digite {quant.Length} valores:");

            for (var i = 0; i < quant.Length ; i++)
            {
                Console.WriteLine($"Digite o {(i+1)}ª valor :");
                quant [i] = int.Parse(Console.ReadLine());
                
            }
            Array.Sort(quant);

            Console.WriteLine($"O maior número é {quant[0]}");
            Console.WriteLine($"O maior número é {quant[(quant.Length -1)]}");
        }
    }
}
//uma validação do if com dois elementos poder ser(if(16== a || 17 == a))se for duas condições que se convergem..