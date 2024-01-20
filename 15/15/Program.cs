using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
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
            int indexUltimElementUnic = 0;
            for (int i = 0; i < n; i++)
            {
                bool esteDuplicat = false;
                for (int j = 0; j < indexUltimElementUnic; j++)
                {
                    if (vector[i] == vector[j])
                    {
                        esteDuplicat = true;
                        break;
                    }
                }
                if (!esteDuplicat)
                {
                    vector[indexUltimElementUnic] = vector[i];
                    indexUltimElementUnic++;
                }
            }
            Console.WriteLine("Vectorul dupa eliminarea duplicatelor:");
            for (int i = 0; i < indexUltimElementUnic; i++)
            {
                Console.Write($"{vector[i]} ");
            }
            Console.ReadLine();
        }
    }
}
