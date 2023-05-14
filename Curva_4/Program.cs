using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curva_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número para ser convertido em binário: ");
            int Numero = int.Parse(Console.ReadLine());

            string NumeroBinario = DecimalParaBinario(Numero);

            Console.WriteLine($"O número {Numero} em binário é {NumeroBinario}.");
            Console.ReadLine();
        }

        static string DecimalParaBinario(int n)
        {
            // caso base: o número é 0, então o resultado é "0"
            if (n == 0)
            {
                return "0";
            }
            // Passo da recursão: dividimos o número por 2 e chamamos a função novamente com o resultado da divisão. DecimalParaBinario(n) = DecimalParaBinario(n/2)
            else
            {
                int resto = n % 2;
                int quociente = n / 2;
                string resultadoParcial = DecimalParaBinario(quociente);
                string resultadoFinal = resultadoParcial + resto.ToString();
                return resultadoFinal;
            }
        }

    }
}
