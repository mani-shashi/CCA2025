using System;

namespace PracticeQuestions
{
    public class BinaryConverter
    {
        /// <summary>
        /// Method - ToDecimal()
        /// 
        /// Convert binary value to decimal value
        /// </summary>
        /// <param name="binary">binary value as string</param>
        /// <returns>
        /// decimal value
        /// </returns>
        public int ToDecimal(string binary)
        {
            int decimalVal = 0;
            foreach (var item in binary)
            {
                decimalVal = decimalVal * 2 + (item - '0');

            }
            return decimalVal;
            
        }
    }
}