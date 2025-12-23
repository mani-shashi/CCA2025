namespace PracticeQuestions
{
    public class ProfitLossChecker
    {
        /// <summary>
        /// Method to check if profit or loss is there
        /// </summary>
        /// <param name="costPrice"> cost price input as Double</param>
        /// <param name="sellingPrice">Selling price input as Double</param>
        /// <returns>
        /// Profit or loss  based upon calculation as String
        /// </returns>
        public string GetProfitOrLoss(double costPrice, double sellingPrice)
        {
            string ProfitOrLossRemarks = "";

            if ( sellingPrice  > costPrice)
            {
                double profit = sellingPrice - costPrice;
                double profitPercentage = (profit / costPrice) * 100;
                ;

                ProfitOrLossRemarks=$"{Double.Round(profitPercentage)}% Profit !!! ";
            } 
            else if (sellingPrice < costPrice)
            {
                double loss = costPrice - sellingPrice;
                double lossPercentage = (loss / costPrice) * 100;
                ProfitOrLossRemarks=$"{Double.Round(lossPercentage)}% Loss !!! ";
            }
            else
            {
                ProfitOrLossRemarks = "No Profit or Loss ";
            }

            return ProfitOrLossRemarks;
        }
    }
}