using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Introdu un numar natural n: ");
            int n = int.Parse(Console.ReadLine());
            AfiseazaNumerePrime(n);
        }

        static void AfiseazaNumerePrime(int n)
        {
            if (n < 2)
            {
                Console.WriteLine("Nu exista numere prime mai mici sau egale cu 2.");
                return;
            }

            bool[] estePrim = new bool[n + 1];
            for (int i = 2; i <= n; i++)
            {
                estePrim[i] = true;
            }

            for (int i = 2; i * i <= n; i++)
            {
                if (estePrim[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        estePrim[j] = false;
                    }
                }
            }

            Console.WriteLine($"Numere prime mai mici sau egale cu {n}:");
            for (int i = 2; i <= n; i++)
            {
                if (estePrim[i])
                {
                    Console.Write(i + " ");
                    Console.ReadLine();
                }
            }
        }

    }
}
