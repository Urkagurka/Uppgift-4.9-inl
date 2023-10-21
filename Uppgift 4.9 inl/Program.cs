using System;

namespace Uppgift_4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in sidlängden på treangeln");
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {

                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");   
                }
                Console.WriteLine("");
            }
        }
    }
}