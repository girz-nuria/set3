using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti elementele vectorului, separate prin spatii:");
            int[] vector = CitesteVectorDeLaTastatura();
            Console.WriteLine("Introduceti indexul pentru care doriti valoarea:");
            int index = int.Parse(Console.ReadLine());
            int valoareSortata = DeterminaValoareSortata(vector, index);
            Console.WriteLine($"Valoarea de pe pozitia {index} dupa sortare este: {valoareSortata}");
            Console.ReadLine();
        }
        static int[] CitesteVectorDeLaTastatura()
        {
            string input = Console.ReadLine();
            return Array.ConvertAll(input.Split(' '), int.Parse);
        }
        static int DeterminaValoareSortata(int[] vector, int index)
        {
            if (index < 0 || index >= vector.Length)
            {
                Console.WriteLine("Indexul introdus este invalid.");
                return -1;
            }
            int[] vectorSortat = (int[])vector.Clone();
            Array.Sort(vectorSortat);
            return vectorSortat[index];
        }

    }
}
