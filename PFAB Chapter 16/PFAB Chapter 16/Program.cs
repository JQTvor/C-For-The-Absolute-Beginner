using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PFAB_Chapter_16
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Appending Extention
                //location 3065

                //input
                Console.Write("Enter image name:  ");
                string fileName = Console.ReadLine();

                //Appending extension (ONLY IN CASE OF NEED)
                if (!fileName.ToLower().EndsWith(".png"))
                    fileName += ".png";

                //output
                Console.WriteLine("We are going to use name: " + fileName);
            }
            catch (Exception)
            {

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                //Heads and Tails
                //location 3092
                //random number generator
                Random randomNumbers = new Random();

                //Random number 0 or 1 and it's transformation
                int randomNumber = randomNumbers.Next(0, 1 + 1);

                if (randomNumber == 0)
                    Console.WriteLine("Head tossed");
                else
                    Console.WriteLine("Tail tossed");

            }
            catch (Exception)
            {

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                //Deadline checking
                //Location 3102

                //Input
                Console.Write("Enter order dealine:  ");
                string input = Console.ReadLine();
                DateTime endteredDeadline = Convert.ToDateTime(input);

                //Checking entered value
                DateTime today = DateTime.Today;
                if (endteredDeadline < today)
                    Console.WriteLine("Error!  You have enetered a date in the past.");
                else
                    Console.WriteLine("Deadline accepted.");
            }
            catch (Exception)
            {

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                //Invoice Date Check
                //Location 3133

                //Input
                Console.Write("Payment date:  ");
                string inputPayment = Console.ReadLine();
                DateTime paymentDate = Convert.ToDateTime(inputPayment);
                Console.Write("Invoice Date:  ");
                string inputInvoice = Console.ReadLine();
                DateTime invoiceDate = Convert.ToDateTime(inputInvoice);

                //Checking
                bool ok = true;
                if (invoiceDate < paymentDate)
                {
                    Console.WriteLine("Invoice date cannot precede the payment date.");
                    ok = false;
                }
                if (invoiceDate > paymentDate.AddDays(15))
                {
                    Console.WriteLine("Invoice cannot be issued later than 15 days after payment");
                    ok = false;
                }
                if (ok)
                    Console.WriteLine("Dates accepted.");
            }
            catch (Exception)
            {

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            try
            {
                //Spanish Day of the week
                //location 4401

                //input
                Console.Write("Enter a date.  ");
                string input = Console.ReadLine();
                DateTime enteredDate = Convert.ToDateTime(input);

                //Finding the day of the week in enumeration
                DayOfWeek dayOfWeek = enteredDate.DayOfWeek;

                //Spanish text
                string spanish = "";
                if (dayOfWeek == DayOfWeek.Monday)
                    spanish = "Lunes";
                if (dayOfWeek == DayOfWeek.Tuesday)
                    spanish = "Martes";
                if (dayOfWeek == DayOfWeek.Wednesday)
                    spanish = "Miercoles";
                if (dayOfWeek == DayOfWeek.Thursday)
                    spanish = "Jueves";
                if (dayOfWeek == DayOfWeek.Friday)
                    spanish = "Viernes";
                if (dayOfWeek == DayOfWeek.Saturday)
                    spanish = "Sabado";
                if (dayOfWeek == DayOfWeek.Sunday)
                    spanish = "Domingo";

                //Output
                Console.WriteLine(spanish);
                if (enteredDate == new DateTime(1985, 5, 10))
                    Console.WriteLine("Best Day Ever.");
            }
            catch (Exception)
            {

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                //Switch Statement
                //Location 3169

                //input
                Console.Write("Enter a date: ");
                string input = Console.ReadLine();
                DateTime enteredDate = Convert.ToDateTime(input);

                //Finding day of the week
                DayOfWeek dayOfWeek = enteredDate.DayOfWeek;

                //Spanish Text
                string spanish = "";
                switch (dayOfWeek)
                {
                    case DayOfWeek.Monday:
                        spanish = "Lunes";
                        break;
                    case DayOfWeek.Tuesday:
                        spanish = "Martes";
                        break;
                    case DayOfWeek.Wednesday:
                        spanish = "Miercoles";
                        break;
                    case DayOfWeek.Thursday:
                        spanish = "Jueves";
                        break;
                    case DayOfWeek.Friday:
                        spanish = "Viernes";
                        break;
                    case DayOfWeek.Saturday:
                        spanish = "Sabado";
                        break;
                    case DayOfWeek.Sunday:
                        spanish = "Domingo";
                        break;
                }

                //Output
                Console.WriteLine(spanish);
                if (enteredDate == new DateTime(1985, 5, 10))
                    Console.WriteLine("Happiest Day Ever!");
            }
            catch (Exception)
            {

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            //Waiting For Enter
            Console.ReadLine();





        }
    }
}
