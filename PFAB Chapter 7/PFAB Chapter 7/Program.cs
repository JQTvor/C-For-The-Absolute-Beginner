using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PFAB_Chapter_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Some text to try things on
            string text = "This is the last day of our acquaintance";
            //What e.g. can be done with text
            Console.WriteLine("Original Text: " + text);
            Console.WriteLine("Number of characters: " + text.Length);
            Console.WriteLine("In Uppercase: " + text.ToUpper());
            Console.WriteLine("Does it contain the world \"last\"? " + text.Contains("last"));
            Console.WriteLine("");
            Console.WriteLine("");

            //Some Numbers
            int number = 1234;
            //Conversion to text
            // string numberAsText = number;  DOES NOT WORK
            string numberAsText = number.ToString();
            //Output
            Console.WriteLine("Output of number: " + number);
            Console.WriteLine("Output as text: " + numberAsText);
            Console.WriteLine("");
            Console.WriteLine("");

            //Some money amounts and the number
            double amount = 1234.56, anotherAmount = 789;
            int wholeNumber = 1234567;
            //Formatted outputs
            Console.WriteLine("Separating thousands and millions + money to cents.");
            Console.WriteLine(amount.ToString("N2"));
            Console.WriteLine(anotherAmount.ToString("N2"));
            Console.WriteLine(wholeNumber.ToString("N0"));
            Console.WriteLine("");
            Console.WriteLine("");

            //Whole and decimal number
            wholeNumber = 1234567;
            double decimalNumber = 1234567.89;
            //Localization objects
            CultureInfo czech = new CultureInfo("cs-CZ");
            CultureInfo american = new CultureInfo("en-US");
            //Localized output
            Console.WriteLine("Whole number - Czech: " + wholeNumber.ToString("N0", czech));
            Console.WriteLine("Whole number - American: " + wholeNumber.ToString("N0", american));
            Console.WriteLine("Decimal number - Czech: " + decimalNumber.ToString("N2", czech));
            Console.WriteLine("Decimal Number - American " + decimalNumber.ToString("N2", american));
            Console.WriteLine("");
            Console.WriteLine("");






            //Waiting for Enter
            Console.ReadLine();
        }
    }
}
