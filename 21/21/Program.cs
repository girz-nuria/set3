using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti primul vector: ");
            int[] vector1 = ReadVector();
            Console.Write("Introduceti al doilea vector: ");
            int[] vector2 = ReadVector();
            string order = CompareVectors(vector1, vector2);
            Console.WriteLine($"Ordinea lexicografica: {order}");
            Console.ReadLine();
        }
        static int[] ReadVector()
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] vector = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                vector[i] = int.Parse(input[i]);
            }
            return vector;
        }
        static string CompareVectors(int[] vector1, int[] vector2)
        {
            int minLength = Math.Min(vector1.Length, vector2.Length);
            for (int i = 0; i < minLength; i++)
            {
                if (vector1[i] < vector2[i])
                {
                    return "Primul vector precede al doilea vector lexicografic.";
                }
                else if (vector1[i] > vector2[i])
                {
                    return "Al doilea vector precede primul vector lexicografic.";
                }
            }
            if (vector1.Length < vector2.Length)
            {
                return "Primul vector precede al doilea vector lexicografic.";
            }
            else if (vector1.Length > vector2.Length)
            {
                return "Al doilea vector precede primul vector lexicografic.";
            }
            return "Vectorii sunt identici lexicografic.";
        }

    }
}
