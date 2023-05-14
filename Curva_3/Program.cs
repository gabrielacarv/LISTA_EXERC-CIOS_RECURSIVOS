using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curva_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o tamanho do array: ");
            int TamanhoArray = int.Parse(Console.ReadLine());

            int[] Array = new int[TamanhoArray];

            Console.WriteLine("Digite os elementos do array:");
            for (int i = 0; i < TamanhoArray; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                Array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Array : ");
            for (int i = 0; i < TamanhoArray; i++)
            {
                Console.Write($"{Array[i]} ");
            }

            Console.WriteLine();

            InverteArray(Array, 0, TamanhoArray - 1);

            Console.Write("Array invertido: ");
            for (int i = 0; i < TamanhoArray; i++)
            {
                Console.Write($"{Array[i]} ");
            }

            Console.ReadLine();       
        }

        static void InverteArray(int[] array, int inicio, int fim)
        {
            // Caso base: array com tamanho 0 ou 1 já está invertido. TamanhoArray <= 1 
            if (inicio >= fim)
            {
                return;
            }

            //TamanhoArray > 1 -> InverteArray(array[1, n - 2]) + array[0] + array[n - 1]

            // Troca a primeira posição com a última
            int temp = array[inicio];
            array[inicio] = array[fim];
            array[fim] = temp;

            // Chama a função recursivamente para inverter o restante do array
            InverteArray(array, inicio + 1, fim - 1);
        }
    }
}
