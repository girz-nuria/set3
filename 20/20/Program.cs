using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti primul sirag de margele (s1): ");
            string s1 = Console.ReadLine();
            Console.Write("Introduceti al doilea sirag de margele (s2): ");
            string s2 = Console.ReadLine();
            int overlapCount = CountOverlaps(s1, s2);
            Console.WriteLine($"Numarul de suprapuneri este: {overlapCount}");
            Console.ReadLine();
        }
        static int CountOverlaps(string s1, string s2)
        {
            int s1Length = s1.Length;
            int s2Length = s2.Length;
            int overlapCount = 0;
            for (int i = 0; i < s1Length; i++)
            {
                bool match = true;
                for (int j = 0; j < s1Length - i; j++)
                {
                    if (s1[i + j] != s2[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                    overlapCount++;
            }
            return overlapCount;
        }

    }
}
