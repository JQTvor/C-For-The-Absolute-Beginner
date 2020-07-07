using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFAB_Chapter_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Password Input
            //Location 2893
            try
            {
                //Input
                Console.Write("Please enter your password: ");
                string enterPassword = Console.ReadLine();

                //Password Check
                if (enterPassword == "friend")
                {
                    Console.WriteLine("Password is OK, please enter");
                }
                else
                {
                    Console.WriteLine("Incorrect Password");
                }
            }
            catch (Exception)
            {

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                //Reverse Condition 
                //Location 2904
                //Correct password
                string correctPassword = "friend";

                //input
                Console.Write("Enter password: ");
                string input = Console.ReadLine();

                //Password Check
                if (correctPassword != input)
                {
                    Console.Write("Incorrect Password");
                }
                else
                {
                    Console.Write("Password is OK, Please Enter");
                }
            }
            catch (Exception)
            {

                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                //Length Check
                //Location 2925
                //input
                Console.Write("Enter a word.  ");
                string word = Console.ReadLine();

                //Determine word length
                int wordLength = word.Length;

                //Checking Length
                if (wordLength <= 4)
                {
                    Console.Write("Word is short.  At most 4 characters.");
                }
                else
                {
                    Console.Write("The word is long.  More than 4 characters");
                }
            }
            catch (Exception)
            {

                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                //Positive Numbers
                //Location 2943
                //Input
                Console.Write("Enter a number.  ");
                string input = Console.ReadLine();
                double number = Convert.ToDouble(input);

                //Evaluate
                if (number > 0)
                {
                    Console.WriteLine("The number is positive");

                }
                else
                {
                    Console.WriteLine("The number is not positive.");
                }
            }
            catch (Exception)
            {

                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                //Odd and Even Numbers
                //Location 2966
                //Input
                Console.WriteLine("Enter a number.");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);

                //Remainder Calc.
                int remainderAfterDivisionByTwo = number % 2;

                //eval.
                if (remainderAfterDivisionByTwo == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }
            }
            catch (Exception)
            {

                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                //Case Indifference
                //Location 2978
                //inputs
                Console.Write("Enter a name: ");
                string name1 = Console.ReadLine();
                Console.Write("Enter another name: ");
                string name2 = Console.ReadLine();

                //Converting to small letters
                string name1InSmall = name1.ToLower();
                string name2InSmall = name2.ToLower();

                //evaluating
                if (name1InSmall == name2InSmall)
                {
                    Console.WriteLine("You have entered the same names.");
                }
                else
                {
                    Console.WriteLine("You have entered different names");
                }
            }
            catch (Exception)
            {

                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            //Without Braces
            //Location 2992
            try
            {
                //Case Indifference
                //Location 2978
                //inputs
                Console.Write("Enter a name: ");
                string name1 = Console.ReadLine();
                Console.Write("Enter another name: ");
                string name2 = Console.ReadLine();

                //Converting to small letters
                string name1InSmall = name1.ToLower();
                string name2InSmall = name2.ToLower();

                //evaluating
                if (name1InSmall == name2InSmall)
                    Console.WriteLine("You have entered the same names.");
                else
                    Console.WriteLine("You have entered different names");
            }
            catch (Exception)
            {

                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            //Greater of Two numbers
            //Location 3004

            try
            {
                //Inputs
                Console.Write("Enter first number: ");
                string input1 = Console.ReadLine();
                Console.Write("Enter a second number: ");
                string input2 = Console.ReadLine();
                int intInput1 = Convert.ToInt32(input1);
                int intInput2 = Convert.ToInt32(input2);

                //evaluating
                int greater;
                if (intInput1 > intInput2)
                    greater = intInput1;
                else
                    greater = intInput2;

                //output
                Console.WriteLine("Greater of entered numbers is: " + greater);
            }
            catch (Exception)
            {
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            //Without the else branch
            //location 3012
            try
            {
                //inputs
                Console.Write("Enter first number: ");
                string input1 = Console.ReadLine();
                int number1 = Convert.ToInt32(input1);
                Console.Write("Enter second number: ");
                string input2 = Console.ReadLine();
                int number2 = Convert.ToInt32(input2);

                //Evaluating
                int greater = number1;
                if (number2 > greater) 
                greater = number2;

                //Output
                Console.WriteLine("Greater of entered numbers is: " + greater);
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();



            //Waiting for Enter
            Console.ReadLine();









        }
   
            
        
    }
}
