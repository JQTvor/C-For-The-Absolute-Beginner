using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFAB_Chapter_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Soccer();
;
            //Soccer
            void Soccer()
            {
                Console.WriteLine("SOCCER");
                //inputs
                Console.Write("Goals by Liverpool: ");
                string input = Console.ReadLine();
                int lGoals = Convert.ToInt32(input);
                Console.Write("Goals by Manchester: ");
                input = Console.ReadLine();
                int mGoals = Convert.ToInt32(input);

                //evaluating
                if (lGoals > mGoals)
                    Console.WriteLine("Liverpool Won!");

                if (lGoals == mGoals)
                    Console.WriteLine("They tied.");

                if (mGoals > lGoals)
                    Console.WriteLine("Machester Wins!");

            }

            Console.WriteLine();
            Console.WriteLine();

            //Soccer Alternativly
            SoccerAlternatively();

                void SoccerAlternatively()
            {
                Console.WriteLine("SOCCER ALTERNATIVELY");
                //inputs
                Console.Write("Goals by Liverpool: ");
                string input = Console.ReadLine();
                int lGoals = Convert.ToInt32(input);
                Console.Write("Goals by Manchester: ");
                input = Console.ReadLine();
                int mGoals = Convert.ToInt32(input);

                //Evaluating
                if(lGoals > mGoals)
                {
                    //Here we know liverpool won.  We can display the result
                    Console.WriteLine("Liverpool Won!");
                }
                else
                {
                    //Here we know LP did't win.  We will decide if they tied or lost.
                    if(lGoals == mGoals)
                    {
                        Console.WriteLine("It's a tie");
                    }
                    else
                    {
                        Console.WriteLine("Manchester won!");
                    }
                }

            }


            Console.WriteLine();
            Console.WriteLine();

            //Minimum of Three Numbers Location 3375
            MinThreeNumbers();

            void MinThreeNumbers()
            {
                Console.WriteLine("MINIMUM OF THREE NUMBERS(My Program/With Math.Min)");
                //Whole Program 
                Console.Write("Enter first Number: ");
                string input = Console.ReadLine();
                int intSmall = Convert.ToInt32(input);
                Console.Write("Enter sencond number ");
                input = Console.ReadLine();
                int intComp = Convert.ToInt32(input);
                intSmall = Math.Min(intSmall, intComp);
               // if (intSmall >= intComp)
                //    intSmall = intComp;
                Console.Write("Enter a third number: ");
                input = Console.ReadLine();
                intComp = Convert.ToInt32(input);
                intSmall = Math.Min(intSmall, intComp);
                //if (intSmall >= intComp)
                //    intSmall = intComp;
                Console.WriteLine("The smallest number is " + intSmall);

            }
            Console.WriteLine();
            Console.WriteLine();

            //Minimum with built-in Function Location 3396
            MWBIF();

            void MWBIF()
            {
                Console.WriteLine("MINIMUM WITH BUILT-IN FUNCTION");
                //Inputs
                Console.Write("Enter first number: ");
                string input1 = Console.ReadLine();
                int number1 = Convert.ToInt32(input1);
                Console.Write("Enter second number: ");
                string input2 = Console.ReadLine();
                int number2 = Convert.ToInt32(input2);
                Console.Write("Enter third number: ");
                string input3 = Console.ReadLine();
                int number3 = Convert.ToInt32(input3);

                //Evaluating
                int min12 = Math.Min(number1, number2);
                int min = Math.Min(min12, number3);

                //Output
                Console.WriteLine("The least of the numbers is " + min);
            }
            Console.WriteLine();
            Console.WriteLine();

            //Linear Equation Location 3422
            LinearEquation();

            void LinearEquation()
            {
                Console.Write("Enter A: ");
                string inputA = Console.ReadLine();
                double a = Convert.ToDouble(inputA);
                Console.Write("Enter B: ");
                string inputB = Console.ReadLine();
                double b = Convert.ToDouble(inputB);

                //Solving
                if(a != 0)
                {
                    //A is not zero, the equation is normal
                    double solution = -b / a;
                    Console.WriteLine("The solution is x = " + solution);
                }
                else
                {
                    //a is zero, results depend on b
                    if(b == 0)
                        Console.WriteLine("The equation \"is solved\" by any x");
                    else
                    {
                        Console.WriteLine("The equation does not have a solution");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            //Quadriatic Equation Location 3435
            QuadraticEquation();

            void QuadraticEquation()
            {
                Console.WriteLine("Quadratic Equation");
                //input
                Console.Write("Enter A: ");
                string input = Console.ReadLine();
                double a = Convert.ToDouble(input);

                Console.Write("Enter B: ");
                string inputB = Console.ReadLine();
                double b = Convert.ToDouble(inputB);
                
                Console.Write("Enter C: ");
                string inputC = Console.ReadLine();
                double c = Convert.ToDouble(inputC);


                //Solving + output
                double d = b * b - 4 * a * c;

                if(d>0)
                {
                    double x1 = (-b - Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(d)) / (2 * a);

                    Console.WriteLine("The equation has two solutions: " + x1 + " and " + x2);
                }

                if(d==0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("The equation has a single solution: " + x);
                }

                if (d < 0)
                    Console.WriteLine("The equation does not have a solution");
            }

            Console.WriteLine();
            Console.WriteLine();



            //Wait for Enter
            Console.ReadLine();

        }
    }
}
