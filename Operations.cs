using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace operations 
{
    class Operations 
    {
        public double firstNumber;
        public double secondNumber;
        public int firstSigFigs;
        public int secondSigFigs;
        public int numOfSigFigs;

        public void Addition() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nFirst, is your first number a decimal or a whole number? Just type 'whole' for a whole number.");
            Thread.Sleep(2000);
            string numType = Console.ReadLine();
            if (numType == "decimal" || numType == "DECIMAL" || numType == "Decimal")
            {
                Console.WriteLine("\nWhat is your first decimal number?");
                try
                {
                    firstNumber = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("That is not a decimal number! The operation will start from the beginning...");
                    Thread.Sleep(3000);
                    Addition();
                }


            }
            else if (numType == "whole" || numType == "WHOLE" || numType == "Whole") {
                Console.WriteLine("\nWhat is your first whole number?");
                try
                {
                    firstNumber = Convert.ToInt64(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("That is not a whole number! The operation will start from the beginning...");
                    Thread.Sleep(3000);
                    Addition();
                }
            }

            if (Convert.ToString(firstNumber).Contains(".")) {
                string fN = Convert.ToString(firstNumber);

                firstSigFigs = 
            }
            
            Console.WriteLine("\nThis is just to test a line of code. It outputted {0}");
        }

        public void Subtraction() {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nYour answer is...Nothing yet! This is just a test message.");
        }

        public void Multiplication() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nYour answer is...Nothing yet! This is just a test message.");
        }

        public void Division() {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nYour answer is...Nothing yet! This is just a test message.");
        }
    }
}