using System;

namespace PracticeQuestions
{
    public class LeapYearChecker
    {
        /// <summary>
        /// Method to check if given year is leap year
        /// </summary>
        /// <param name="year">year input as Int</param>
        /// <returns>
        /// True if year is leap year
        /// False if year is not leap year
        /// </returns>
        public static bool IsLeapYear(int year)
        {
            return year % 400 == 0;
        }
    }
}