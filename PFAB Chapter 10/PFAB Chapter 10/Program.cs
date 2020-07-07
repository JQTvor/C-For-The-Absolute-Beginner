using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFAB_Chapter_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs Location 2187 - 2200
            Console.WriteLine("Enter amount in Euros");
            string inputEuros = Console.ReadLine();
            double amountEuros = Convert.ToDouble(inputEuros);
            Console.WriteLine("Enter Euro exchange rate(How many dollars per 1 Euro");
            string inputEuroEchangeRate = Console.ReadLine();
            double euroEchangeRate = Convert.ToDouble(inputEuroEchangeRate);
            //Calculation
            double amountDollars = amountEuros * euroEchangeRate;
            //Output
            Console.WriteLine();
            Console.WriteLine("Amount in dollars: " + amountDollars);
            Console.WriteLine();
            Console.WriteLine();


            //Total Price Location 2200 - 2211
            //Fixed Values
            const double bookPrice = 29.8, dvdPrice = 9.9, shipmentPrice = 25;
            //Inputs
            Console.WriteLine("Order");
            Console.WriteLine("-----");
            //Amount of Books
            Console.Write("Product\"C# Programming for Absolute Beginners(book)\" - Enter number of pieces ");
            string inputBookPieces = Console.ReadLine();
            int bookPieces = Convert.ToInt32(inputBookPieces);
            //Amount of DVDs
            Console.Write("Product\"All Quiet on the Western Front(DVD)\" - Enter number of pieces ");
            string inputDVDPieces = Console.ReadLine();
            int dvdPieces = Convert.ToInt32(inputDVDPieces);
            //Calculations
            double totalForBook = bookPrice * bookPieces;
            double totalForDVD = dvdPrice * dvdPieces;
            double totalForOrder = totalForBook + totalForDVD + shipmentPrice;
            //Outputs
            Console.WriteLine();
            Console.WriteLine(
 @"Order Calculation: 
--------------------- 
   Book : " + totalForBook);
            Console.WriteLine(@"
    DVD : " + totalForDVD);
            Console.WriteLine(@"
Shipment: " + shipmentPrice);
                Console.WriteLine(@"
   Total: " + totalForOrder);
            Console.WriteLine();
            Console.WriteLine();


            //Commissions Location 2235
            //Inputs
            Console.Write("Enter customer price of product: ");
            string inputPrice = Console.ReadLine();
            double customerPrice = Convert.ToDouble(inputPrice);
            Console.Write("Enter Merchant commission (Percent): ");
            string inputMerchantPercents = Console.ReadLine();
            int merchantPercent = Convert.ToInt32(inputMerchantPercents);
            Console.Write("Enter distributor commission (percents): ");
            string inputDistributorPercent = Console.ReadLine();
            int distributorPercent = Convert.ToInt32(inputDistributorPercent);
            //Calculations
            double coeficient1 = 1 - merchantPercent / 100.0;
            double coeficient2 = 1 - distributorPercent / 100.0;
            double wholeSalePrice = customerPrice * coeficient1;
            double priceAfterCommissionSubtraction = wholeSalePrice * coeficient2;
            double merchantIncome = customerPrice - wholeSalePrice;
            double distributorIncome = wholeSalePrice - priceAfterCommissionSubtraction;
            double producerIncome = priceAfterCommissionSubtraction;
            //Outputs
            Console.WriteLine();
            Console.WriteLine("Income Division");
            Console.WriteLine("---------------");
            Console.WriteLine("Merchant: " + merchantIncome);
            Console.WriteLine("Distrutor: " + distributorIncome);
            Console.WriteLine("Producer: " + producerIncome);
            Console.WriteLine();
            Console.WriteLine();

            //Rounding Program location 2260 - 2268
            //For simplicity, inputs are fixed in this program
            //Some amounts, e.g. after commission calculations, cents fractions are possible.
            double amount1 = 1234.567;
            double amount2 = 9.876;
            //Displaying inputs (original values)
            Console.WriteLine("First amount (Original value): " + amount1);
            Console.WriteLine("Second amount (Orignal value): " + amount2);
            Console.WriteLine();
            //Rounding just for output
            Console.WriteLine("First amount displayed with cent precision: " + amount1.ToString("N2"));
            Console.WriteLine("Second amount displayed with cent precision: " + amount2.ToString("N2"));
            Console.WriteLine();
            //Rounding for further calculations and informative output
            double roundedAmount1 = Math.Round(amount1, 2); // 2 = 2 decimal places.
            double roundedAmount2 = Math.Round(amount2, 2);
            Console.WriteLine("First amount rounded to cents: " + roundedAmount1);
            Console.WriteLine("Second amount rounded to cents: " + roundedAmount2);
            Console.WriteLine();
            //Calculations
            double sumOfOriginalAmounts = amount1 + amount2;
            double sumOfRoundedAmounts = roundedAmount1 + roundedAmount2;
            //Calculation outputs.
            Console.WriteLine("Sum of original amounts: " + sumOfOriginalAmounts.ToString("N2"));
            Console.WriteLine("Sum of rounded amounts: " + sumOfRoundedAmounts.ToString("N2"));
            Console.WriteLine();
            Console.WriteLine();

            //Further Rounding 2276 - 2287
            //input
            Console.Write("Enter(decimal) amount in dollars: ");
            string input = Console.ReadLine();
            double amount = Convert.ToDouble(input);
            //To Dollars
            double nearest = Math.Round(amount);
            double alwaysDown = Math.Floor(amount);
            double alwaysUp = Math.Ceiling(amount);
            Console.WriteLine("");
            Console.WriteLine("To dollars");
            Console.WriteLine("===========");
            Console.WriteLine("Nearest :" + nearest);
            Console.WriteLine("Always Down: " + alwaysDown);
            Console.WriteLine("Always Up: " + alwaysUp);
            //To cents
            nearest = Math.Round(amount, 2);
            alwaysDown = Math.Floor(100 * amount) / 100;
            alwaysUp = Math.Ceiling(100 * amount) / 100;
            Console.WriteLine();
            Console.WriteLine("To Cents");
            Console.WriteLine("--------");
            Console.WriteLine("Nearest: " + nearest);
            Console.WriteLine("Always Down: " + alwaysDown);
            Console.WriteLine("Always Up: " + alwaysUp);
            //To Hundreds of dollars
            nearest = 100 * Math.Round(amount / 100);
            alwaysDown = 100 * Math.Floor(amount / 100);
            alwaysUp = 100 * Math.Ceiling(amount / 100);
            Console.WriteLine();
            Console.WriteLine("To the Hundreds of dolars");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Nearest: " + nearest);
            Console.WriteLine("Always Down: " + alwaysDown);
            Console.WriteLine("Always Up: " + alwaysUp);
            Console.WriteLine();
            Console.WriteLine();

            //Value-Added Tax 2300 - 2313
            //Inputs
            Console.Write("Enter customer price of a product: ");
            inputPrice = Console.ReadLine();
            customerPrice = Convert.ToDouble(inputPrice);
            Console.Write("Enter VAT rate in %: ");
            string inputVatRate = Console.ReadLine();
            double vatRate = Convert.ToDouble(inputVatRate);
            //Calculations
            double divisor = 1 + vatRate / 100.0;
            double calculatedPricewithoutVat = customerPrice / divisor;
            double priceWithoutVat = Math.Round(calculatedPricewithoutVat, 2);
            double vat = customerPrice - priceWithoutVat;
            //Outputs
            Console.WriteLine();
            Console.WriteLine("Price without VAT: " + priceWithoutVat.ToString("N2"));
            Console.WriteLine("VAT: " + vat.ToString("N2"));






            //Waiting for Enter
            Console.ReadLine();

        }
    }
}
