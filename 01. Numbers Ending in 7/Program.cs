using System;

namespace _01.NumbersEndingIn7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int number = 7; number <= 997; number += 10)
            {
                Console.WriteLine(number);
            }
        }
    }
}
