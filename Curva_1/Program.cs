using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curva_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de X e N para calcular a potência (X^N):");
            Console.Write("X: ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Potência: {Potencia(X, N)}");

            Console.ReadLine();
        }

        static int Potencia(int x, int n)
        {
            // Caso base: quando n é 0, o resultado é 1.
            if (n == 0)
            {               
                return 1;
            }
            // Passo da recursão: xn = x * xn-1
            else
            {
                return x * Potencia(x, n - 1);
            }
        }
    }
}