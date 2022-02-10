using System;

namespace ATIV3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual produto vai adquirir?");
            string nome = Console.ReadLine();


            Console.WriteLine($"Quantos do {nome} vai querer?");
            double quantidade = double.Parse(Console.ReadLine());


            Console.WriteLine("Preço Unitário?");
            double valor = double.Parse(Console.ReadLine());

            double desc1 = 0.2;
            double desc2 = 0.3;
            double desc3 = 0.5;
            if (quantidade <= 5)
            {
                double desconto = (quantidade * valor) * desc1;
                Console.WriteLine($"{quantidade} items do produto {nome} terá como valor {(quantidade * valor - desconto).ToString("C")} com o desconto de {desconto.ToString("C")} ");

            }
            else if (quantidade > 5 && quantidade <= 10)
            {
                double desconto = (quantidade * valor) * desc2;
                Console.WriteLine($"{quantidade} items do produto {nome} terá como valor {(quantidade * valor - desconto).ToString("C")} com o desconto de {desconto.ToString("C")}");
            }
            else 
            {
                double desconto = (quantidade * valor) * desc3;
                Console.WriteLine($"{quantidade} items do produto {nome} terá como valor {(quantidade * valor - desconto).ToString("C")} com o desconto de {desconto.ToString("C")}");
            }
            







        }
    }
}
