//Task: multiply two numbers a*b (a, b can have up to 10000 digits)
//
using System;
using System.Numerics;

public class BigIntegers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] split = Console.ReadLine().Split();
                BigInteger a = BigInteger.Parse(split[0]);
                BigInteger b = BigInteger.Parse(split[1]);
                Console.WriteLine(BigInteger.Multiply(a, b));
            }
        }
    }