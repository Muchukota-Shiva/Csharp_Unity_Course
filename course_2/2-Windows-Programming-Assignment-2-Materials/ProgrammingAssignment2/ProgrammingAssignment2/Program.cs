﻿using System;
using System.Numerics;

namespace ProgrammingAssignment2
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the 
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 2
    /// </summary>
    class Program
    {
        // x and y coordinates for points
        static float point1X;
        static float point1Y;
        static float point2X;
        static float point2Y;

        /// <summary>
        /// Programming Assignment 2
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                // extract point coordinates from string
                GetInputValuesFromString(input);

                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed
                
                //# calculating distance
                float dx, dy, csq, c;
                dx = point2X - point1X;
                dy = point2Y - point1Y;

                csq = (float)Math.Pow(dx,2) + (float)Math.Pow(dy, 2);

                c=(float)Math.Sqrt(csq); // distance between two points
                
                
                //# calculating angle
                float ang;
                ang = (float)Math.Atan2(dy, dx);
                ang = (float)(180/Math.PI)*ang;

                Console.WriteLine(c+ " " + ang);


                

                

                // Don't add or modify any code below
                // this comment
                input = Console.ReadLine();
            }
        }

        /// <summary>
        /// Extracts point coordinates from the given input string
        /// </summary>
        /// <param name="input">input string</param>
        static void GetInputValuesFromString(string input)
        {
            // extract point 1 x
            int spaceIndex = input.IndexOf(' ');
            point1X = float.Parse(input.Substring(0, spaceIndex));

            // move along string and extract point 1 y
            input = input.Substring(spaceIndex + 1);
            spaceIndex = input.IndexOf(' ');
            point1Y = float.Parse(input.Substring(0, spaceIndex));

            // move along string and extract point 2 x
            input = input.Substring(spaceIndex + 1);
            spaceIndex = input.IndexOf(' ');
            point2X = float.Parse(input.Substring(0, spaceIndex));

            // point 2 y is the rest of the string
            input = input.Substring(spaceIndex + 1);
            point2Y = float.Parse(input);

            #region Unfortunately, Mono doesn't have a Split method!
            //string[] values = input.Split(' ');
            //point1X = float.Parse(values[0]);
            //point1Y = float.Parse(values[1]);
            //point2X = float.Parse(values[2]);
            //point2Y = float.Parse(values[3]);
            #endregion
        }
    }
}
