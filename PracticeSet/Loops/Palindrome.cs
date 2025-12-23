using System;

namespace PracticeQuestions
{
    public class PalindromeChecker
    {
        /// <summary>
        /// Method to check if given number is Palindrome 
        /// </summary>
        /// <param name="num">number to check as Int</param>
        /// <returns>
        /// True if palindrome
        /// False if not palindrome
        /// </returns>
        public bool IsPalindrome(int num)
        {
            int reversedNumber  = 0;
            int temp = num;

            while (temp != 0)
            {
                int lastDigit = temp % 10;
                reversedNumber = reversedNumber * 10 + lastDigit;
                temp /= 10;
            }
            return num == reversedNumber;
        }
    }
}