using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
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
            InsertionSort(vector);
            Console.WriteLine("\nVectorul sortat prin Insertion Sort:");
            AfiseazaVector(vector);
        }
        static void InsertionSort(int[] vector)
        {
            int lungime = vector.Length;

            for (int i = 1; i < lungime; i++)
            {
                int valoareCurenta = vector[i];
                int j = i - 1;
                while (j >= 0 && vector[j] > valoareCurenta)
                {
                    vector[j + 1] = vector[j];
                    j--;
                }
                vector[j + 1] = valoareCurenta;
            }
        }
        static void AfiseazaVector(int[] vector)
        {
            Console.WriteLine(string.Join(" ", vector));
            Console.ReadLine();
        }

    }
}
