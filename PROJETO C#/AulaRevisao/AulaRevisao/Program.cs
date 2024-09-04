using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaRevisao
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

            string[] doces = new string[6];

            doces[0] = "brigadeiro";
            doces[1] = "cupcake";
            doces[2] = "pudim";
            doces[3] = "torta";
            doces[4] = "bombom";
            doces[5] = "leite";

            bool[] chuchu = new bool[3];
            chuchu[0] = true;
            chuchu[1] = true;
            chuchu[2] = false;

            int[] notas = new int[3];
            notas[0] = 15;
            notas[1] = 24;
            notas[2] = 90;
       


            /*for (int indice = doces.Length -1 ; indice >=0; indice--)
            {
                
                Console.WriteLine($"na posição {indice} tem a nota {doces[indice]}");
               
            };*/

            ArrayList jogos = new ArrayList();
            jogos.Add("GTA V");
            jogos.Add("Life Is Strange");
            jogos.Add("Mario Bros");
            jogos.Add("Crash");
            jogos.Add("Overwatch");
            jogos.Add("Tinykim");
            jogos.Add("Portal");
            jogos.Add("Mortal Kombat");

            for (int i = 0; i < jogos.Count; i++)
            {
                Console.WriteLine($"na posição {i} tem o jogo {jogos[i]}");
            };



        }
    }
}
