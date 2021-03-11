using System;

namespace example1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 0;

            Console.WriteLine("Enter a value for a:");
            a = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Enter a value for B:");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplying {a} * {b} equals {AddNumbers(a, b)} ");

        }

        public static int AddNumbers(int a, int b)
        {
            return a * b;
        }
    }
}