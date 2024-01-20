using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Introdu lungimea vectorului: ");
            int lungime = int.Parse(Console.ReadLine());
            int[] vector = new int[lungime];
            Console.WriteLine("Introdu elementele vectorului:");
            for (int i = 0; i < lungime; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }
            SelectionSort(vector);
            Console.WriteLine("\nVectorul sortat prin Selection Sort:");
            AfiseazaVector(vector);
        }

        static void SelectionSort(int[] vector)
        {
            int lungime = vector.Length;
            for (int i = 0; i < lungime - 1; i++)
            {
                int indexMinim = i;
                for (int j = i + 1; j < lungime; j++)
                {
                    if (vector[j] < vector[indexMinim])
                    {
                        indexMinim = j;
                    }
                }
                int temp = vector[indexMinim];
                vector[indexMinim] = vector[i];
                vector[i] = temp;
            }
        }

        static void AfiseazaVector(int[] vector)
        {
            Console.WriteLine(string.Join(" ", vector));
            Console.ReadLine();
        }

    }
}
