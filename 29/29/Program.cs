using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dati elementele vectorului, separate prin spatii:");
            int[] vector = CitesteVectorDeLaTastatura();
            Console.WriteLine("Vectorul initial:");
            AfiseazaVector(vector);
            MergeSort(vector);
            Console.WriteLine("Vectorul sortat:");
            AfiseazaVector(vector);
            Console.ReadLine();
        }
        static int[] CitesteVectorDeLaTastatura()
        {
            string input = Console.ReadLine();
            return Array.ConvertAll(input.Split(' '), int.Parse);
        }
        static void AfiseazaVector(int[] vector)
        {
            Console.WriteLine(string.Join(" ", vector));
        }
        static void MergeSort(int[] vector)
        {
            if (vector.Length <= 1)
                return;
            int mijloc = vector.Length / 2;
            int[] stanga = new int[mijloc];
            int[] dreapta = new int[vector.Length - mijloc];
            Array.Copy(vector, 0, stanga, 0, mijloc);
            Array.Copy(vector, mijloc, dreapta, 0, vector.Length - mijloc);
            MergeSort(stanga);
            MergeSort(dreapta);
            Interclaseaza(vector, stanga, dreapta);
        }
        static void Interclaseaza(int[] vector, int[] stanga, int[] dreapta)
        {
            int i = 0, j = 0, k = 0;
            while (i < stanga.Length && j < dreapta.Length)
            {
                if (stanga[i] < dreapta[j])
                {
                    vector[k] = stanga[i];
                    i++;
                }
                else
                {
                    vector[k] = dreapta[j];
                    j++;
                }
                k++;
            }
            while (i < stanga.Length)
            {
                vector[k] = stanga[i];
                i++;
                k++;
            }
            while (j < dreapta.Length)
            {
                vector[k] = dreapta[j];
                j++;
                k++;
            }
        }

    }
}
