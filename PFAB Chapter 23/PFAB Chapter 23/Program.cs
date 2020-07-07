using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFAB_Chapter_23
{
    class Program
    {
        static void Main(string[] args)
        {
            EnteringAPassword();
            TEL();
            WaitingForDescent();
            TEL();
            EveryWeekUntilTheEndOfYear();
            TEL();
            AsLongAsSixIsBeingThrown();
            TEL();
            UntilSecondSix();
            TEL();
            TwoSixesInARow();
            TEL();


            Console.ReadLine();
            void EnteringAPassword()
            {
                string correctPassword = "friend";
                bool ok;
                do
                {
                    //input
                    Console.WriteLine("Enter Password:");
                    string enteredPassword = Console.ReadLine();

                    //Evaluating
                    ok = enteredPassword == correctPassword;
                } while (!ok); //loop repeats when the condition holds
                Console.WriteLine("Come inside, please...");
            }

            void WaitingForDescent()
            {
                //Prep
                int previous = int.MinValue;
                bool ok;

                //Repeating until descend
                do
                {
                    //input
                    Console.Write("Enter a number: ");
                    string input = Console.ReadLine();
                    int value = Convert.ToInt32(input);

                    //Evaluating
                    ok = value >= previous; //ok = still not descending
                    //storing for next round of the loop.
                    previous = value;


                } while (ok);
                //Message to user
                Console.WriteLine("Descend Detected...");
            }

           void EveryWeekUntilTheEndOfYear()
                {
                //Today
                DateTime today = DateTime.Today;
                int thisYear = today.Year;
                //Repeating
                DateTime date = today;

                 do
                    {
                    //Output
                    Console.WriteLine(date.ToLongDateString());
                    //Preparing next output(A week later)
                    date = date.AddDays(7);

                    } while (date.Year == thisYear);
                }

            void AsLongAsSixIsBeingThrown()
            {
                //Random number generator
                Random randomNumbers = new Random();

                //Throwingas long as we have six
                int thrown;
                do
                {
                    thrown = randomNumbers.Next(1, 6 + 1);
                    Console.WriteLine(thrown);

                } while (thrown == 6);
            }

            void UntilSecondSix()
            {
                //Random Number Generator
                Random randomNumbers = new Random();

                //Throwin until the second six appears
                int howManySixes = 0;
                do
                {
                    //Actual throwing
                    int thrown = randomNumbers.Next(1, 6 + 1);
                    Console.WriteLine(thrown);
                    //Counting sixes
                    if(thrown == 6)
                    {
                        howManySixes++;
                    }

                } while (howManySixes < 2);
            }

            void TwoSixesInARow()
            {
                //Random number generator
                Random randomNumbers = new Random();

                //Prep
                int previous = 0;
                bool ending;

                //throwing until 2 sexes in a row
                do
                {
                    //throwing
                    int thrown = randomNumbers.Next(1, 6 + 1);
                    Console.WriteLine(thrown);
                    //eval
                    ending = thrown == 6 && previous == 6;
                    previous = thrown;
                } while (!ending);
            }




















            void TEL()
            {
                Console.WriteLine();
                Console.WriteLine();
            }






        }
    }
}
