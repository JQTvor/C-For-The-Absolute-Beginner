using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PFAB_Chapter_20
{
    class Program
    {
        static void Main(string[] args)
        {
            string learning = "I will start learning tomorrow";

            RepeatingTheSameText();

            void TEL()
            {
                Console.WriteLine();
                Console.WriteLine();
            }

            void RepeatingTheSameText()
            {
                Console.WriteLine("Repeating The Same Text");
                //output
                Console.WriteLine("I will start learning tomorrow.");
                Console.WriteLine("I will start learning tomorrow.");
                Console.WriteLine("I will start learning tomorrow.");
                Console.WriteLine("I will start learning tomorrow.");
                Console.WriteLine("I will start learning tomorrow.");
                Console.WriteLine("I will start learning tomorrow.");
                Console.WriteLine("I will start learning tomorrow.");
                Console.WriteLine("I will start learning tomorrow.");
                Console.WriteLine("I will start learning tomorrow.");
                Console.WriteLine("I will start learning tomorrow.");
            }

            TEL();

            SolutionUsingALoop();

            void SolutionUsingALoop()
            {
                Console.WriteLine("SOLUTION USING A LOOP.");
                //output
                //for(initiation; ends at; how the loop counts to the end.
                for(int count = 0; count < 10; count++)
                {
                    Console.WriteLine(learning);
                }
            }

            TEL();

            ChoosingTheNumberOfRepetitions();

            void ChoosingTheNumberOfRepetitions()
            {
                Console.WriteLine("Choosing The Number Of Repetitions");

                //input
                Console.Write("Enter the number of repetitions: ");
                string input = Console.ReadLine();
                int howManyTimes = Convert.ToInt32(input);

                //output
                for (int count = 0; count < howManyTimes; count++)
                {
                    Console.WriteLine(learning);
                }
            }

            TEL();

            ThowingADiceRepeatedly();

            void ThowingADiceRepeatedly()
            {
                Console.WriteLine("Thowing A Dice Repeatedly");
                //Random Number Generator
                Random randomNumbers = new Random();
                int last = 0;
                int total = 0;
                
                //Output
                for (int count = 1; count < 21; count++)
                {
                    

                   int thrown = randomNumbers.Next(1, 20 + 1);
                   total = total + thrown;
                   last = thrown;

                   double average = total / count;
                   int target = 10;
                   Console.WriteLine(thrown.ToString() + "");

                    
                    Console.WriteLine("Average is: " + average);
                    Console.WriteLine("Target is: " + target);
                }
            }

            TEL();

            RepeatingSimularLines();

            void RepeatingSimularLines()
            {
                //input
                Console.WriteLine("What would you like to be repeated?");
                string input = Console.ReadLine();
                Console.WriteLine("How many times would you like it to repeat?");
                string strCount = Console.ReadLine();
                int intCount = Convert.ToInt32(strCount);

                for (int interation = 1; interation <= intCount; interation++)
                {
                    Console.WriteLine(interation + ". " + input);
                    TEL();
                }



            }

            TEL();




            //Wait for enter
            Console.ReadLine();



        }
    }
}
