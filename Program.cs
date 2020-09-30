//BigInteger osztály (struktúra) elérése
//System.Numerics hozzáadása a referenciákhoz
using System;
using System.Numerics;

namespace FaktoriálisBigInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faktoriális");
            for (int szám = 20; szám <= 40; szám++)
            {
                BigInteger faktor = 1;
                for (int i = 2; i <= szám; i++)
                {
                    faktor = faktor * i;
                }
                Console.WriteLine($"{szám} != {faktor}");
            }
            Console.ReadKey();
        }
    }
}
