using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUnitPrograms
{
    /// this is BinaryConversion
  
    public class BinaryConversion
    {
       /// Converts to binary.
    
        public static void ToBinary()
        {
            Console.WriteLine("Enter input for conversion of binary:");
            int input = Convert.ToInt32(Console.ReadLine());
            string binary = Utility.ToBinary(input);
            Console.WriteLine("Binary value:" + binary);

            string string1 = binary.Substring(0, binary.Length / 2);
            string string2 = binary.Substring(binary.Length / 2, binary.Length - (binary.Length / 2));
            Console.WriteLine(string1);
            Console.WriteLine(string2);
            Console.WriteLine(Convert.ToInt32(string2 + string1));
            double newBinay = Utility.ToDecimal(Convert.ToInt32(string2 + string1));
            Console.WriteLine("After Swapping nibble the new value: " + newBinay);
        }
    }
}