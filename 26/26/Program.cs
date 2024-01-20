using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti primul numar mare:");
            string numar1 = Console.ReadLine();
            Console.WriteLine("Introduceti al doilea numar mare:");
            string numar2 = Console.ReadLine();
            AfiseazaRezultat("Suma", Aduna(numar1, numar2));
            AfiseazaRezultat("Diferenta", Scade(numar1, numar2));
            AfiseazaRezultat("Produs", Inmulteste(numar1, numar2));
            Console.ReadLine();
        }
        static void AfiseazaRezultat(string operatie, string rezultat) =>
            Console.WriteLine($"{operatie}: {rezultat}");
        static string Aduna(string numar1, string numar2) =>
            AdunaScade(numar1, numar2, false);
        static string Scade(string numar1, string numar2) =>
            AdunaScade(numar1, numar2, true);
        static string AdunaScade(string numar1, string numar2, bool scadere)
        {
            int lungimeMaxima = Math.Max(numar1.Length, numar2.Length);
            int carry = 0;
            string rezultat = "";
            for (int i = 1; i <= lungimeMaxima || carry > 0; i++)
            {
                int cifra1 = (i <= numar1.Length) ? int.Parse(numar1[numar1.Length - i].ToString()) : 0;
                int cifra2 = (i <= numar2.Length) ? int.Parse(numar2[numar2.Length - i].ToString()) : 0;
                int suma = scadere ? cifra1 - cifra2 - carry : cifra1 + cifra2 + carry;
                if (scadere)
                {
                    if (suma < 0)
                    {
                        suma += 10;
                        carry = 1;
                    }
                    else
                    {
                        carry = 0;
                    }
                }
                else
                {
                    carry = suma / 10;
                }
                rezultat = suma % 10 + rezultat;
            }
            return rezultat.TrimStart('0') == "" ? "0" : rezultat.TrimStart('0');
        }
        static string Inmulteste(string numar1, string numar2)
        {
            string produs = "0";
            for (int i = numar2.Length - 1; i >= 0; i--)
            {
                int cifra2 = int.Parse(numar2[i].ToString());
                int carry = 0;
                string partial = "";
                for (int j = numar1.Length - 1; j >= 0 || carry > 0; j--)
                {
                    int cifra1 = (j >= 0) ? int.Parse(numar1[j].ToString()) : 0;
                    int temp = cifra1 * cifra2 + carry;
                    partial = temp % 10 + partial;
                    carry = temp / 10;
                }
                partial += new string('0', numar2.Length - 1 - i);
                produs = Aduna(produs, partial);
            }
            return produs;
        }

    }
}
