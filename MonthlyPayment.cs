using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUnitPrograms
{
    
    /// this is class MonthlyPayment
    
    public class MonthlyPayment
    {
        /// <summary>
        /// Payments the specified argument1.
        /// </summary>
        /// <param name="argument1">The argument1.</param>
        /// <param name="argument2">The argument2.</param>
        /// <param name="argument3">The argument3.</param>
        public static void Payments(string argument1, string argument2, string argument3)
        {
            double principalLoan = Convert.ToDouble(argument1);
            double year = Convert.ToDouble(argument2);
            double percentInterest = Convert.ToDouble(argument3);
            Console.WriteLine("Monthly Payments: " + Utility.MonthlyPayment(principalLoan, year, percentInterest));
        }
    }
}