﻿using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void ExploreIf()
        {
            int a = 5;
            int b = 3;
            if (a + b > 10)
            {
            Console.WriteLine("The answer is greater than 10.");
            }
            else
            {
            Console.WriteLine("The answer is not greater than 10");
            }

            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
            Console.WriteLine("The answer is greater than 10");
            Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
            Console.WriteLine("The answer is not greater than 10");
            Console.WriteLine("Or the first number is not equal to the second");
            }

            if ((a + b + c > 10) || (a == b))
            {
            Console.WriteLine("The answer is greater than 10");
            Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
            Console.WriteLine("The answer is not greater than 10");
            Console.WriteLine("And the first number is not equal to the second");
            }
        }
        static void Main(string[] args)
        {
            //ExploreIf();

            int counter = 0;
            while (counter < 10)
            {
            Console.WriteLine($"Hello World! The counter is {counter}");
            counter++;
            }

            for (int index = 3; index < 12; index++)
            {
            Console.WriteLine($"Hello World! The index is {index}");
            }

        }
    }
}
