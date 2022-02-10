using System;
using System.Collections.Generic;
using System.IO;

namespace Nova_pasta__3_
{
    class Program
    {
        public static List<string> Cadastro = new List<string>();
        public static string acompanhado;
        public static string nome;
        public static int idade;
        const string PATH = "Database/Cadastro.csv";
        static void Main(string[] args)
        {
            bool retornar = true;

            do
            {

                Console.WriteLine($"|==  Menu   ==|");
                Console.WriteLine($"| 1 - Cadastro   2 - Listar Cadastros  X - sair |");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Cadastrar();
                        break;

                    case "2":
                        LerTodaLista();
                        break;
                    case "x":
                        retornar = false;
                        break;

                    default:
                        break;
                }


            } while (retornar == true);


        }
        static string PrepararLinha(string nome, int idade, string acompanhado)
        {
            return $"{nome};{idade};{acompanhado}";
        }
        
        static public void CriarPastaEArquivo(string _path)
        {
            string pasta = _path.Split("/")[0];
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            if (!File.Exists(_path))
            {
                File.Create(_path).Close();
            }
        }
        static public void Cadastrar()
        {
            bool veriIdade = true;
            bool novoCadastro = true;
            string veriNovoCadastro;
            do
            {

                CriarPastaEArquivo(PATH);

                Console.WriteLine($"Qual é o seu nome?");
                nome = Console.ReadLine();

                Console.WriteLine($"Qual a sua idade?");
                idade = int.Parse(Console.ReadLine());

                if (idade > 16)
                {
                    Console.WriteLine($"Comfirmado a entrada");
                    string linha = PrepararLinha(nome, idade, "Acompanhado Não");
                    Cadastro.Add(linha);
                    File.AppendAllLines(PATH, Cadastro);
                }
                else
                {
                    do
                    {
                        Console.WriteLine($"[REGRAS DO EVENTO] Por ser menor de idade você terá que vir acompanhado \n");

                        Console.WriteLine($"Com quem estará acompanhado? [ Mãe/Pai ]");
                        acompanhado = Console.ReadLine().ToLower();

                        if (acompanhado == "mãe" || acompanhado == "pai")
                        {
                            Console.WriteLine($"Inscrição realizada");
                            string linha = PrepararLinha(nome, idade, acompanhado);
                            Cadastro.Add(linha);
                            File.AppendAllLines(PATH, Cadastro);

                            veriIdade = false;

                        }
                        else
                        {
                            Console.WriteLine($"Inscrição não realizada, leia o enunciado.");
                        }



                    } while (veriIdade == true);


                }
                Console.WriteLine($"Deseja realizar um novo cadastro [s/n]");
                veriNovoCadastro = Console.ReadLine().ToLower();
                if (veriNovoCadastro == "n")
                {
                    novoCadastro = false;

                }
                else if (veriNovoCadastro == "s")
                {
                    novoCadastro = true;
                }
            } while (novoCadastro == true);



        }
        static void LerTodaLista()
        {
            string[] Lista = File.ReadAllLines(PATH);
            string[] linhas = Lista.Split(";");
            foreach (var item in linhas)
            {
                
                Console.WriteLine($"Nome:{item[0]} Idade:{item[1]} Acompanhado{item[2]}   Cadastro realizado");

            }
        }

    }
}
