using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using TryParse to convert a string to an integer
            Console.WriteLine("Enter an integer: ");
            string intString = Console.ReadLine();
            int result;
            if (int.TryParse(intString, out result))
            {
                Console.WriteLine("TryParse: Conversion successful. Integer value: " + result);
            }
            else
            {
                Console.WriteLine("TryParse: Conversion failed. Invalid input.");
            }

            // Using Convert to convert a string to a double
            Console.WriteLine("Enter a double: ");
            string doubleString = Console.ReadLine();
            try
            {
                double doubleValue = Convert.ToDouble(doubleString);
                Console.WriteLine("Convert: Conversion successful. Double value: " + doubleValue);
            }
            catch (FormatException)
            {
                Console.WriteLine("Convert: Conversion failed. Invalid format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Convert: Conversion failed. Value is too large or too small.");
            }

            // Using Parse to convert a string to a decimal
            Console.WriteLine("Enter a decimal: ");
            string decimalString = Console.ReadLine();
            try
            {
                decimal decimalValue = decimal.Parse(decimalString);
                Console.WriteLine("Parse: Conversion successful. Decimal value: " + decimalValue);
            }
            catch (FormatException)
            {
                Console.WriteLine("Parse: Conversion failed. Invalid format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Parse: Conversion failed. Value is too large or too small.");
            }

            try
            {
                decimal decimalValue = decimal.Parse(decimalString);
                Console.WriteLine("Parse: Conversion successful. Decimal value: " + decimalValue);
            }
            catch (FormatException)
            {
                Console.WriteLine("Parse: Conversion failed. Invalid format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Parse: Conversion failed. Value is too large or too small.");
            }



        }
    }
}

        
