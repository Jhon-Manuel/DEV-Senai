using System.Collections.Generic;
using System.IO;

namespace Nova_pasta.Models
{
    public abstract class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public string Senha { get; set; }

public bool login { get; set; }


       
        public void CreateFolderAndFile(string _path)
        {

            string folder = _path.Split("/")[0];
            string file = _path.Split("/")[1];

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (!File.Exists(_path))
            {
                File.Create(_path).Close();
            }
        }
        public virtual void Create(Usuario u, string PATH)
        {
            string[] linha = { PrepararLinha(u) };
            File.AppendAllLines(PATH, linha);
        }
        private string PrepararLinha(Usuario u)
        {
            return $"{u.Nome};{u.Email};{u.Senha}";
        }
        public virtual bool Logar(Usuario u, string _path){

            List<string> csv = ReadAllLinesCSV(_path);

            
            var logado = 
            csv.Find(
                x => 
                x.Split(";")[1] == u.Email && 
                x.Split(";")[2] == u.Senha           );
            
            if (logado != null)
            {
                return login;
            }
            
        }
        public List<string> ReadAllLinesCSV(string PATH){
            
            List<string> linhas = new List<string>();
            using(StreamReader file = new StreamReader(PATH))
            {
                string linha;
                while((linha = file.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
            }
            return linhas;
        }
    }
}