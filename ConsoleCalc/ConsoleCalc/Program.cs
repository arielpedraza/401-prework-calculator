using System;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world's most simple calculator!");
            Console.WriteLine("Enter a number:");
            string operand1 = Console.ReadLine();
            string option = DisplayOptions();
            Console.WriteLine("Enter a number:");
            string operand2 = Console.ReadLine();
            Console.WriteLine(Calculate(int.Parse(operand1), int.Parse(operand2), option));
            Console.ReadLine();
        }

        static string DisplayOptions()
        {
            Console.WriteLine("1. Add\n2. Subtract\n3. Multiply\n4. Divide\n5. Done");
            return Console.ReadLine();
        }

        static string Calculate(int operand1, int operand2, string option)
        {
            double answer = 0.0;
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
                    break;
            }
            return String.Format("{0} {2} {1} = {3}", operand1, operand2, option, answer);
        }
    }
}
