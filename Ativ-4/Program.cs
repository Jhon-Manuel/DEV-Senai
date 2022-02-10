using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Nova_pasta.Models;

namespace Nova_pasta
{
    public class Program
    {


        public static void Main(string[] args)
        {
        Musico musico = new Musico();
        Participantes participantes = new Participantes();

        List<Musico> listaMusico = new List<Musico>();
        
        Musico m = new Musico();

        Console.WriteLine($"nome");
        m.Nome = Console.ReadLine();
        Console.WriteLine($"email");
        m.Email = Console.ReadLine();
        Console.WriteLine($"Senha");
        m.Senha = Console.ReadLine();
        
        
        string _path = "Database/Musico.csv";
        
        musico.Create( m, _path);
        
        musico.Logar(m, _path);
        



            CreateHostBuilder(args).Build().Run();
        }


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
