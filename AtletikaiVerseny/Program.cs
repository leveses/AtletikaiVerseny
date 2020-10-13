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
        static List<string> nevek = new List<string>();
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
