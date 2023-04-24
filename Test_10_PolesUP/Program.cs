using System;

namespace Test_10_PolesUP
{
    class Program
    {
        public static int Sum(int a, int r, int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += a + i * r;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(2, 3, 5));
        }
    }
}
