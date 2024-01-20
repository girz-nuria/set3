using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    internal class Program
    {
        static void QuickSort(int stanga, int dreapta, int[] a)
        {
            int i, j, x, y;
            i = stanga;
            j = dreapta;
            x = a[(stanga + dreapta) / 2];
            while (i <= j)
            {
                while (a[i] < x)
                {
                    i = i + 1;
                }
                while (x < a[j])
                {
                    j = j - 1;
                }
                if (i <= j)
                {
                    y = a[i];
                    a[i] = a[j];
                    a[j] = y;
                    i = i + 1;
                    j = j - 1;
                }
            }
            if (stanga < j)
                QuickSort(stanga, j, a);
            if (i < dreapta)
                QuickSort(i, dreapta, a);
        }
        static void Main(string[] args)
        {
            int i, n;
            int[] a = new int[100];
            Console.Write("Dati n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            QuickSort(1, n, a);
            for (i = 1; i <= n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.ReadLine();
        }


    }
}
