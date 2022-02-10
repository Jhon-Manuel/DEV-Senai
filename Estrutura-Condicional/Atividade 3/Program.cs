using System;

namespace SALARIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Salário atual: ");
            double salario= double.Parse (Console.ReadLine());

            double aumentoSalario = salario + (salario * 30/100);
        
        if(salario <= 500){
            Console.WriteLine(nome + "Aumento salárial para:" + aumentoSalario.ToString("C") );
            
        }else{
            Console.WriteLine(nome + " seus dados não coincidem com os requisitos");
        }
                
    }
}}
