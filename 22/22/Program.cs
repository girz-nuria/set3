using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti primul vector (v1): ");
            int[] v1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.Write("Introduceti al doilea vector (v2): ");
            int[] v2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] intersectie = v1.Intersect(v2).ToArray();
            Console.WriteLine($"Intersectia: {String.Join(" ", intersectie)}");

            int[] reuniune = v1.Union(v2).ToArray();
            Console.WriteLine($"Reuniunea: {String.Join(" ", reuniune)}");

            int[] diferentaV1V2 = v1.Except(v2).ToArray();
            Console.WriteLine($"Diferenta v1 - v2: {String.Join(" ", diferentaV1V2)}");

            int[] diferentaV2V1 = v2.Except(v1).ToArray();
            Console.WriteLine($"Diferenta v2 - v1: {String.Join(" ", diferentaV2V1)}");
            Console.ReadLine();
        }
    }
}
