namespace Aula_2105.Classes
using System;

{
    public class Debito : Cartao
    {
        private float Saldo = 600f;

        public void Pagar(){
            float valor = this.Valor;

            if (valor > Saldo)
            {
                Console.WriteLine("você não possui saldo suficiente para pagar esse valor!");
            }else
            {
                Console.WriteLine(|$"O valor de {valor:C2} foi pago com sucesso!");
            }
        }
    }
}