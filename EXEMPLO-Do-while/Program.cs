using System;

namespace _04_05_Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = "S";
            
            do
            {
                Console.WriteLine(" Qual é a sua idade:");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 0 && idade <= 4)

                    Console.WriteLine("Esta idade não esta inclusa no nosso programa");

                if (idade >= 5 && idade <= 7)
                {
                    Console.WriteLine("Categoria: Infantil A");

                }
                else if (idade >= 8 && idade <= 10)
                {
                    Console.WriteLine("Categoria: Infantil B");

                }
                else if (idade >= 11 && idade <= 13)
                {
                    Console.WriteLine("Categoria: Juvenil A");

                }
                else if (idade >= 14 && idade <= 17)
                {
                    Console.WriteLine("Categoria: Juvenil B");

                }
                else if (idade >= 18)
                {
                    Console.WriteLine("Conforme a pandemia a fachetaria senior esta indisponivel no momento");

                }

                Console.WriteLine("Deseja fazer uma nova consulta?  [S/N]");
                resposta = Console.ReadLine().ToUpper();
                
                
            } while (resposta == "S");


           



        
        }
    }
}
//Faça um programa que receba a idade de um nadador, imprima sua categoria e em seguida pergunte ao usuário se deseja fazer uma nova consulta, caso a resposta seja sim ele pode realizar a consulta novamente, caso a resposta seja não ele sai do sistema