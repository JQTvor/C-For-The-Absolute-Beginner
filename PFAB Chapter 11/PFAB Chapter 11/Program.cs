using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFAB_Chapter_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chapter 11 Location 2336 
            try
            {
                //Text input of date
                Console.Write("Enter Date: ");
                string input = Console.ReadLine();
                
                //Conversion to DateTime object
                DateTime enterDate = Convert.ToDateTime(input);

                //Some calculations
                DateTime followingDay = enterDate.AddDays(1);
                DateTime previousDay = enterDate.AddDays(-1);

                //Outputs
                Console.WriteLine();
                Console.WriteLine("Entered Day: " + enterDate.ToLongDateString());
                Console.WriteLine("Following Day: " + followingDay.ToLongDateString());
                Console.WriteLine("Previous Day: " + previousDay.ToLongDateString());
            }
            catch(Exception)
            {
                //Treating incorrect input
                Console.WriteLine("Incorrect input");
            }
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                //Single Month Location 2351 - 2376
                //Date Input
                Console.Write("Enter a date: ");
                string input = Console.ReadLine();
                DateTime enterDate = Convert.ToDateTime(input);

                //Calculations
                int enterYear = enterDate.Year;
                int enterMonth = enterDate.Month;
                DateTime firstDayOfMonth = new DateTime(enterYear, enterMonth, 1);
                DateTime lastDayofMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                //Outputs
                Console.WriteLine();
                Console.WriteLine("Corresponding month: " +
                    " from " + firstDayOfMonth.ToShortDateString() +
                    " to " + lastDayofMonth.ToShortDateString());

            }
            catch (Exception)
            {

                Console.WriteLine("Big Old Nope");
            }
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                //Quarter Location 2376
                //Date Input
                Console.Write("Enter a date: ");
                string input = Console.ReadLine();
                DateTime enterDate = Convert.ToDateTime(input);

                //Calculations
                int enteredYear = enterDate.Year;
                int enteredMonth = enterDate.Month;
                int numberOfQuarter = (enteredMonth + 2) / 3;
                int monthofQuarterStart = 3 * numberOfQuarter - 2;
                DateTime firstDayOfQuarter = new DateTime(enteredYear, monthofQuarterStart, 1);
                DateTime lastDayOfQuarter = firstDayOfQuarter.AddMonths(3).AddDays(-1);

                //Outputs
                Console.WriteLine();
                Console.WriteLine("Corresponding quarter: " +
                    "number-" + numberOfQuarter +
                    ", from " + firstDayOfQuarter.ToShortDateString() +
                    " to " + lastDayOfQuarter.ToShortDateString());

            }
            catch (Exception)
            {

                Console.WriteLine("Nope");
            }
            Console.WriteLine();
            Console.WriteLine();


            try
            {
                //Date Difference Location 2415
                //Input
                Console.Write("Enter your date of birth: ");
                string input = Console.ReadLine();
                DateTime dateOfBirth = Convert.ToDateTime(input);

                //Today
                DateTime today = DateTime.Today;

                //Date Difference
                TimeSpan difference = today - dateOfBirth;
                int numberOfDays = difference.Days;

                //Output
                Console.WriteLine();
                Console.WriteLine("Today is: " + today.ToShortDateString());
                Console.WriteLine("The world likes you for this number of days: " +
                    numberOfDays.ToString("N0"));

            }
            catch (Exception)
            {

                Console.WriteLine("Nope.");
            }
            Console.WriteLine();
            Console.WriteLine();


            //Time Zones and UTC Location 2427
            //Current Time Serves as input
            DateTime now = DateTime.Now;
            DateTime UtcNow = DateTime.UtcNow;
            DateTimeOffset completeInstant = DateTimeOffset.Now;
            DateTimeOffset utcCompleteinstant = DateTimeOffset.UtcNow;

            //Outputs
            Console.WriteLine("Now: " + now);
            Console.WriteLine("UTC Now: " + UtcNow);
            Console.WriteLine("Time zone (offset again UTC): " +
                completeInstant.Offset.TotalHours);
            Console.WriteLine("UTC now (including time zone): " + utcCompleteinstant);


            //Waiting for Enter
            Console.ReadLine();

        }
    }
}
