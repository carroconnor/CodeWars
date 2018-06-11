using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 3;
            int c = -2;

            IsTriangle(a, b, c);
            Console.ReadLine();
        }

        public static bool IsTriangle(int a, int b, int c)
        {
            return (a + b > c && b + c > a && a + c > b);
        }
    }
}
