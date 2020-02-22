using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ConsoleApp63
{
    class SimpleCalculator
    {

        public double Calculate(int num1, int num2, int option)
        {
            double result = 0;
            double divideByZero;
            try
            {
                divideByZero = num1 / num2;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You just had to do it, didn't you?");
                Console.ResetColor();
                throw;
            }
            switch (option)
            {
                case 1: return result = num1 + num2;
                case 2: return result = num1 - num2;
                case 3: return result = num1 * num2;
                case 4: return result = divideByZero;
            }
            return result;
        }

        public void PrintResultNicely(double result)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The result is: " + result);
            Console.ResetColor();
        }

        public int NumberGetter()
        {
            Console.Write("Please enter a positive number: ");
            if (int.TryParse(Console.ReadLine(), out int num) == true)
            {
                if (num < 1)
                {
                    ConsoleAlert("Input is not a positive number, please retry", Convert.ToString(num));
                    ConsoleResetter();
                    NumberGetter();
                }
            }
            else
            {   
                ConsoleAlert("Input is not a valid number", Convert.ToString(null));
                ConsoleResetter();
                NumberGetter();
            }
            return num;
        }

        #region UI & IO
        public void PrintMenu()
        {
            Console.WriteLine("\t\t-----------------------------------");
            Console.WriteLine("\t\tWelcome to Menash Simple Calculator");
            Console.WriteLine("\t\t\t Choose your destiny:");
            Console.WriteLine("\t\t-----------------------------------");
            Console.Write("\t\t1...Add\n\t\t2...Subtract\n\t\t3...Multiply\n\t\t4...Divide (not by zero!)\n\n");
        }

        public int GetUserChoice()
        {
            Console.Write("\t\tPlease Select your option (1-4): ");
            if (int.TryParse(Console.ReadLine(), out int num) == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                ConsoleAlert("Input is not a valid number", Convert.ToString(num));
                ConsoleResetter();
                PrintMenu();
                GetUserChoice();
            }
            else if (num < 1 || num > 4)
            {
                ConsoleAlert( " Is invalid, number must bet between 1-4, please retry" , Convert.ToString(num));
                ConsoleResetter();
                GetUserChoice();
            }
            return num;
        }

        private void ConsoleAlert(string alert, string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (Convert.ToInt32(value) != 0)
            {
                Console.WriteLine($"\t\t {value} {alert}");
            }

            else
            {
                Console.WriteLine($"{alert}");    
            }
            Console.ResetColor();
            Thread.Sleep(1000);
        }
        private void ConsoleResetter()
        {
            Console.ResetColor();
            Console.Clear();
        }

        public bool RunAnother()
        {
            Console.Write("Run again? (choose y/n)... ");
            string user = Console.ReadLine();
            if (user == "y" || user == "Y")
                return true;
            if (user == "n" || user == "N") 
                return false;
            else
            {
                return false;
            }
        }
#endregion
    }
}
