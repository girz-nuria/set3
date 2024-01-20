using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    internal class Program
    {
        static double EvalueazaPolinom(double[] coeficienti, double x)
        {
            double rezultat = 0.0;
            int n = coeficienti.Length;
            for (int i = 0; i < n; i++)
            {
                rezultat += coeficienti[i] * Math.Pow(x, i);
            }
            return rezultat;
        }
        static void Main()
        {
            try
            {
                Console.Write("Introduceti gradul polinomului (n): ");
                int n = int.Parse(Console.ReadLine());
                double[] coeficienti = new double[n + 1];
                for (int i = 0; i <= n; i++)
                {
                    Console.Write($"Introduceti coeficientul pentru x^{i}: ");
                    coeficienti[i] = double.Parse(Console.ReadLine());
                }
                Console.Write("Introduceti valoarea lui x: ");
                double x = double.Parse(Console.ReadLine());
                double rezultat = EvalueazaPolinom(coeficienti, x);
                Console.WriteLine($"Valoarea polinomului la x = {x} este: {rezultat}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Inputul nu este valid.");
            }
            Console.ReadLine();
        }
    }
}
