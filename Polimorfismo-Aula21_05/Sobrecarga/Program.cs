using System;
using Sobrecarga.Classes;

namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            for (var i = 0; i < f.lista.Length; i++)
            {
                Console.Write("Digite um item para a lista: ");
                f.lista[i] = Console.ReadLine();
            }

            Console.WriteLine("\nMostrar sem argumentos");
            f.Mostrar();

            Console.WriteLine("\nMostrar com argumentos int");
            f.Mostrar(2);

            Console.WriteLine("\nMostrar com argumentos string");
            f.Mostrar("manga");


        }
    }
}
