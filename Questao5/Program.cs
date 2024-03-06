using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringPadrao = "TargetSistemas";
            char[] vetorChar = stringPadrao.ToCharArray();
            int esquerda = 0;
            int direita = stringPadrao.Length - 1;

            while (esquerda < direita)
            {                
                char pos = vetorChar[esquerda];
                vetorChar[esquerda] = vetorChar[direita];
                vetorChar[direita] = pos;

                esquerda++;
                direita--;
            }

            string stringEmbaralhada = new string(vetorChar);
            Console.WriteLine(stringEmbaralhada);
            Console.ReadLine();//sem utilidade esta aqui apenas para teste
        }
    }
}
