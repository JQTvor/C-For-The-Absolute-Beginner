using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PFAB_Chapter_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Decimal input
            Console.Write("Enter a decimal number. ");
            string input = Console.ReadLine();
            double decimalNumber = Convert.ToDouble(input);
            //Repeating entered number to output
            Console.WriteLine("You have entered number " + decimalNumber);
            Console.WriteLine("");
            Console.WriteLine("");


           
            //American
            CultureInfo american = new CultureInfo("en-US");
            double dblNumber;
            try
            {
                //input
                Console.Write("Enter American decimal number. ");
                input = Console.ReadLine();
                dblNumber = Convert.ToDouble(input, american);
                //Output
                Console.WriteLine("You have entered " + dblNumber);
            }
            catch(Exception)
            {
                //Error Message
                Console.WriteLine("Incorrect input");
            }

            //Czech
            CultureInfo czech = new CultureInfo("cs-CZ");
            try
            {
                //Input
                Console.WriteLine();
                Console.Write("Enter a Czech decimal number: ");
                input = Console.ReadLine();
                dblNumber = Convert.ToDouble(input, czech);
                //Output
                Console.WriteLine("You have entered " + dblNumber);
            }
            catch (Exception)
            {

                //Error Message
                Console.WriteLine("Incorrect input");
            }

            //4 basic math functions
            //Input
            Console.Write("Enter first number");
            string strInput = Console.ReadLine();
            double dblNumber1 = Convert.ToDouble(strInput);
            Console.Write("Enter a second number");
            strInput = Console.ReadLine();
            double dblNumber2 = Convert.ToDouble(strInput);
            //Calculations
            double dblSum = dblNumber1 + dblNumber2;
            double dblDiff = dblNumber1 - dblNumber2;
            double dblProd = dblNumber1 * dblNumber2;
            double dblquot = dblNumber1 / dblNumber2;
            //Outputs
            Console.WriteLine("Sum is " + dblSum);
            Console.WriteLine("Difference is " + dblDiff);
            Console.WriteLine("Product is " + dblProd);
            Console.WriteLine("Quotient is " + dblquot);
            Console.WriteLine("");
            Console.WriteLine("");

            //Complex math functions
            //Input of angle
            Console.Write("Enter an angel in degrees: ");
            input = Console.ReadLine();
            double angleInDegrees = Convert.ToDouble(input);
            //Calculate and output of sine value
            double angleInRadians = angleInDegrees * Math.PI / 180;
            double result = Math.Sin(angleInRadians);
            Console.WriteLine("Sine of the angle is " + result);
            //Input of positive number
            Console.WriteLine();
            Console.Write("Enter a positive number: ");
            input = Console.ReadLine();
            double number = Convert.ToDouble(input);
            //Calculation and output of square root
            Console.WriteLine("Square root of the number is: " + Math.Sqrt(number));
            Console.WriteLine("");
            Console.WriteLine("");

            //Normal and integer divisions
            //Inputs
            Console.Write("Enter 1. whole number (diviend): ");
            string input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(input1);
            Console.Write("Enter 2. whole number (divisor) ");
            string input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input2);
            //Integer Calculations
            int integerQuotient = number1 / number2;
            int remainder = number1 % number2;
            //Normal calculations
            double number1double = number1;
            double number2double = number2;
            double normalQuotient = number1double / number2double;
            //Alternatively
            double normalQuotientAlternatively = (double)number1 / (double)number2;
            //outputs
            Console.WriteLine("--------------");
            Console.WriteLine("Integer Quotient: " + integerQuotient + " with remainder " + remainder);
            Console.WriteLine("\"Normal\"quotient: " + normalQuotient);
            Console.WriteLine("\"Normal\"quotient(alternatively):" + normalQuotientAlternatively);



            //Waiting for Enter
            Console.ReadLine();
        }
    }
}
