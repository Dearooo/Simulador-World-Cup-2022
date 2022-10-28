using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulador_de_Mata_Mata_World_Cup_2022.Models
{
    public class Time
    {
        public string name{get ;set ;}
        public int vitoria{get ;set ;}
        public int Goals{get ;set;}
        public int derrota{get ;set;}
        public int empate{get ;set ;}

        public void Cadastro(string n){
            this.name = n;
            this.vitoria = 0;
            this.derrota = 0;
            this.empate = 0;
            this.Goals = 0;
        }

        public void Imprimir(){
            Console.WriteLine(name + "\t" + vitoria + "\t" + derrota + "\t" + empate + "\t" + Goals);
        }
    }
 
}