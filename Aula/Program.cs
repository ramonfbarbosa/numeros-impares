using System;
using System.Globalization;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números inteiro você vai digitar?");
            int x = int.Parse(Console.ReadLine());
            while (x > 1000 || x < 1)
            {
                Console.WriteLine("Escolhe um numero entre 1 e 1000");
                x = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("--------------");
                    Console.WriteLine("ímpar: " + i);
                }
            }
            Console.WriteLine("--------------");
        }
    }
            
}

        


