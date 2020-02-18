using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using operations;
using System.Threading;

namespace SigFig_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nWelcome User! You are now using the Significant Figures Calculator!");
            Thread.Sleep(3000);
            Console.WriteLine("\nThis calculator will add, subtract, multiply, or divide, while keeping into consideration the amount of significant figures neccessary!");
            Thread.Sleep(3000);
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nWhat operation would you like to do? You can do the type the 4 operations I mentioned, and any upper, lower, or cap variation (IE add, ADD, Add)");
                string decision = Console.ReadLine();
                if (decision == "Add" || decision == "add" || decision == "ADD")
                {
                    Operations a = new Operations();
                    a.Addition();
                    Thread.Sleep(3000);
                    continue;
                }
                else if (decision == "Subtract" || decision == "subtract" || decision == "SUBTRACT")
                {
                    Operations s = new Operations();
                    s.Subtraction();
                    Thread.Sleep(3000);
                    continue;
                }
                else if (decision == "Divide" || decision == "divide" || decision == "DIVIDE")
                {
                    Operations d = new Operations();
                    d.Division();
                    Thread.Sleep(3000);
                    continue;
                }
                else if (decision == "Multiply" || decision == "multiply" || decision == "MULTIPLY")
                {
                    Operations m = new Operations();
                    m.Multiplication();
                    Thread.Sleep(3000);
                    continue;
                }
                else if (decision == "quit" || decision == "Quit" || decision == "QUIT")
                {
                    Console.WriteLine("\nHave a great day!");
                    Console.WriteLine("Press any button to quit...");
                    Console.ReadLine();
                    break;
                }
                else {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nI'm sorry, but that is not a valid choice...");
                    Thread.Sleep(3000);
                    continue;
                }
            }

        }
    }
}
