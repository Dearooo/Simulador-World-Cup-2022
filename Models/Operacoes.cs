using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulador_de_Mata_Mata_World_Cup_2022.Models.Operacoes
{
    public class Operacoes
    {   
        //Essa função ficara responsavel para facilitar as disputas na main.
        public static void Disputa_FG(Time time1, Time time2){   

            int t1, t2;
           
            Console.WriteLine(time1.name + " X " + time2.name);
            Console.WriteLine("\n");

            Console.WriteLine("Gols do " + time1.name + ":");
            t1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Gols do " + time2.name + ":");
            t2 = int.Parse(Console.ReadLine());
            
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

        public static void Controle_FG(Time[] T){
            Disputa_FG(T[0], T[1]);
            Disputa_FG(T[2], T[3]);
            Disputa_FG(T[1], T[2]);
            Disputa_FG(T[3], T[0]);
            Disputa_FG(T[0], T[2]);
            Disputa_FG(T[3], T[1]);
        }

        public static Time[] Selecao_quartas(Time[]? T){
            Time[] finalistas = new Time[2];
            finalistas[1].Cadastro("Teste1");
            finalistas[2].Cadastro("Teste2");
            for (int i = 0; i < 4; i++)
            {
                if (T[i].vitoria >= finalistas[0].vitoria)
                {
                    if (T[1].vitoria > finalistas[0].vitoria)
                    {
                         finalistas[1] = T[i];
                    }
                    else{
                        if (T[i].Goals > finalistas[0].Goals)
                        {
                            finalistas[0]=T[i];
                        }
                    }
                }

                if (T[i].vitoria >= finalistas[1].vitoria)
                {
                    if (T[i].vitoria == finalistas[1].vitoria)
                    {
                        if (T[i].Goals > finalistas[1].Goals)
                        {
                            finalistas[1]=T[i];
                        }
                    }
                    else{
                        finalistas[1]=T[i];
                    }
                    
                }
            }

            return finalistas;
        }

        //Essa função será responsavel para facilitar a montagem das dispustas nas quartas;
        public static Time Disputa_MM(Time time1, Time time2){   
            
            int t1, t2, emp;

            Console.WriteLine("Gols do " + time1.name + ":");
            t1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Gols do " + time2.name + ":");
            t2 = int.Parse(Console.ReadLine());
            
            time1.Goals = time1.Goals + t1;
            time2.Goals = time2.Goals + t2;
            
            if (t1 > t2)
            {
                return time1;
            }
            else if(t2 > t1){
                return time2;
            }
            else if(t2 == t1){
                Console.WriteLine("Quem ira vencer nos penaltis? " + time1.name + "(1) ou (2)" + time2.name);
                emp = int.Parse(Console.ReadLine());
                if(emp == 1){
                    return time1;
                }else{
                    return time2;
                }
            }
            else{
                throw new ArgumentException("Nenhuma situação aceita!");
            }
        }
        
    }
}