using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 1)
                    sum += i;
            }
            Console.Write(sum);
        }
    }
}