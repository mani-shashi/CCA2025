using System;
using System.Security.Cryptography.X509Certificates;

namespace PracticeQuestions
{
    public class StrongNumberChecker
    {
        /// <summary>
        /// Method - IsStrongNumber
        /// 
        /// Check if any given number is valid Strong Number
        /// </summary>
        /// <param name="num">number to check as Int</param>
        /// <returns>
        /// True if Strong Number
        /// False if not Strong Number
        /// </returns>
        public bool IsStrongNumber(int num)
        {
            int sumOfDigits = 0;
            int temp = num;

            while(temp > 0)
            {
                int digit = temp % 10;
                FactorialFinder f = new FactorialFinder();
                sumOfDigits += f.findFactorial(digit);
                temp /= 10;
            }

            return sumOfDigits == num;
        }
    }
}