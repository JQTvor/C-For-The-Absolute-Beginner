using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFAB_Chapter_22
{
    class Program
    {
        static void Main(string[] args)
        {
            EveryOther();
            TEL();
            AltSolution();
            TEL();
            DecendingSeries();
            TEL();
            DecimalNumbers();
            TEL();
            DecNumbers();
            TEL();
            SecondPowers();
            TEL();
            TwoInARow();
            TEL();
            TwoIndependentSeries();
            TEL();

            Console.ReadLine();


            void TEL()
            {
                Console.WriteLine();
                Console.WriteLine();
            }

            void EveryOther()
            {
                //output
                for (int number = 2; number <= 20; number += 2)
                    Console.WriteLine(number);
            }

            void AltSolution()
            {
                //Output
                for (int line = 1; line <= 10; line++)
                {
                    int displayedNumber = line * 2;
                    Console.WriteLine(displayedNumber);
                }
            }

            void DecendingSeries()
            {
                //Output
                for(int number = 10; number >=1; number--)
                    {
                    Console.WriteLine(number);
                    }
            }

            void DecimalNumbers()
            {
                //Output
                for(double number = 9; number >=0; number -= .9)
                {
                    Console.WriteLine(number.ToString("n1"));
                }
            }

            void DecNumbers()
            {
                //Output
                for(double number = 9; number >= -.0001; number -=.09)
                {
                    Console.WriteLine(number.ToString("N1"));
                }
            }

            void SecondPowers()
            {
                //Output
                for(int number = 1; number <=10; number ++)
                {
                    int secondPower = number * number;
                    Console.WriteLine(number.ToString() + " " + secondPower.ToString());
                }
            }

            void TwoInARow()
            {
                //Output
                for(int number = 1; number <= 20; number++)
                {
                    Console.Write(number);
                    //What goes after the number depeonds on even/odd test
                    if(number % 2 != 0)
                    {
                        //Odd Number, displayed space
                        Console.Write(" ");
                    }
                    else
                    {
                        //Even number, new line
                        Console.WriteLine();
                    }
                }
            }


            void TwoIndependentSeries()
            {
                //Preparation
                int first = 111;
                //Outputs
                for(int second = 237; second <=270; second +=3)
                {
                    string firstText = first >= 97 ?
                        first.ToString().PadLeft(3) : "   ";

                    //Actual Output
                    Console.WriteLine(firstText + " " + second.ToString());

                    first -= 2;                }
            }

        }
    }
}
