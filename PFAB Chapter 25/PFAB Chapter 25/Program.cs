using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFAB_Chapter_25
{
    class Program
    {
        static void Main(string[] args)
        {
            void TEL()
            { Console.WriteLine();
                Console.WriteLine();
            }

            TGIF();
            
            void TGIF()
            {
                //Today's Date
                DateTime today = DateTime.Today;
                //Moving day after day until hit on Friday
                DateTime date = today;
                while(date.DayOfWeek != DayOfWeek.Friday)
                {
                    date = date.AddDays(1);
                }
                //Calculating remaining days
                TimeSpan dateDiffernece = date - today;
                int daysRemaining = dateDiffernece.Days;

                //Output
                Console.WriteLine("Nearest Friday: " + date.ToShortDateString());
                Console.WriteLine("Remaining days: " + daysRemaining.ToString());
                if(daysRemaining == 0)
                    Console.WriteLine("Thank your god!");
            }

            TEL();
            Power();

            void Power()
            {
                //Input
                Console.Write("Enter x(number to be raised): ");
                string inputX = Console.ReadLine();
                double x = Convert.ToDouble(inputX);
                Console.Write("Enter n (power): ");
                string inputN = Console.ReadLine();
                int n = Convert.ToInt32(inputN);

                //Calculating
                double result = 1;
                for(int count = 0; count < n; count++)
                {
                    result *= x;
                }

                //Output
                Console.WriteLine("x^n=" + result.ToString());
            }
            TEL();
            Sine();

            void Sine()
            {
                //Input
                Console.Write("Enter an angle in degrees: ");
                string input = Console.ReadLine();
                double angle = Convert.ToInt32(input);

                //Converting to radians
                double x = Math.PI / 180 * angle;

                //Prep
                double member;
                double sum = 0;
                double tinyValue = 1e-15;
                double sign = 1;
                double power = x;
                double factorial = 1;
                double multiplier = 1;
                //sum of the series
                do
                {
                    //Calculating current members of the series
                    member = sign * power / factorial;

                    //Appending to sum
                    sum += member;

                    //Preparing next step
                    sign *= -1;
                    multiplier++;
                    factorial *= multiplier;
                    multiplier++;
                    factorial *= multiplier;
                    power *= x * x;


                } while (Math.Abs(member) > tinyValue);

                //Output
                Console.WriteLine("Our Value: " + sum.ToString());
                Console.WriteLine("Math.Sin: " + Math.Sin(x).ToString());
            }
            TEL();
            MoonLanding();

            void MoonLanding()
            {
                //initial values
                double h = 50, v = 8, mF = 35;

                //Preparation
                bool malfunction = false;

                //repeating individual landing steps
                while(h >= 0)
                {
                    //displaying current values
                    string height = "Height: " + h.ToString("n1");
                    string velocity = "Velocity: " + v.ToString("n1");
                    string fuel = "Fuel: " + mF.ToString("n1");
                    Console.WriteLine(height + " " + velocity + " " + fuel);
                    //input
                    Console.Write("Enter precentage of breaking(0-100)");
                    string input = Console.ReadLine();
                    double precent = 0;

                    try
                    {
                        precent = Convert.ToDouble(input);
                        if (precent < 0 || precent > 100)
                            malfunction = true;
                    }
                    catch(Exception)
                    {
                        malfunction = true;
                    }
                    if(malfunction)
                    {
                        precent = 0;
                        Console.WriteLine("CONTROL MALFUNCTION!");
                    }

                    //Fuel Check
                    if(mF <=0)
                    {
                        precent = 0;
                        Console.WriteLine("NO FUEL!");
                    }

                    //Calulating New Values
                    double F = 360 * precent;
                    double a = 1.62 - F / 8000;
                    h -= v + a / 2;
                    v += a;
                    mF = F / 3000;

                    if(mF <=0)
                    {
                        mF = 0;
                    }

                    //Output of Empty Line
                    Console.WriteLine();

                }

                //Out put
                Console.WriteLine("Landing Velocity: " + v.ToString("n1"));
                string evaluation = v < 4 ? "Soft landing.  Congrats" : (v <= 8 ? "Hard Landing." : "Houston, crew is lost...");
                Console.WriteLine(evaluation);

            }

            Console.ReadLine();
        }
    }
}
