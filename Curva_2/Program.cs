using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curva_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho do array: ");
            int tamanho = int.Parse(Console.ReadLine());

            double[] Array = new double[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                Array[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Resultado da soma dos elementos do Array: {Soma(Array, tamanho)}");
        }

        static double Soma(double [] Array, int n)
        {
            // Caso base: quando o tamanho do array é 0, a soma é 0.
            if (n == 0)
            {
                return 0;
            }
            // Passo da recursão: a soma é igual ao valor atual mais a soma do restante do array. soma(n) = valor_atual(n) + soma(n-1)
            else
            {
                return Array[n - 1] + Soma(Array, n - 1);
            }
        }
    }
}
