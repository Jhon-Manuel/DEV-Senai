using System.Collections.Generic;
using System.IO;

namespace Exemplo_MVC.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        private const string PATH = "Database/Produtos.csv";

        public Produto()
        {
            string pasta = PATH.Split("/")[0];
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List <Produto> Ler(){
            List<Produto> produtos = new List<Produto>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                string [] atributos = item.Split(";");

                Produto prod = new Produto();

                prod.Codigo = int.Parse(atributos[0]);
                prod.Nome = atributos[1];
                prod.Preco = float.Parse(atributos[2]);

                produtos.Add(prod);                
            }

            return produtos;

        }
    public string PrepararLinhasCVS(Produto produto){
        return $"{prod.Codigo};{prod.Nome};{prod.Preco}";
    }

    public void Inserir(Produto produto){
        string[] Linhas = {PrepararLinhasCVS(produto)};

        File.AppendAllLines(PATH, Linhas);
    }

    }
}