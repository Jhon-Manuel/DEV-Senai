using System;

namespace Aula_25.Classes
{
    public abstract class Player
    {
        private float Velocidade; 

        private float ForçaDoPulo;

        public virtual string Correr(){
            return "O player correu!";
        }
        public virtual string Pular(){
            return "O player pulou!";
        }
    }
}