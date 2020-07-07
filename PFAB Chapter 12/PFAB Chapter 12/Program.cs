using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFAB_Chapter_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Understand different kinds of numbers
            //More Number types Location 2456

            try
            {
                //Immediatly outputs
                Console.WriteLine("Signed whole numbers");
                Console.WriteLine("====================");
                Console.WriteLine("sbyte: " + sbyte.MinValue + " to " + sbyte.MaxValue);
                Console.WriteLine("short: " + short.MinValue + " to " + short.MaxValue);
                Console.WriteLine("int: " + int.MinValue + " to " + int.MaxValue);
                Console.WriteLine("long: " + long.MinValue + " to " + long.MaxValue);
                Console.WriteLine();
                Console.WriteLine("Unsigned whole numbers");
                Console.WriteLine("----------------------");
                Console.WriteLine("byte: " + byte.MinValue + " to " + byte.MaxValue);
                Console.WriteLine("ushort: " + ushort.MinValue + " to " + ushort.MaxValue);
                Console.WriteLine("uint: " + uint.MinValue + " to " + uint.MaxValue);
                Console.WriteLine("ulong: " + ulong.MinValue + " to " + ulong.MaxValue);
                Console.WriteLine();
                Console.WriteLine("Basic decimal numbers");
                Console.WriteLine("_____________________");
                Console.WriteLine("decimal: " + decimal.MinValue + " to " + decimal.MaxValue);
                Console.WriteLine();
                Console.WriteLine();
            }
            catch (Exception)
            {

                Console.WriteLine();
            }

            try
            {
                //Memory Consumption 2513
                //Outputs
                Console.WriteLine("Whole Numbers");
                Console.WriteLine("=============");
                Console.WriteLine("byte: " + sizeof(byte));
                Console.WriteLine("sbyte: " + sizeof(sbyte));
                Console.WriteLine();
                Console.WriteLine("short: " + sizeof(short));
                Console.WriteLine("ushort: " + sizeof(ushort));
                Console.WriteLine();
                Console.WriteLine("int: " + sizeof(int));
                Console.WriteLine("uint;" + sizeof(uint));
                Console.WriteLine();
                Console.WriteLine("long: " + sizeof(long));
                Console.WriteLine("ulong: " + sizeof(ulong));
                Console.WriteLine();
                Console.WriteLine("Decimal Numbers");
                Console.WriteLine("_______________");
                Console.WriteLine("float: " + sizeof(float));
                Console.WriteLine("double: " + sizeof(double));
                Console.WriteLine("decimal: " + sizeof(decimal));
            }
            catch (Exception)
            {

                Console.WriteLine("");
            }
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                //Overflow Locaton 2527
                //Multiplying a million by a million
                int amillion = 1000000;
                int result = amillion * amillion;
                long resultLong = amillion * amillion;

                //Outputs
                Console.WriteLine("Million times million: " + result);
                Console.WriteLine("also in long " + resultLong);
            }
            catch (Exception)
            {

                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            //Dealing with Overflow Location 2555
            //0. Preparation
            int million = 1000000;
            
            //1. Crash at least, we do not want nonsense
            Console.WriteLine("1. Calculation");
            try
            {
                long result = million * million;
                Console.WriteLine("Million times million: " + result);

            }
            catch(Exception)
            {
                Console.WriteLine("I cannot calculate this.");
            }

            //2.Correc calculation of a big value
            Console.WriteLine("2. Calculation");
            long millionInLong = million;
            long correctResult = millionInLong * millionInLong;
            Console.WriteLine("Million times million: " + correctResult.ToString("N0"));

            //3. Alernative calculation of a big value
            Console.WriteLine("3. Calculation");
            long correctResultAlternatively = (long)million * (long)million;
            Console.WriteLine("Million times million: " + correctResultAlternatively.ToString("N0"));










            //Wait for enter
            Console.ReadLine();


        }
    }
}
