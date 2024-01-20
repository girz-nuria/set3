using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
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
            Tuple<int, int> pozitii = GasestePozitiiMinMax(vector);
            Console.WriteLine($"Pozitia celui mai mic element: {pozitii.Item1 + 1}");
            Console.WriteLine($"Pozitia celui mai mare element: {pozitii.Item2 + 1}");
            Console.ReadLine();
        }
        static Tuple<int, int> GasestePozitiiMinMax(int[] vector)
        {
            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 1; i < vector.Length; i += 2)
            {
                if (i + 1 < vector.Length)
                {
                    if (vector[i] < vector[i + 1])
                    {
                        if (vector[i] < vector[minIndex])
                        {
                            minIndex = i;
                        }

                        if (vector[i + 1] > vector[maxIndex])
                        {
                            maxIndex = i + 1;
                        }
                    }
                    else
                    {
                        if (vector[i + 1] < vector[minIndex])
                        {
                            minIndex = i + 1;
                        }

                        if (vector[i] > vector[maxIndex])
                        {
                            maxIndex = i;
                        }
                    }
                }
                else
                {
                    if (vector[i] < vector[minIndex])
                    {
                        minIndex = i;
                    }

                    if (vector[i] > vector[maxIndex])
                    {
                        maxIndex = i;
                    }
                }
            }
            return Tuple.Create(minIndex, maxIndex);
        }

    }
}
