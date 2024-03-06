using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLogicoQuestao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número:");
            int numero = Convert.ToInt32(Console.ReadLine());


            List<int> fibonacci = new List<int> { 0, 1 };


            while (fibonacci[fibonacci.Count - 1] < numero)
            {
                int proximoNumero = fibonacci[fibonacci.Count - 1] + fibonacci[fibonacci.Count - 2];
                fibonacci.Add(proximoNumero);
            }

            if (fibonacci.Contains(numero))
            {
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
            }
            Console.ReadLine();//sem utilidade esta aqui apenas para teste
        }
    }
}
