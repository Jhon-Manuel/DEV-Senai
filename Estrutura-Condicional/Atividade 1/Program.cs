using System;

namespace CALCULO_IDADE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos anos você tem?");
            int idadePessoa = int.Parse(Console.ReadLine());

            int anoSemana = 12 * idadePessoa;
            Console.WriteLine("Em meses, você tem:" + anoSemana);

            int anoDias = 365 * idadePessoa;
            Console.WriteLine("Em dias, você tem: " + anoDias);

            int anoHora = 8760 * idadePessoa;
            Console.WriteLine("Em horas, você tem: " + anoHora);

            int anoMin = 525600 * idadePessoa;
            Console.WriteLine("Em minutos, você tem: " + anoMin + "/n");


               // int bissexto = 52 * idadePessoa + 1;
                //int nãoBissexto = 52 * idadePessoa;

            // if (anoSemana <= 1996 && idadePessoa % 4 == 0 && idadePessoa % 400 == 0)
            //{
                //Console.WriteLine("Em semanas, pelos anos bissextos se teve: " + bissexto );
            
           // } else {

                //Console.WriteLine("Em semanas, você teve: " + nãoBissexto + " semanas");

            }


        }
    }






