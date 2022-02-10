using System;
using Aula_21;

namespace Aula_2105.Classes
{
    public class Boleto : Pagamento
    {
        private string CodigoBarras;

        Random r = new Random();

        public void Registrar(){
            CodigoBarras = r.Next(3000000).ToString();

            Console.WriteLine($"Boleto gerado com o código {CodigoBarras}");
            Console.WriteLine($"Boleto registrado com o desconto, o valor agora é de {this.Valor* 0.88:c2}");
        }
    }
}

// pra herdar algo se usa "Boleto : Pagamento" (Pagamento é a superclasse) e na estrutura usa o this pra especificar o elemento q sera herdado; 
//to string (n2) ou :C2 pra o numero ficar em valor monetário;