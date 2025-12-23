using System;

namespace PracticeQuestions
{
    public class BillCalculator
    {
        /// <summary>
        /// Method to calculate Electricity bill
        /// </summary>
        /// <param name="units"> units input as Double</param>
        /// <returns>
        /// calculated Bill Amount as Double
        /// </returns>
        public double CalculateBill(double units)
        {
            double cost;
            if (units <= 199)
            {
                cost = 1.20;
            } else if (units > 199 && units <= 400)
            {
                cost = 1.50;
            } else if (units > 400 && units <= 600)
            {
                cost = 1.80;
            } else
            {
                cost = 2.00;
            }

            return cost * units;
            
        }
    }
}