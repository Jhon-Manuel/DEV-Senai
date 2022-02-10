using System;

namespace ATIV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que tipo de gasolina deseja abastecer, (G)gasolina (A)alcool");
            string combustivel = Console.ReadLine().ToUpper();

            Console.WriteLine("Quantos litros quer colocar?");
            double litros = double.Parse(Console.ReadLine());


            switch (combustivel)
            {
                case "A":
                    if (litros <= 20)
                    {
                        double realValor1 = litros * 5.3/0.3;
                        Console.WriteLine($"{litros} litros custarão R${realValor1}");
                    }
                    else
                    {
                        double realValor1 = litros * 5.3/0.5;
                        Console.WriteLine($"{litros} litros custarão R${realValor1}");

                    }
                    break;

                case "G":
                    if (litros > 20)
                    {
                        double realValor2 = litros * 4.9/0.4;
                        
                        Console.WriteLine($"{litros} litros, com o desconto, serão R${realValor2}");
                    }
                    else
                    {
                        double realValor2 = litros * 4.9/0.6;
                        Console.WriteLine($"{litros} litros, com o desconto, serão R${realValor2}");

                    }
                    break;
                default:
                    break;
            }


        }
    }
}
