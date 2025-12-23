using System;

namespace PracticeQuestions
{
    public class ArmstrongNumberChecker
    {
        /// <summary>
        /// Method - IsValidArmstrongNumber
        /// 
        /// Check if any given number is valid ArmStrong Number
        /// </summary>
        /// <param name="num">number to check as Int</param>
        /// <returns>
        /// True if Armstrong Number
        /// False if not Armstrong Number
        /// </returns>
        public bool IsValidArmstrongNumber(int num)
        {
            int sumOfDigits = 0;
            int temp = num;

            while(temp > 0)
            {
                int digit = temp % 10;
                sumOfDigits += digit * digit * digit;
                temp /= 10;
            }

            return (sumOfDigits == num);
        }
    }
}