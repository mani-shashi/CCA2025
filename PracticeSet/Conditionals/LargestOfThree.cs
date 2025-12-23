using System;

namespace PracticeQuestions
{
    public class LargestChecker
    {
        /// <summary>
        /// Method to check largest of three integers
        /// </summary>
        /// <param name="num1">input 1 as Int</param>
        /// <param name="num2">input 2 as Int</param>
        /// <param name="num3">input 3 as Int</param>
        /// <returns>
        /// Largest of three integers as Int
        /// </returns>
        public int checkLargest(int num1, int num2, int num3)
        {
            int largest=num1;
            if (num1 >= num2 && num1 >= num3)
            {
                largest = num1;
            } else if (num2 >= num1 && num2 >= num3)
            {
                largest = num2;
            }else
            {
                largest = num3;
            }
            return largest;
        }
    }
}