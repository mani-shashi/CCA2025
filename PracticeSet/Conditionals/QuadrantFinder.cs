using System;

namespace PracticeQuestions
{
    public class QuadrantFinder
    {
        /// <summary>
        /// Method to find Quadrant of a given (x,y) axis
        /// </summary>
        /// <param name="x">X Axis position as Int</param>
        /// <param name="y">Y Axis position as Int</param>
        /// <returns>
        /// Quadrant as String
        /// </returns>
        public string FindQuadrant(int x, int y)
        {
            string Quadrant="";
            if (x == 0 && y == 0)
            {
                Quadrant="Centre";
            } else if (x > 0 && y > 0)
            {
                Quadrant = "1st Quadrant";
            } else if (x < 0 && y > 0)
            {
                Quadrant = "2nd Quadrant";
            } else if (x < 0 && y < 0)
            {
                Quadrant = "3rd Quadrant";
            }
            else
            {
                Quadrant = "4th Quadrant";
            }
            
            return Quadrant;
        }
    }
    
}