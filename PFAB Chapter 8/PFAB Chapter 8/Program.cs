using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFAB_Chapter_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hinting user what we want from her
            Console.WriteLine("Enter a sentence and press Enter");
            //Reading single line of text (ujnti user presses enter)
            string input = Console.ReadLine();
            //Outputting the input
            Console.WriteLine("You have entered: " + input);
            //Waiting for Enter
            Console.WriteLine("");
            Console.WriteLine("");

            //Prompting the user
            Console.Write("How old are you?");
            
            //Reading line of text
            input = Console.ReadLine();

            //Converting input to a number
            int enteredNumber = Convert.ToInt32(input);

            //Output of the entered number
            Console.WriteLine("Your age: " + enteredNumber);
            Console.WriteLine("");
            Console.WriteLine("");

            //Trying on my own.
            Console.WriteLine(
                @"I'll tell you your age if you tell me what year you were born.
What year were you born?");
            //Take in age, input, as string.
            input = Console.ReadLine();
            int age = Convert.ToInt32(input);
            DateTime today = DateTime.Today;
            int thisYear = today.Year;
            age = thisYear - age;
            Console.WriteLine("This year you are, or will be " + age + " years old.");
            Console.WriteLine("");
            Console.WriteLine("");

            //number input
            Console.Write("Enter a number ");
            input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            //Calculating
            int result = number + 10;
            //Output
            Console.WriteLine("Number greater then yours by ten, " + result);
            Console.WriteLine("");
            Console.WriteLine("");


            try
            {
                //Summing two numbers
                //Input first number
                Console.WriteLine("Please enter a number.");
                string strFirstNumber = Console.ReadLine();
                //Input second number
                Console.WriteLine("Please enter a number to add to the first one.");
                string strSecondNumber = Console.ReadLine();
                //Transforming both of the strings into numbers.
                int intFirstNumber = Convert.ToInt32(strFirstNumber), intSecondNumber = Convert.ToInt32(strSecondNumber);
                //Summing the two numbers.
                int Sum = intFirstNumber + intSecondNumber;
                //Results Output
                Console.WriteLine("Sum of the entered numbers is: " + Sum);
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect input.  Cannot Calculate.");
            }

            Console.WriteLine("");
            Console.WriteLine("");






            Console.ReadLine();
        }
    }
}
