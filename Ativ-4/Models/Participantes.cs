namespace Nova_pasta.Models
{
    public class Participantes: Usuario
    {
        public const string PATH = "Database/Participantes.csv";
        
        public Participantes(){
        CreateFolderAndFile(PATH);

        }
        
        public string ConfirmarChegada(){
            return "Confirmado em todos os dias";
        }
        public string ConfirmarChegada(string e){
            return $"Presença confirmada em {e} ";
        }
    }
}