using System;

namespace PracticeQuestions
{
    public class GradeChecker
    {
        /// <summary>
        /// Methods to check Grade remarks like good, very good and others
        /// </summary>
        /// <param name="grade">grade input as char</param>
        /// <returns>
        /// Grade Remarks as String
        /// </returns>
        public string getGradeRemarks(char grade)
        {
            string GradeRemarks = "";

            switch (char.ToLower(grade))
            {
                case 'e': 
                    GradeRemarks = "Excellent";
                    break;
                case 'v':
                    GradeRemarks = "Very Good";
                    break;
                case 'g':
                    GradeRemarks = "Good";
                    break;
                case 'a':
                    GradeRemarks = "Average";
                    break;
                case 'f':
                    GradeRemarks = "Fail";
                    break;
            }
            return GradeRemarks;
        }
    }
}