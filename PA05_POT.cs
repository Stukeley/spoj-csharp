//Task: find the last digit of a^b (a to the power b). a,b - positive integers && a,b >=1 && a,b <=1 000 000 000
//
using System;

public class Powers
    {
        public static void Main()
        {
            int D = int.Parse(Console.ReadLine());
            int lastDigit;

            for (int i = 0; i < D; i++)
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);

                if (a % 10 == 0 || a % 10 == 1 || a % 10 == 5 || a % 10 == 6)
                    lastDigit = (a % 10);
                else if (a % 10 == 4)
                {
                    if (b % 2 == 0) lastDigit = 6;
                    else lastDigit = 4;
                }
                else if (a % 10 == 9)
                {
                    if (b % 2 == 0) lastDigit = 1;
                    else lastDigit = 9;
                }
                else
                {
                    int r = (b % 100) % 4;

                    if (r == 1) lastDigit = a % 10;
                    else if (r == 2)
                    {
                        if ((a % 10) % 2 == 0)
                            lastDigit = 4;
                        else
                            lastDigit = 9;
                    }
                    else if (r == 3)
                    {
                        if (a % 10 == 2)
                            lastDigit = 8;
                        else if (a % 10 == 3)
                            lastDigit = 7;
                        else if (a % 10 == 7)
                            lastDigit = 3;
                        else
                            lastDigit = 2;
                    }
                    else
                    {
                        if ((a % 10) % 2 == 0) lastDigit = 6;
                        else lastDigit = 1;
                    }
                }
                Console.WriteLine("{0}", lastDigit);
            }
        }
    }