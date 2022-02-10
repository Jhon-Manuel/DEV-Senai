namespace Moda_Recuperação.Models
{
    public class Contato
    {
        public string Nome { get; set; }
        
        public string Email { get; set; }
        public int Telefone { get; set; }
        public string Name { get; set; }
        
        public string Mensagem { get; set; }
        
        public const string PATH = "Database/Contato.csv";      
        
        public Contato{

        }
        
    }
}