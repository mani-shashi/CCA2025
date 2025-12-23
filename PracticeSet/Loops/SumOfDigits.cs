using System;
using System.Globalization;
using System.Security.Cryptography;

namespace PracticeQuestions
{
    public class DigitalRootFinder
    {
        /// <summary>
        /// Method - find Digital Root
        /// 
        /// TO find sum of digits of a number until the result is a single digit
        /// </summary>
        /// <param name="num">numver to find as Int</param>
        /// <returns>
        /// Digital root value(single digit)
        /// </returns>
        public int findDigitalRoot(int num)
        {
            while (num >= 10)
            {
                int sum = 0;
                while(num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                num = sum;
            }
            return num;
        }
    }
    
}