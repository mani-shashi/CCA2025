using System;

namespace PracticeQuestions
{
    public class HeightChecker
    {
        /// <summary>
        /// Method to check if the person is dwarf, tall or abnormal
        /// </summary>
        /// <param name="height">height in cm as Int</param>
        /// <returns>
        /// Height remarks as String
        /// </returns>
        public string checkHeight(int height)
        {
            string heightStr = "";
            if (height <= 150)
            {
                heightStr = "Dwarf";
            } else if (height > 150 && height <= 165)
            {
                heightStr = "Average";
            } else if (height > 165 && height <= 190)
            {
                heightStr = "Tall";
            } else
            {
                heightStr = "Abnormal";
            }

            return heightStr;
        }
    }
}