using System;

namespace Recursive_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(CalcFactRecursively(n));
        }

        private static int CalcFactRecursively(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * CalcFactRecursively(n - 1);
        }
    }
}
