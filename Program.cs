// ------------------- Program.cs  ------------------- //
using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question: Implement a program that replaces the values of two numeric variables without using a third variable.
            // Solution using C#
            Console.Write("Please give a number as 1st variable: ");
            var a = Console.ReadLine();
            Console.Write("Please give a number as 2nd variable: ");
            var b = Console.ReadLine();
            (a, b) = (b, a);
            Console.WriteLine($"The value of the 1st variable: {a}");
            Console.WriteLine($"The value of the 2nd variable: {b}");

            /* General solution pseudo code that will work with most programming languages:
                b = b - a
                a = a + b
                b = a - b
               However, this solution is prone to overflow errors so I would just stick to the solution provided above.
             */
        }
    }
}
