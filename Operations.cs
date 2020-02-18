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
        public void Addition() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nFirst, is your first number a decimal or a whole number? Just type 'whole' for a whole number.");
            Thread.Sleep(2000);
            string numType = Console.ReadLine();
            if (numType == "decimal" || numType == "DECIMAL" || numType == "Decimal") {
                Console.WriteLine("\nWhat is your first decimal number?");
                try
                {
                    
                }
                catch (Exception)
                {

                    Addition();
                }
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