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
        public bool IsLeapYear(int year)
        {
            
            if (year % 4 == 0 )
            {
                if (year % 100 != 0)
                {
                    return true;
                } 
                else if (year % 400 == 0)
                {
                    return true;
                }
                
            }
            return false;
            
        }
    }
}