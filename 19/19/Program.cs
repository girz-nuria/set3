using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti vectorul s, separate prin spatiu: ");
            int[] s = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.Write("Introduceti vectorul p, separate prin spatiu: ");
            int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int occurrences = CountOccurrences(s, p);
            Console.WriteLine($"Numarul de aparitii: {occurrences}");
            Console.ReadLine();
        }
        static int CountOccurrences(int[] s, int[] p)
        {
            int sLength = s.Length;
            int pLength = p.Length;
            if (sLength < pLength)
                return 0;
            int count = 0;
            for (int i = 0; i <= sLength - pLength; i++)
            {
                bool match = true;
                for (int j = 0; j < pLength; j++)
                {
                    if (s[i + j] != p[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                    count++;
            }
            return count;
        }

    }
}
