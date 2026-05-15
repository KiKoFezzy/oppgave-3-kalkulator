using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("C# Calculator");
        Console.WriteLine("-------------------");

        // Step 1: Get first number
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Step 2: Get operator
        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        // Step 3: Get second number
        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Step 4: Perform calculation
        double result = 0;
        switch (op)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                // Check for division by zero
                if (num2 != 0)
                    result = num1 / num2;
                else
                    Console.WriteLine("Error: Cannot divide by zero.");
                break;
            default:
                Console.WriteLine("Invalid operator"); //if an unvalid operator was picked
                return;
        }

        Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
    }
}