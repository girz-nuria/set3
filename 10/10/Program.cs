using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            Console.Write("Introdu lungimea vectorului: ");
            int lungime = int.Parse(Console.ReadLine());
            int[] vector = new int[lungime];
            Console.WriteLine("Introdu elementele vectorului în ordine crescătoare:");
            for (int i = 0; i < lungime; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Introdu elementul pentru căutare: ");
            int k = int.Parse(Console.ReadLine());
            int pozitie = CautareBinara(vector, k);
            if (pozitie != -1)
            {
                Console.WriteLine($"Elementul {k} se află la pozitia {pozitie + 1} în vector.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Elementul {k} nu se găsește în vector.");
                Console.ReadLine();
            }
        }

        static int CautareBinara(int[] vector, int elementCautat)
        {
            int stanga = 0;
            int dreapta = vector.Length - 1;
            while (stanga <= dreapta)
            {
                int mijloc = (stanga + dreapta) / 2;

                if (vector[mijloc] == elementCautat)
                {
                    return mijloc;
                }
                else if (vector[mijloc] < elementCautat)
                {
                    stanga = mijloc + 1;
                }
                else
                {
                    dreapta = mijloc - 1;
                }
            }
            return -1;
        }

    }
}
