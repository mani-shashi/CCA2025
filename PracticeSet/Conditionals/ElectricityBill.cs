using System;

namespace PracticeQuestions
{
    public class ELectricityBillCalculator
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
            double cost = costPerUnit(units);
            double billAmount =  cost * units;

            double surchargeRate=0.15d;

            if (billAmount > 400)
                billAmount += billAmount * surchargeRate;
            
            return Double.Round(billAmount);
        }

        /// <summary>
        /// Method to get cost per unit based on unit consumed
        /// </summary>
        /// <param name="units">units input as Double</param>
        /// <returns>
        /// Cost per unit as double
        /// </returns>
        private double costPerUnit(double units)
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
            return cost;
        }
    }
}