using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
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
            InterSchimbareZeroLaSfarsit(vector);
            Console.WriteLine("\nVectorul cu valorile egale cu zero la sfârsit:");
            AfiseazaVector(vector);
        }
        static void InterSchimbareZeroLaSfarsit(int[] vector)
        {
            int indexZero = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] != 0)
                {
                    int temp = vector[i];
                    vector[i] = vector[indexZero];
                    vector[indexZero] = temp;
                    indexZero++;
                }
            }
        }
        static void AfiseazaVector(int[] vector)
        {
            Console.WriteLine(string.Join(" ", vector));
            Console.ReadLine();
        }

    }
}
