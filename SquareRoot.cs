using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUnitPrograms
{
    /// this is class SquareRoot
    
    public class SquareRoot
    {
        
        /// SQRT is the instance of class.
        public static void Sqrt()
        {
            Console.WriteLine("Enter input for Square Roots:");
            double input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Approx Square Root:" + Utility.Sqrt(input));
        }
    }
}