using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti elementele primului vector (ordonat crescator) separate prin spatii:");
            int[] v1 = CitesteVectorDeLaTastatura();
            Console.WriteLine("Introduceti elementele celui de-al doilea vector (ordonat crescator) separate prin spatii:");
            int[] v2 = CitesteVectorDeLaTastatura();
            int[] rezultat = Interclasare(v1, v2);
            Console.WriteLine("Vectorul interclasat: " + string.Join(", ", rezultat));
            Console.ReadLine();
        }
        static int[] CitesteVectorDeLaTastatura()
        {
            string input = Console.ReadLine();
            return Array.ConvertAll(input.Split(' '), int.Parse);
        }
        static int[] Interclasare(int[] v1, int[] v2)
        {
            int[] rezultat = new int[v1.Length + v2.Length];
            int i = 0, j = 0, k = 0;
            while (i < v1.Length && j < v2.Length)
            {
                rezultat[k++] = (v1[i] < v2[j]) ? v1[i++] : v2[j++];
            }
            while (i < v1.Length)
            {
                rezultat[k++] = v1[i++];
            }
            while (j < v2.Length)
            {
                rezultat[k++] = v2[j++];
            }
            return rezultat;
        }

    }
}
