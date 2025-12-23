using System;

namespace PracticeQuestions
{
    public class Pattern
    {
        /// <summary>
        /// Method - printDiamondPattern
        /// To Print Diamond Pattern using nested loop
        /// </summary>
        /// <param name="height">height of pattern as Int</param>
        public void printDiamondPattern(int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write($" ");
                }

                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = height - 1; i > 1; i--)
            {
                for (int j = 0; j < height - i; j++)
                {
                    Console.Write($" ");
                }

                for (int k = 0; k < (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }
    }
}