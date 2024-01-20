using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea vectorilor: ");
            int lungime = Convert.ToInt32(Console.ReadLine());
            int[] E = new int[lungime];
            int[] W = new int[lungime];
            for (int i = 0; i < lungime; i++)
            {
                Console.Write($"Introduceti elementul E[{i}]: ");
                E[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Introduceti ponderea pentru E[{i}]: ");
                W[i] = Convert.ToInt32(Console.ReadLine());
            }
            SortareBicriteriala(E, W);
            Console.WriteLine("Vectorii sortati:");
            AfiseazaVectori(E, W);
        }
        static void SortareBicriteriala(int[] E, int[] W)
        {
            int lungime = E.Length;
            for (int i = 0; i < lungime - 1; i++)
            {
                for (int j = i + 1; j < lungime; j++)
                {
                    if (E[i] > E[j] || (E[i] == E[j] && W[i] < W[j]))
                    {
                        SchimbaElemente(E, i, j);
                        SchimbaElemente(W, i, j);
                    }
                }
            }
        }
        static void SchimbaElemente(int[] vector, int index1, int index2)
        {
            int temp = vector[index1];
            vector[index1] = vector[index2];
            vector[index2] = temp;
        }
        static void AfiseazaVectori(int[] E, int[] W)
        {
            for (int i = 0; i < E.Length; i++)
            {
                Console.WriteLine($"E[{i}] = {E[i]}, W[{i}] = {W[i]}");
                Console.ReadLine();
            }
        }

    }
}
