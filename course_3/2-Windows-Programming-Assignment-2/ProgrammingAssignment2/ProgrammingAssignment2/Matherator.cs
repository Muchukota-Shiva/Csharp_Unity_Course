﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Provides a variety of numeric methods
    /// </summary>
    public class Matherator
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Matherator()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Prints the numbers from 1 to 10
        /// </summary>
        public void PrintOneToTen()
        {
            PrintMToN(1, 10);

        }

        /// <summary>
        /// Prints the numbers from m to n
        /// </summary>
        /// <param name="m">m</param>
        /// <param name="n">n</param>
        public void PrintMToN(int m, int n)
        {
            if (m <= n)
            {
                for (int j = m; j <= n; j++)
                {
                    Console.Write(j + " ");


                }
            }
            else
            {
                for (int j = m; j >= n; j--)
                {
                    Console.Write(j + " ");

                }
            }
            Console.WriteLine();

        }

        /// <summary>
        /// Returns the tenth even number, with 2 as the first even number
        /// </summary>
        /// <returns>tenth even number</returns>
        public int GetTenthEvenNumber()
        {
            // delete code below; only included so we could compile
            int tenthEvenNumber = 2;
            int count = 1;
            while (count < 10)
            {
                tenthEvenNumber++;
                if (tenthEvenNumber % 2 == 0)
                {
                    count++;
                }

            }
            return tenthEvenNumber;
        }

        /// <summary>
        /// Returns the nth even number, with 2 as the first even number
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>nth even number</returns>
        public int GetNthEvenNumber(int n)
        {
            // delete code below; only included so we could compile
            int nthEvenNumber = 2;
            int count = 1;
            while (count < n)
            {
                nthEvenNumber++;
                if (nthEvenNumber % 2 == 0)
                {
                    count++;
                }

            }
            return nthEvenNumber;
        }
    }
}
        #endregion