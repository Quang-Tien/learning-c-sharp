using System;

class Program
{
    static void Main(string[] args)
    {
        for (double i = 5; i <= 9.5; i+=0.5)
        {
            Console.WriteLine((double)(8 * 90 + i * 38) / 128 + "   " + i);
        }
    }
}