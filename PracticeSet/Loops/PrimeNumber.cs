using System;

namespace PracticeQuestions {
    public class PrimeNumberChecker
    {
        /// <summary>
        /// Method - IsPrime()
        /// Find whether a given number is prime or not
        /// </summary>
        /// <param name="num">Number to check for prime as Int</param>
        /// <returns>
        /// True if given number is prime.
        /// False if given number is not prime.
        /// </returns>
        public bool IsPrime(int num)
        {
            if (num < 2) return false;

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }

            return true;
        }
        
    }
}