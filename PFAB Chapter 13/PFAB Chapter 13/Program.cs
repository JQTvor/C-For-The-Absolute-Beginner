using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PFAB_Chapter_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chapter 13 Location 2603
            try
            {
                //input
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);

                //Calculation
                number = number + 10;

                //Result output
                Console.WriteLine("Number ten greater: " + number);

            }
            catch (Exception)
            {

                Console.WriteLine();;
            }

            Console.WriteLine();
            Console.WriteLine();

            try
            {
                //Compound Assignment Location 2619
                //input
                Console.Write("Enter a number : ");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);


                //Calculation using compound assignment
                number += 10; //Same as number = number + 10

                //Result output
                Console.WriteLine("Number ten greater is : " + number);
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
                //Futher compound assignment location 2632
                //input
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                Console.WriteLine();

                //With subtraction
                number -= 5; //Same as number = number -5
                Console.WriteLine("Number decreased by 5: " + number);

                //With muliplication
                number *= 10; //Same as number = number * 10;
                Console.WriteLine("New number times 10: " + number);

                //with division
                number /= 2; //Same as number= number / 2;
                Console.WriteLine("New number divided by 2: " + number);

            }
            catch (Exception)
            {

                Console.WriteLine();
                Console.WriteLine(); ;
            }
            Console.WriteLine();
            Console.WriteLine();


            try
            {

                //Incredmenting and Decrementing Location 2656
                //Input
                Console.Write("Enter an integer: ");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);

                //Increasing by 1 using increment operator
                number++; //Same as number = number + 1.
                Console.WriteLine("Increased by 1: " + number);

                //Decreasing by 1 using a decrement operator
                number--; //Same as number = number - 1;
                Console.WriteLine("Back again: " + number);
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
                //Compond Assignment and Text location 2666
                //Initial Value (Empty Text)
                string books = "";

                //Appending
                books += "Homage to Catalonia" + Environment.NewLine;
                books += "Silent Spring" + Environment.NewLine;
                books += "The Beat of a Different Drum" + Environment.NewLine;

                //Output
                Console.WriteLine("Valuable Books");
                Console.WriteLine("______________");
                Console.WriteLine(books);
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
                //Progressive summation location 2676
                //Preparation - variable to acumulate intemediate results
                int sum = 0;

                //input - 1. number
                Console.Write("Enter first integer: ");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);

                //Adding first number to intermediate result
                sum += number;

                //input -2. number
                Console.Write("Enter a second integer: ");
                input = Console.ReadLine();
                number = Convert.ToInt32(input);

                //Adding second number to intermediate result
                sum += number;

                //input - 3. number
                Console.Write("Enter a third integer: ");
                input = Console.ReadLine();
                number = Convert.ToInt32(input);
                sum += number;

                //Output
                Console.WriteLine("Sum of the entered integers: " + sum);

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
                //Multiple Text Join Location 2701
                //Preparation - variables to accumulate intermediate results
                string inOriginalOrder = "", inReverseOrder = "";

                //Input for the first person
                Console.Write("Enter first Person: ");
                string person = Console.ReadLine();

                //Appending the first person to intermediate result
                inOriginalOrder += person + Environment.NewLine;
                inReverseOrder = person + Environment.NewLine + inReverseOrder;

                //input second person
                Console.Write("Enter a second person: ");
                person = Console.ReadLine();

                //Appending the second person
                inOriginalOrder += person + Environment.NewLine;
                inReverseOrder = person + Environment.NewLine + inReverseOrder;

                //input a third person
                Console.Write("Enter a third person: ");
                person = Console.ReadLine();

                //Appending the third person
                inOriginalOrder += person + Environment.NewLine;
                inReverseOrder = person + Environment.NewLine + inReverseOrder;

                //Output
                Console.WriteLine("");
                Console.WriteLine("Entered Persons");
                Console.WriteLine("===============");
                Console.WriteLine(inOriginalOrder);
                Console.WriteLine("In Reverse order:");
                Console.WriteLine("===============");
                Console.WriteLine(inReverseOrder);
            }
            catch (Exception)
            {

                Console.WriteLine();
                Console.WriteLine();
            }         



            //Waiting for Enter
            Console.ReadLine();
        }
    }
}
