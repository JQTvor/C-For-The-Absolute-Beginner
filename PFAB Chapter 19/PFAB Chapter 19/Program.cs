using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFAB_Chapter_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Location 3482
            ConditionalOperators();

            void ConditionalOperators()
            {
                Console.WriteLine("CONDITIONAL OPERATOR");
                //Random number generator
                Random randomNumbers = new Random();
                //random number 0/1 and it's transformation

                
                int randomNumber = randomNumbers.Next(0, 1 + 1);
                //message is conditions(randomNumbers is 0) then show string "Head Tossed" :(other wise) show string "Tail Tossed";
                string message = randomNumber == 0 ? "Head Tossed" : "Tail Tossed";
                Console.WriteLine(message);
            }
            Console.WriteLine();
            Console.WriteLine();

            //Summery Evaluation Loation 3510
            SummeryEvaluation();

            void SummeryEvaluation()
            {
                Console.WriteLine("SUMMERY EVALUATIONS");
                Console.WriteLine("1 1 2 2 NO");
                Console.WriteLine("Summary Evaluation: Excellent");

                //Preparations
                string errorMessage = "Incorrect input";
                int mathematics, informationTechnology, science, english;
                bool hasUnexcusedAbsences;

                //Inputs
                try
                {
                    Console.WriteLine("Enter grades for individual subjects");
                    Console.Write("Mathematics: ");
                    string input = Console.ReadLine();
                    mathematics = Convert.ToInt32(input);
                    if (mathematics < 1 || mathematics > 5)
                    {
                        Console.WriteLine(errorMessage);
                        return;
                    }

                    Console.Write("Information Technology: ");
                    input = Console.ReadLine();
                    informationTechnology = Convert.ToInt32(input);
                    if (informationTechnology < 1 || informationTechnology > 5)
                    {
                        Console.WriteLine(errorMessage);
                        return;
                    }

                    Console.Write("Science: ");
                    input = Console.ReadLine();
                    science = Convert.ToInt32(input);
                    if (science < 1 || science > 5)
                    {
                        Console.WriteLine(errorMessage);
                        return;
                    }

                    Console.Write("English: ");
                    input = Console.ReadLine();
                    english = Convert.ToInt32(input);
                    if (english < 1 || english > 5)
                    {
                        Console.WriteLine(errorMessage);
                        return;
                    }

                    Console.Write("Any unexcused absences (yes/no)");
                    input = Console.ReadLine();
                    input = input.ToLower();
                    if (input != "yes" && input != "no")
                    {
                        Console.WriteLine(errorMessage);
                        return;
                    }
                    hasUnexcusedAbsences = input == "yes";
                }
                catch(Exception)
                {
                    Console.WriteLine(errorMessage);
                    return;
                }

                //Evaluations
                //You need arithmeti averages of all grades
                double average = (mathematics + informationTechnology + science + english) / 4.0;
                string message;
                //Testing all conditions for excellence
                if(average < 1.5001 && 
                    mathematics <= 2 && 
                    informationTechnology <= 2 &&
                    english <= 2 &&
                    english <= 2 &&
                    !hasUnexcusedAbsences)
                {
                    message = "Excellent.";
                }
                else
                {
                    //Here you know the result is not excellent, so testing the other two possibilities
                    if (mathematics == 5 ||
                        informationTechnology == 5 ||
                        science == 5 ||
                        english == 5)
                    {
                        message = "Failed";
                    }
                    else
                    {
                        message = "Good";
                    }
                }

                //Outputs
                Console.WriteLine("Summery Evaluation: " + message);
            }
            Console.WriteLine();
            Console.WriteLine();


            //Location 3573
            SecondCharacterTest();

            void SecondCharacterTest()
            {
                Console.WriteLine("SECOND CHARACTER TEST.");

                //Input
                Console.Write("Enter production label: ");
                string label = Console.ReadLine();
                string findX = label.Substring(1, 1);

                //evaluationg
                if(label.Length > 2 && findX.ToLower() == "x")
                {
                    Console.WriteLine("Label is OK");
                }
                else
                {
                    Console.WriteLine("Incorrect label");
                }
               
            }

            Console.WriteLine();
            Console.WriteLine();



            //Wait for enter
            Console.ReadLine();
        }
    }
}
