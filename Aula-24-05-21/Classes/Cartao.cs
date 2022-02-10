using System;

namespace Aula_2105.Classes
{
    public abstract class Cartao : Pagamento
    {
        public string Bandeira;
        public string Numero;
        public string Titular;
        public string CVV;

        public string SalvarCartao(){
            Console.WriteLine("Digite a bandeira do cartão");
            Bandeira = Console.ReadLine();

            Console.WriteLine("Digite a Numero do cartão");
            Numero = Console.ReadLine();

            Console.WriteLine("Digite a Titular do cartão");
            Titular = Console.ReadLine();

            Console.WriteLine("Digite a CVV do cartão");
            CVV = Console.ReadLine();
            
            return $"Cartão de numero{Numero} salvo com sucesso!";

        }
    }
}
