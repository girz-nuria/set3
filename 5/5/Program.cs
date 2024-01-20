using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            Console.WriteLine("Introduceti elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Introduceti valoarea e de inserat: ");
            int e = int.Parse(Console.ReadLine());
            Console.Write("Introduceti pozitia k pentru inserare (0-prima pozitie): ");
            int k = int.Parse(Console.ReadLine());
            if (k >= 0 && k < n)
            {
                vector = InsereazaElement(vector, e, k);

                Console.WriteLine("Vectorul dupa inserare:");
                Console.ReadLine();

                for (int i = 0; i < vector.Length; i++)
                {
                    Console.Write($"{vector[i]} ");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Pozitia de inserare este invalida.");
            }
        }
        static int[] InsereazaElement(int[] vector, int e, int k)
        {
            vector[k] = e;
            return vector;
        }

    }
}
