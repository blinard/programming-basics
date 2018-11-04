using System;
using Basics.Algorithm;

namespace Basics.Cli
{
    class Program
    {
        private const int lowerBound = 0;
        private const int upperBound = 100;

        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Hey there, this is a console application to help you test your multiplication algorithm.");
            Console.WriteLine();
            var firstVal = GetValue("first");
            Console.WriteLine("Sweet, thanks!");
            Console.WriteLine();
            var secondVal = GetValue("second");

            var multiplier = new Multiplier();
            var result = multiplier.Multiply(firstVal, secondVal);

            Console.WriteLine();
            Console.WriteLine($"Awesome! Based on your algorithm: {firstVal} x {secondVal} = {result}");

            var correctResult = firstVal * secondVal;
            if (result == correctResult) {
                Console.WriteLine("Nice. It looks like your algorithm MIGHT be correct. Try it with different values or run the unit tests to be sure.");
            }
            else
            {
                Console.WriteLine("Oh no. It looks like your algorithm is incorrect for those values. Keep working on the algorithm, you'll get there.");
            }

            Console.WriteLine();
        }

        static int GetValue(string valueName) {
            int? val = null;
            while (!val.HasValue) {
                Console.WriteLine($"Please enter the {valueName} integer value to multiply then press <enter>: ");
                var valString = Console.ReadLine();
                if (!int.TryParse(valString, out var intValue)) 
                {
                    Console.WriteLine("Sorry, that doesn't appear to be a valid integer number.");
                    Console.WriteLine();
                    continue;
                }

                val = intValue;
                if (val < lowerBound || val > upperBound) {
                    Console.WriteLine($"Sorry, your value should be between {lowerBound} and {upperBound} inclusive.");
                    Console.WriteLine();
                    val = null;
                }
            }

            return val.Value;
        }
    }
}
