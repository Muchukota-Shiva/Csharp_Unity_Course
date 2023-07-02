using System;

namespace AppleExercise
{
    /// <summary>
    /// Exercise 4, 5, and 6 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Tests the apple class
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // test constructor and properties
            Apple apple = new Apple(true, 1.5f);
            Console.WriteLine("Organic? " + apple.Organic);
            Console.WriteLine("Amount Left: " + apple.AmountLeft);

            // eat the apple
            const float BiteSize = 0.15f;
            while (apple.AmountLeft > 0)
            {
                apple.TakeBite(BiteSize);
                Console.WriteLine("Amount Left: " + apple.AmountLeft);
            }
        }
    }
}
