using System;
using System.Linq.Expressions;

namespace PracticeQuestions
{
    public class FactorialFinder
    {
        /// <summary>
        /// 
        /// Method - findFactorial()
        /// 
        /// Find factorial of any number
        /// </summary>
        /// <param name="num">number to find factorial as Int</param>
        /// <returns>
        /// Factorial value of given number
        /// </returns>
        /// <exception cref="Exception">if number is negative exception thrown</exception>
        public int findFactorial(int num)
        {
            if (num < 0)
            {
                throw new Exception ("Negative numbers not allowed");
            }
            if (num == 0 || num == 1)
            {
                return 1;
            }

            return num * findFactorial(num - 1);
        }
    }
    
}