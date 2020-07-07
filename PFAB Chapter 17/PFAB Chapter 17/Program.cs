using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFAB_Chapter_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Compound Conditions

            try
            {
                //Yes or No
                //input
                Console.Write("Do you love me?  ");
                string input = Console.ReadLine();

                //Evaluating
                //location 3213
                string inputInSmall = input.ToLower();
                if (inputInSmall == "yes")
                    Console.WriteLine("OK");
                else
                    Console.WriteLine("Say it straint!");

            }
            catch (Exception)
            {

                Console.WriteLine();
            }
                Console.WriteLine();
                Console.WriteLine();

            try
            {
                //Username and password
                //Location 3234
                //Correct Values
                string correctUsername = "Orwell", correctPassword = "Catalonia";

                //Inputs
                Console.Write("User name: ");
                string enteredUserName = Console.ReadLine();
                Console.Write("Password: ");
                string enteredPassword = Console.ReadLine();

                //Evaluating
                if (enteredUserName.ToLower() == correctUsername.ToLower() && enteredPassword == correctPassword)
                    Console.WriteLine("Thank you for your books!");

                else
                    Console.WriteLine("Could not log you in.");
            }
            catch (Exception)
            {

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            try
            {
                //Two Users
                //Location 3243
                //Correct Values
                string correctUserName1 = "Orwell",
                    correctPassword1 = "Catalonia",
                    correctUserName2 = "Blair",
                    correctPassword2 = "1984";

                //Inputs
                Console.Write("User name: ");
                string enteredUsername = Console.ReadLine();
                Console.Write("Enter Password ");
                string enteredPassword = Console.ReadLine();

                //Evaluating
                if (enteredUsername.ToLower() == correctUserName1.ToLower() && enteredPassword == correctPassword1 ||
                    enteredUsername.ToLower() == correctUserName2.ToLower() && enteredPassword == correctPassword2)
                    Console.WriteLine("Thanks for the books");
                else
                    Console.WriteLine("Could not let you in.");
            }
            catch (Exception)
            {

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();


            try
            {
                //Two Users
                //Location 3243
                //Correct Values
                string correctUserName1 = "Orwell",
                    correctPassword1 = "Catalonia",
                    correctUserName2 = "Blair",
                    correctPassword2 = "1984";

                //Inputs
                Console.Write("User name: ");
                string enteredUsername = Console.ReadLine();
                Console.Write("Enter Password ");
                string enteredPassword = Console.ReadLine();


                bool userok = enteredUsername.ToLower() == correctUserName1.ToLower() && enteredPassword == correctPassword1; 
                     userok = enteredUsername.ToLower() == correctUserName2.ToLower() && enteredPassword == correctPassword2;
                //Evaluating
                if (userok)
                    Console.WriteLine("Thanks for the books");
                else
                    Console.WriteLine("Could not let you in.");
            }
            catch (Exception)
            {

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                //Yes or No
                //input
                Console.Write("Do you love me?  ");
                string input = Console.ReadLine();

                //Evaluating
                //location 3213
                string inputInSmall = input.ToLower();
                if (inputInSmall != "yes" && inputInSmall != "no")
                    Console.WriteLine("Say it Strait!");
                else
                    Console.WriteLine("Ok");

            }
            catch (Exception)
            {

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                //Grade Check
                //Location 3302
                //input
                Console.Write("Enter a grade: ");
                string input = Console.ReadLine();
                int grade = Convert.ToInt32(input);

                //Evaluating
                if (grade == 1 ||
                    grade == 2 ||
                    grade == 3 ||
                    grade == 4 ||
                    grade == 5)
                    Console.WriteLine("Input Ok");

                else
                    Console.WriteLine("Incorrect input");
            }
            catch (Exception)
            {

                Console.WriteLine();
            }
            
            Console.WriteLine();
            Console.WriteLine();


            try
            {
                
                    //Better Range Check
                    //Location 3310
                    //Input
                    Console.Write("Enter a Grade 1 - 5: ");
                    string input = Console.ReadLine();
                    int grade = Convert.ToInt32(input);

                    //Evaluating
                    if (grade > 0 && grade < 6)
                        Console.WriteLine("Grade Accepted");
                    else
                    {
                        Console.WriteLine("Please try again.");
                       
                    }
                
            }
            catch (Exception)
            {

                throw;
            }
            Console.WriteLine();
            Console.WriteLine();









            //Wait for Enter
            Console.ReadLine();
        }
    }
}
