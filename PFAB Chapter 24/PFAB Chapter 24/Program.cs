using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFAB_Chapter_24
{
    class Program
    {
        static void Main(string[] args)
        {
            void TEL()
            {
                Console.WriteLine();
                Console.WriteLine();
            }

            SumOfTheEnteredNumbers();

            void SumOfTheEnteredNumbers()
            {
                //Prep
                int sum = 0;
                int number;

                //Entering numbers util zero
                do
                {
                    //input
                    Console.Write("Enter a number(0 = end): ");
                    string input = Console.ReadLine();
                    number = Convert.ToInt32(input);


                    //Adding to the intermediate sum
                    sum += number;
                } while (number != 0);

                //output
                Console.WriteLine("Sum of the entered numbers is : " + sum.ToString());
            }

            TEL();

            ProdOfTheEnteredNumbers();

            void ProdOfTheEnteredNumbers()
            {
                //prep
                double product = 1, number;
                //Entering numbers until zero
                do
                {
                    Console.Write("Enter a number.  Zero End.  ");
                    string input = Console.ReadLine();
                    number = Convert.ToInt32(input);
                    //accumulating intermediate product(But not the last zero!)
                    if (number != 0)
                        product *= number;
                } while (number != 0);
                Console.WriteLine("The product of entered numbers(except zero) is : " + product.ToString("N0"));
            }

            TEL();
            TheGreatest();

            void TheGreatest()
            {
                //Prep
                int greatest = int.MinValue;

                //input of ten numbers
                for (int order = 1; order <= 10; order++)
                {
                    //input
                    Console.Write("Enter " + order.ToString() + ". number: ");
                    string input = Console.ReadLine();
                    int number = Convert.ToInt32(input);

                    //is it greater then the last?
                    if (number > greatest)
                        greatest = number;
                }
                //Output
                Console.WriteLine("The greatest of entered numbers was: " + greatest.ToString());
            }

            TEL();
            SecondGreatest();

            void SecondGreatest()
            {
                //Prep
                int greatest = int.MinValue;
                int secondGreatest = int.MinValue;
                //input of ten numbers
                for (int order = 1; order <= 10; order++)
                {
                    //input
                    Console.Write("Enter " + order.ToString() + ". number: ");
                    string input = Console.ReadLine();
                    int number = Convert.ToInt32(input);
                    
                    //is it greater than greatest so far?
                    if (number > greatest)
                    {
                        //moving so far greatest to the second place
                        secondGreatest = greatest;
                        //Entered number becomes greatest so far
                        greatest = number;
                    }
                    else
                    {
                        //We did not beat the greatest, will beat the second greatest
                        if (number > secondGreatest)
                            secondGreatest = number;
                    }
                }
                //output
                Console.WriteLine("The second largest number entered was : " + secondGreatest);
            }
            TEL();

            OutputOfAllEnteredNames();

            void OutputOfAllEnteredNames()
            {
                //Prep
                string inSameOrder = "";
                string inReverseOrder = "";
                bool terminating;

                //Repeating until blank input
                do
                {
                    //input
                    Console.Write("Enter person: ");
                    string person = Console.ReadLine();

                    //processing input
                    terminating = person.Trim() == "";
                    if(!terminating)
                    {
                        inSameOrder = inSameOrder + person + ", ";
                        inReverseOrder = person + ", " + inReverseOrder;
                    }
                } while (!terminating);
                //Removing tailing comma and space
                if(inSameOrder.EndsWith(", "))
                {
                    int numberOfCharacters = inSameOrder.Length;
                    inSameOrder = inSameOrder.Remove(numberOfCharacters - 2);
                }
                if(inReverseOrder.EndsWith(", "))
                {
                    int numberOfCharacters = inReverseOrder.Length;
                    inReverseOrder = inReverseOrder.Remove(numberOfCharacters - 2);
                }

                //Output
                Console.WriteLine("Entered Persons: " + inSameOrder);
                Console.WriteLine("In Reverse Order: " + inReverseOrder);
            }

            Console.ReadLine();
        }


    }
}
