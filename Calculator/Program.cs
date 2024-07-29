// See https://aka.ms/new-console-template for more information
using System;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arithmetic Operations Console Application");

            while (true)
            {
                Console.WriteLine("\nEnter the first number:");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.WriteLine("Enter the second number:");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.WriteLine("Choose an operation: (+, -, *, /)");
                string operation = Console.ReadLine();

                double result;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation. Please choose one of the following: +, -, *, /.");
                        break;
                }

                Console.WriteLine("\nDo you want to perform another operation? (y/n)");
                string continueChoice = Console.ReadLine()?.ToLower();
                if (continueChoice != "y")
                {
                    break;
                }
            }

            Console.WriteLine("Thank you for using the Arithmetic Operations Console Application. Goodbye!");
        }
    }
}

