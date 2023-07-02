using System;

namespace NestingAndBoxes
{
    /// <summary>
    /// Nesting and Boxes Revisited lecture code
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Nesting and Boxes Revisited lecture code
        /// 
        /// The idea for this problem comes from Beginning C by Ivor Horton
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // get valid width and height
            int width = GetValidInput(
                "Enter box width (3-20): ",
                "Width must be between 3 and 20",
                3, 20);
            int height = GetValidInput(
                "Enter box height (3-20): ",
                "Height must be between 3 and 20",
                3, 20);
            Console.WriteLine();

            // print top row
            PrintCharacter('*', width);
            Console.WriteLine();

            // print middle of box
            PrintBoxInterior(width, height);

            // print bottom row
            PrintCharacter('*', width);
            Console.WriteLine();
        }

        /// <summary>
        /// Gets a valid input from the user
        /// </summary>
        /// <param name="promptString">prompt string</param>
        /// <param name="errorString">error string</param>
        /// <param name="lowerBound">lower bound</param>
        /// <param name="upperBound">upper bound</param>
        /// <returns>valid input</returns>
        static int GetValidInput(string promptString,
            string errorString, int lowerBound,
            int upperBound)
        {
            int value;
            Console.Write(promptString);
            value = int.Parse(Console.ReadLine());
            while (value < lowerBound ||
                value > upperBound)
            {
                Console.WriteLine(errorString);
                Console.Write(promptString);
                value = int.Parse(Console.ReadLine());
            }
            return value;
        }

        /// <summary>
        /// Prints the given character NumTimes times
        /// </summary>
        /// <param name="character">the character to print</param>
        /// <param name="numTimes">how many times to print it</param>
        static void PrintCharacter(char character, int numTimes)
        {
            for (int i = 1; i <= numTimes; i++)
            {
                Console.Write(character);
            }
        }

        /// <summary>
        /// Prints the interior of a box with the given width and height
        /// </summary>
        /// <param name="width">box width</param>
        /// <param name="height">box height</param>
        static void PrintBoxInterior(int width, int height)
        {
            for (int row = 2; row <= height - 1; row++)
            {
                Console.Write('*');
                PrintCharacter(' ', width - 2);
                Console.Write('*');
                Console.WriteLine();
            }
        }
    }
}
