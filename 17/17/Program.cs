using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Introduceti numarul in baza 10: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti baza (1 < b < 17): ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b < 2 || b > 16)
            {
                Console.WriteLine("Baza introdusa nu este valida.");
                return;
            }
            string rezultat = ConvertesteInBaza(n, b);
            Console.WriteLine($"Numarul {n} in baza {b} este: {rezultat}");
            Console.ReadLine();
        }
        static string ConvertesteInBaza(int numar, int baza)
        {
            if (numar == 0)
                return "0";
            string rezultat = "";
            while (numar > 0)
            {
                int rest = numar % baza;
                char cifra = (char)(rest < 10 ? '0' + rest : 'A' + rest - 10);
                rezultat = cifra + rezultat;
                numar /= baza;
            }
            return rezultat;
        }

    }
}
