using System;

namespace Atributos_e_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem personagem1 = new Personagem();
            personagem1.nome = "Cap";
            personagem1.idade = 103;
            personagem1.armadura = "Escudo";
            personagem1.pontoVida = 75;

            Personagem personagem2 = new Personagem();
            personagem2.nome = "Visão";
            personagem2.idade = 6;
            personagem2.armadura = "Capa Maneira";
            personagem2.pontoVida = 100;

            Console.WriteLine(@"
            Selecione a opção do personagem 1
                1- Atacar
                2- Defender
                ");

            int opcaoP1 = int.Parse(Console.ReadLine());

            Console.WriteLine(@"
            Selecione a opção do personagem 2
                1- Atacar
                2- Defender
                ");
            int opcaoP2 = int.Parse(Console.ReadLine());


            if (opcaoP1 == 1 && opcaoP2 == 1)
            {
                personagem1.pontoVida = personagem1.pontoVida - personagem2.Atacar();

                personagem2.pontoVida = personagem2.pontoVida - personagem1.Atacar();

            }
            else if (opcaoP1 == 1 && opcaoP2 == 2)
            {
                personagem1.pontoVida = personagem1.pontoVida - (personagem1.Atacar() - personagem2.Defender());

            }
            else if (opcaoP1 == 2 && opcaoP2 == 1)
            {
                personagem1.pontoVida = personagem1.pontoVida - (personagem2.Atacar() - personagem1.Defender());

            }
            else if (opcaoP1 == 2 && opcaoP2 == 2)
            {
            }
                Console.WriteLine($"Vida do Cap {personagem1.pontoVida}");
                Console.WriteLine($"Vida do Visão {personagem1.pontoVida}");

        }
    }
}
