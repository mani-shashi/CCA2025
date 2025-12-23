using System;

namespace PracticeQuestions
{
    public class TriangleChecker
    {
        /// <summary>
        /// Method to check type of triangle
        /// </summary>
        /// <param name="a">side of the triangle as Double</param>
        /// <param name="b">side of the triangle as Double</param>
        /// <param name="c">side of the triangle as Double</param>
        /// <returns>
        /// Type of triangle as String
        /// </returns>
        public string checkTriangleType(double a, double b, double c)
        {
            string triangleType;

            if (a == b && b == c)
            {
                triangleType = "Equilateral Triangle";
            } else if (a == b || b == c || c == a)
            {
                triangleType="Isosceles Triangle";
            } else
            {
                triangleType = "Scalene Triangle";
            }
            return triangleType;
        }

    }
}