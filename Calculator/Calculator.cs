// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
namespace Calculator
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            Console.WriteLine("Welcome to my calculator!");

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Square Root");
            Console.WriteLine("6. Power");
            Console.Write("Your option? ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("You have selected Addition ");
                    Console.WriteLine("Please enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Please enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "2":
                    Console.WriteLine("You have selected Subtraction ");
                    Console.WriteLine("Please enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 - num2));
                    break;
                case "3":
                    Console.WriteLine("You have selected Multiplication ");
                    Console.WriteLine("Please enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 * num2));
                    break;
                case "4":
                    Console.WriteLine("You have selected Division ");
                    Console.WriteLine("Please enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 / num2));
                    break;
                case "5":
                    Console.WriteLine("You have selected Square Root ");
                    Console.WriteLine("Please enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Your result: {num1}  = " + (Math.Sqrt(num1)));
                    break;
                case "6":
                    Console.WriteLine("You have selected Power ");
                    Console.WriteLine("Please enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Your result: {num1} ^ {num2} = " + (Math.Pow(num1, num2)));
                    break;
                case "":
                    Console.WriteLine("Invalid option");
            }

        }

    }
}

