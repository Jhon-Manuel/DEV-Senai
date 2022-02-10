using System.Collections.Generic;

namespace Nova_pasta.Models
{
    public class Musico : Usuario
    {
        public const string PATH = "Database/Musico.csv";
        public string OMB { get; set; }

        public Musico()
        {
            CreateFolderAndFile(PATH);
        }
        public override bool Logar(Musico m, string _path)
        {
           List<string> csv = ReadAllLinesCSV(_path);


            var logado =
            csv.Find(
                x =>
                x.Split(";")[1] == m.Email &&
                x.Split(";")[2] == m.Senha);

            if (logado != null)
            {
                return login;
            }


        }



    }
}