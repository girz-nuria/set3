using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
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
            RezultatMinMax rezultat = GasesteMinMax(vector);
            Console.WriteLine($"Cea mai mica valoare: {rezultat.Minim}");
            Console.WriteLine($"Numarul de aparitii ale celei mai mici valori: {rezultat.AparitiiMinim}");
            Console.WriteLine($"Cea mai mare valoare: {rezultat.Maxim}");
            Console.WriteLine($"Numarul de aparitii ale celei mai mari valori: {rezultat.AparitiiMaxim}");
            Console.ReadLine();
        }

        class RezultatMinMax
        {
            public int Minim { get; set; }
            public int Maxim { get; set; }
            public int AparitiiMinim { get; set; }
            public int AparitiiMaxim { get; set; }
        }

        static RezultatMinMax GasesteMinMax(int[] vector)
        {
            RezultatMinMax rezultat = new RezultatMinMax
            {
                Minim = int.MaxValue,
                Maxim = int.MinValue,
                AparitiiMinim = 0,
                AparitiiMaxim = 0
            };

            foreach (int numar in vector)
            {
                if (numar < rezultat.Minim)
                {
                    rezultat.Minim = numar;
                    rezultat.AparitiiMinim = 1;
                }
                else if (numar == rezultat.Minim)
                {
                    rezultat.AparitiiMinim++;
                }

                if (numar > rezultat.Maxim)
                {
                    rezultat.Maxim = numar;
                    rezultat.AparitiiMaxim = 1;
                }
                else if (numar == rezultat.Maxim)
                {
                    rezultat.AparitiiMaxim++;
                }
            }
            return rezultat;
        }

    }
}
