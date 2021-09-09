using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUnitPrograms
{
   /// this is class Utility
   
    public class Utility
    {
       
        /// Days the specified method.
        //returns integer value of day
        public static int Days(int m, int d, int y)
        {
            int y1 = y - ((14 - m) / 12);
            int x = y1 + (y1 / 4) - (y1 / 100) + (y1 / 400);
            int m1 = m + (12 * ((14 - m) / 12)) - 2;
            int d1 = (d + x + ((31 * m1) / 12)) % 7;
            return d1;
        }

       
        /// Celsius to fahrenheit.
       //Celsius double value
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

       
        /// Fahrenheit to celsius.
        
       //fahrenheit's double value
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        
        /// Monthlies the payment.
        //Payment's double value
        public static double MonthlyPayment(double p, double y, double r)
        {
            double n = 12 * y;
            double result = r / (12 * 100);

            return (p * result) / (1 - Math.Pow(1 + r, -n));
        }

       
        /// SQRTs the specified c.
       //double type of approximate square root value
        public static double Sqrt(double c)
        {
            if (c < 0)
            {
                return double.NaN;
            }

            double t = c;

            /*while (Math.Abs(t - c / t) > double.Epsilon * t)
            {
                t = ((c / t + t) / 2.0);
            }*/
            t = ((c / t) + t) / 2.0;
            return t;
        }

      
        /// Converts to binary.
         //string type binary value
        public static string ToBinary(int input)
        {
            string binary = string.Empty;
            while (input > 0)
            {
                int addBinary = input % 2;
                binary = addBinary + string.Empty + binary;
                input = input / 2;
            }

            return binary;
        }

       
        /// Converts to decimal.
        //double type decimal value
        public static double ToDecimal(int input)
        {
            double decimalValue = 0;
            int count = 0;
            while (input > 0)
            {
                int power = input % 10;
                decimalValue += Math.Pow(2, count) * power;
                input = input / 10;
                count++;
            }

            return decimalValue;
        }

       
        /// Minimums the notes.
        //integer value of MinNotes
        public int MinNotes(int[] notes, int length, int amount)
        {
            if (amount == 0)
            {
                return 0;
            }

            int result = int.MaxValue;

            for (int i = 0; i < length; i++)
            {
                if (notes[i] <= amount)
                {
                    int subResult = this.MinNotes(notes, length, amount - notes[i]);

                    if (subResult != result && subResult + 1 < result)
                    {
                        result = subResult + 1;
                    }
                }
            }

            return result;
        }
    }
}