using System;
using System.Collections.Generic;
using Exemplo_MVC.Models;

namespace Exemplo_MVC.Views
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produto){
            foreach (var item in produto)
            {
                Console.WriteLine($"\nCódigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco:C2}");
                
            }
        }

        public Produto CadastrarProduto(){
            Produto produto = new Produto();

            Console.WriteLine($"Digite um codigo");
            produto.Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite um nome");
            produto.Nome = Console.ReadLine();
            Console.WriteLine($"Digite o preco");
            produto.Preco = float.Parse(Console.ReadLine());

            return produto;
        }
    }
}