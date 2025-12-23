using System;

namespace PracticeQuestions
{
    public class VowelChecker
    {
        /// <summary>
        /// Method to check if given character is vowel
        /// </summary>
        /// <param name="c">character input as char</param>
        /// <returns>
        /// True if char is vowel
        /// False if char is not vowel
        /// </returns>
        public bool IsVowel(char c)
        {
            switch (char.ToLower(c))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                return true;

                default:
                return false; 
            }
        }
    }
}