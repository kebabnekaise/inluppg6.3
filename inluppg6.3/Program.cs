using System;
using System.Diagnostics;

namespace inluppg6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj meny");
            while(true)
            {
                Console.WriteLine("1. Addera tre tal\n2. Största av två tal\n3. Avsluta programmet");
                int menyVal = int.Parse(Console.ReadLine());
                switch ( menyVal )
                {
                    case 1:
                        Console.WriteLine("Skriv in dina tal");
                        int tal1 = int.Parse(Console.ReadLine());
                        int tal2 = int.Parse(Console.ReadLine());
                        int tal3 = int.Parse(Console.ReadLine());
                        Console.WriteLine(Addera(tal1, tal2, tal3));
                        break;
                    case 2:
                        Console.WriteLine("Skriv in dina tal");
                        int comp1 = int.Parse(Console.ReadLine());
                        int comp2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(Störst(comp1, comp2));
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Fel inmatning");
                        break;
                }
            }
        }

        static int Addera(int x, int y, int z)
        {
            return x + y + z;
        }

        static int Störst(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            else if (y > x)
            {
                return y;
            }
            return x;
        }
    }
}