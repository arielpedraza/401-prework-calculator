using System;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            double operand1, operand2, answer = 0.0;

            Console.WriteLine("Welcome to the world's most simple calculator!");
            Console.Write("Enter a number:");
            operand1 = double.Parse(Console.ReadLine());
            do
            {
                option = DisplayOptions();
                Console.Write("Enter a number:");
                operand2 = double.Parse(Console.ReadLine());
                Console.WriteLine(Calculate(operand1, operand2, option, out answer));
                operand1 = answer;
            } while (option != "done");
            Console.ReadLine();
        }

        static string DisplayOptions()
        {
            Console.WriteLine("1. Add \n2. Subtract \n3. Multiply \n4. Divide \n5. Done");
            string userInput = Console.ReadLine();
            // if (userInput )
            return userInput;
        }

        static string Calculate(double operand1, double operand2, string option, out double answer)
        {
            switch (option)
            {
                case "1":
                    option = "+";
                    answer = operand1 + operand2;
                    break;
                case "2":
                    option = "-";
                    answer = operand1 - operand2;
                    break;
                case "3":
                    option = "*";
                    answer = operand1 * operand2;
                    break;
                case "4":
                    option = "/";
                    answer = operand1 / operand2;
                    break;
                default:
                    answer = 0.0;
                    break;
            }
            return String.Format("{0} {2} {1} = {3}", operand1, operand2, option, answer);
        }
    }
}
