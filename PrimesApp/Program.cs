﻿namespace PrimesApp;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine($"{i}: is prime: {IsPrime(i)}");
        }
    }

    public static bool IsPrime(int n)
    {
        bool prime = true;

        for (int divider = 2; divider <= (int) Math.Sqrt(n); divider++)
        {
            if ((n % divider) == 0)
            {
                prime = false;
                break;
            }
        }

        return prime;
    }
}