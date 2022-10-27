using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulador_de_Mata_Mata_World_Cup_2022.Models
{
    public class Operaces
    {
        public void Disputa_FG(Time time1, Time time2){

            int t1, t2;
            try
            {
                Console.WriteLine("Gols do " + time1.name + ":");
                t1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Gols do " + time2.name + ":");
                t2 = int.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                throw new ArgumentException("Erro");
            }this
            time1.Goals = time1.Goals + t1;
            time2.Goals = time2.Goals + t2;
            
            if (t1 > t2)
            {
                time1.vitoria = time1.vitoria + 1;
                time2.derrota = time2.derrota + 1;
            }
            else if(t2 > t1){
                time2.vitoria = time2.vitoria + 1;
                time1.derrota = time1.derrota + 1;
            }
            else if(t2 == t1){
                time1.empate = time1.empate + 1;
                time2.empate = time2.empate + 1;
            }
        }

        public 
    }
}