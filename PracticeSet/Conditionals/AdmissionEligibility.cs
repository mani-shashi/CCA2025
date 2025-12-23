using System;
using System.Runtime.CompilerServices;

namespace PracticeQuestions
{
    public class AdmissionEligibilityChecker
    {
        /// <summary>
        /// Method to check if person is eligible for admission
        /// </summary>
        /// <param name="math"> Math marks as Int</param>
        /// <param name="phys"> Physics marks as Int</param>
        /// <param name="chem"> Chemistry marks as Int</param>
        /// <returns>
        /// True if eligible
        /// False if not eligible
        /// </returns>
        public bool IsEligible(int math, int phys, int chem)
        {
            int total = math + phys + chem;
            if (math >= 65 && phys >= 55 && chem >= 50)
            {
                return true;
            } 
            else if ((math+phys) >= 140)
            {
                return true;
            }
            else if(total >= 180)
            {
                return true;
            }
            return false;
        }
    }
    
}