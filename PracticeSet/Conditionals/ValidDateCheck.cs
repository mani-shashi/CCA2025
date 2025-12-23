using System;

namespace PracticeQuestions
{
    public class DateChecker
    {
        /// <summary>
        /// Method to check if the given date is valid
        /// </summary>
        /// <param name="day">day input as Int</param>
        /// <param name="month">month input as Int</param>
        /// <param name="year">year input as Int</param>
        /// <returns>
        /// True if date is valid
        /// False if date is invalid
        /// </returns>
        public bool IsValidDate(int day, int month, int year)
        {

            if (year < 0)
            {
                return  false;
            }

            if (month < 1 || month > 12)
            {
                return false;
            }

            int maxDays=0;

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) maxDays = 31;
            else if(month == 4 || month == 6 || month == 9 || month == 11) maxDays = 30;
            else if (month == 2)
            {
                maxDays = LeapYearChecker.IsLeapYear(year) ? 29 : 28;
            }

            if (day < 1 || day > maxDays)
            {
                return false;
            }

            return true;

        }

    }
}