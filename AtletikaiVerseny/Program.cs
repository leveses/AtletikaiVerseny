﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.CodeAnalysis;

namespace AtletikaiVerseny
{
    class Program
    {
        static List<Atleta> lista = new List<Atleta>();
        static Dictionary<string, int> konyvtar = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            Beolvas();
            Console.WriteLine("1. feladat: adatok beolvasása");
            Console.WriteLine();
            Feladat02();
            Console.WriteLine();
            Feladat03();
            Console.WriteLine();
            Feladat04();
            Console.WriteLine();
            Feladat05();
            Console.WriteLine();
            Feladat06();

            Console.ReadKey();
        }
        private static void Feladat06()
        {
            Console.WriteLine("6. feladat: Adatok fájlba írása");
            StreamWriter file = new StreamWriter("versenyzok.txt");
            foreach (var i in lista)
            {
                file.WriteLine($"{i.Rajtszam};{i.Nev}");
            }
            file.Close();
        }
        private static void Feladat05()
        {
            double sum = 0;
            int darab = 0;
            foreach (var i in lista)
            {
                sum += i.Ugras;
            }
            sum = sum / lista.Count();
            Console.Write("5. feladat: ");
            foreach (var i in lista)
            {
                if (i.Ugras < sum)
                {
                    darab++;
                }
            }
            Console.WriteLine($"Átlag alatt lévő ugrások száma: {darab}");
        }
        private static void Feladat04()
        {
            Console.WriteLine("4. feladat: Legnagyobb ugrás:");
            int max = 0;
            foreach (var i in lista)
            {
                if (max < i.Ugras)
                {
                    max = i.Ugras;
                    Console.WriteLine($"{i.Nev}: {max} cm");
                }
                
            }

        }
        private static void Feladat03()
        {
            Console.WriteLine("3. feladat: Egyesületek:");
            foreach (var i in lista)
            {
                
                if (!konyvtar.ContainsKey(i.Egyesulet))
                {
                    konyvtar.Add(i.Egyesulet, 0);
                    Console.WriteLine(i.Egyesulet);
                }

            }

        }
        private static void Feladat02()
        {
            foreach (var i in lista)
            {
                konyvtar.Add(i.Nev, i.Ugras);
            }
            Console.WriteLine("2. feladat: Nevek és ugrások");
            foreach (var i in konyvtar)
            {
                Console.WriteLine(i.Key + "\t" + i.Value);
            }
        }
        private static void Beolvas()
        {
            StreamReader file = new StreamReader("tavol.csv");
            while (!file.EndOfStream)
            {
                lista.Add(new Atleta(file.ReadLine()));
            }
            file.Close();
        }
        
    }
}
