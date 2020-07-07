using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFAB_Chapter_21
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

            //Choosing Text
            ChoosingText();

            void ChoosingText()
            {
                //input
                Console.Write("Enter text to repeat: ");
                string textToRepeat = Console.ReadLine();
                Console.Write("Enter number of repetitions: ");
                string input = Console.ReadLine();
                int howManyTimes = Convert.ToInt32(input);

                //Output
                for(int count = 0; count < howManyTimes; count++)
                {
                    Console.WriteLine(textToRepeat);
                }



            }
            TEL();

            AlternatingLoopOne();

            void AlternatingLoopOne()
            {
                //output
                Console.WriteLine("My main to-do list: ");
                for(int taskNumber = 1; taskNumber <= 10; taskNumber++)
                {
                    string taskText = taskNumber % 2 != 0 ? "Learning" : "Dating";
                    Console.WriteLine(taskNumber.ToString() + ". " + taskText);
                }

            }
            TEL();

            AlternatingLoopTwo();

            void AlternatingLoopTwo()
            {
                //Preparations
                Console.WriteLine("My main to-do list: ");
                bool learning = true;

                for(int taskNumber = 1; taskNumber <=10; taskNumber++)
                {
                    //Output
                    string taskText = learning ? "Learning": "Dating";
                    Console.WriteLine(taskNumber.ToString() + ". " + taskText);
                    //toggling the flag
                    learning = !learning;

                }
                TEL();

                AlternatingLoopThree();

                void AlternatingLoopThree()
                {
                    //Preparations
                    Console.WriteLine("My To-do List: ");
                    int taskNumber = 1;
                    for(int coupleCount = 0; coupleCount < 5; coupleCount++)
                    {
                        //Couple outcome and adjusting task number
                        Console.WriteLine(taskNumber.ToString() + ". Learning");
                        taskNumber++;
                        Console.WriteLine(taskNumber.ToString() + ". Dating");
                        taskNumber++;
                    }
                }
                TEL();

                RockPaperScissors();

                void RockPaperScissors()
                {
                    //Peparations
                    Random randomNumbers = new Random();
                    double playerPoints = 0;
                    double computerPoints = 0;
                    int rock = 1, scissors = 2, paper = 3;

                    //inputs
                    Console.Write("Enter your name: ");
                    string playerName = Console.ReadLine();
                    Console.Write("Enter number of game rounds: ");
                    string input = Console.ReadLine();
                    int totalRounds = Convert.ToInt32(input);
                    Console.WriteLine();

                    //Individual rounds
                    for(int roundNumber = 0; roundNumber < totalRounds; roundNumber++)
                    {
                        //Computer chooses
                        int computerChoice = randomNumbers.Next(1, 3 + 1);
                        //Player Chooses
                        Console.Write("Enter R, S, or P: ");
                        string playerInput = Console.ReadLine();
                        string playerInputUppercase = playerInput.ToUpper();
                        int playerChoice = playerInputUppercase == "R" ? rock: (playerInputUppercase == "S"?scissors:paper);

                        //Round Evaluation
                        string message = "";
                        if(computerChoice == rock && playerChoice == scissors ||
                           computerChoice == scissors && playerChoice == paper ||
                           computerChoice == paper && playerChoice == rock )
                        {
                            //Computer Wins
                            computerPoints += 1;
                            message = "I Won!";
                        }
                        else
                        {
                            //tie or player wins
                            if(computerChoice == playerChoice)
                            {
                                //Tie
                                computerPoints =+ .5;
                                playerPoints += .5;
                                message = "Tie!";
                            }
                            else
                            {
                                //Player Won
                                playerPoints += 1;
                                message = "You Won!";
                            }
                        }

                        //Round output
                        string playerchoiceInText = playerChoice == rock ?
                            "Rock" : (playerChoice == scissors ? "Scissors" : "Paper");
                        string computerchoiceInText = computerChoice == rock ?
                            "Rock" : (playerChoice == scissors ? "Scissors" : "Paper");
                        Console.WriteLine(playerName + ": Computer - " +
                            playerchoiceInText + ":" + computerchoiceInText);
                        Console.WriteLine(message);
                    }
                    //End of loop for game around.
                    //Game evaluation
                    Console.WriteLine("GAME OVER - OVERALL RESULT");
                    Console.WriteLine(playerName + ":Computer - " +
                        playerPoints.ToString() + ":" + computerPoints.ToString());
                }
                TEL();
            }


            Console.ReadLine();
        }
    }
}
