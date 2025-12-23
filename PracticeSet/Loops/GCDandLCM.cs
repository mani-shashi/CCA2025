using System;

namespace PracticeQuestions
{
    public class BasicMaths
    {
        /// <summary>
        /// Method - findGCD
        /// 
        /// To find GCD value of any pairs
        /// </summary>
        /// <param name="num1">pair.first as Int</param>
        /// <param name="num2">pair.second as Int</param>
        /// <returns>
        /// Gcd value of given pair
        /// </returns>
        public int findGCD(int num1, int num2)
        {
            while(num2 != 0)
            {
                int remainder = num1 % num2;
                num1 = num2;
                num2 = remainder;
            }
            return num1;
        }

        /// <summary>
        /// TO find LCM value of any given pair
        /// </summary>
        /// <param name="num1">pair.first as Int</param>
        /// <param name="num2">pair.secind as Int</param>
        /// <returns>
        /// Lcm Value of given pair
        /// </returns>
        public int findLCM(int num1, int num2)
        {
            return (num1 * num2) / findGCD(num1, num2);
        }
        
    }
}