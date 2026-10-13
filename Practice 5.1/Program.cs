using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        bool running = true;

        Console.WriteLine("Welcome to my STACK PROGRAM");

        while (running)
        {
            Console.WriteLine("Choose what you want to do?");
            Console.WriteLine("1 - PUSH");
            Console.WriteLine("2 - POP");
            Console.WriteLine("3 - SEARCH");
            Console.WriteLine("4 - PEEK");
            Console.WriteLine("5 - DISPLAY");
            Console.WriteLine("6 - COUNT");
            Console.WriteLine("7 - EXIT");
            Console.Write("Enter code: ");

            if (!int.TryParse(Console.ReadLine(), out int code))
            {
                Console.WriteLine("\nInvalid input. Please enter a number from 1 to 7.\n");
                continue;
            }

            Console.WriteLine();

            switch (code)
            {
                case 1:
                    Console.Write("Enter new data to push: ");
                    if (int.TryParse(Console.ReadLine(), out int data))
                    {
                        stack.Push(data);
                        Console.WriteLine("New data has been added!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid data. Please enter a number.");
                    }
                    break;

                case 2:
                    Console.Write("Enter how many data you want to pop: ");
                    if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                    {
                        if (n > stack.Count)
                        {
                            Console.WriteLine("Operation not accepted.");
                        }
                        else
                        {
                            for (int i = 0; i < n; i++)
                                Console.WriteLine("Popped: " + stack.Pop());
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid number.");
                    }
                    break;

                case 3:
                    Console.Write("Enter data to search: ");
                    if (int.TryParse(Console.ReadLine(), out int target))
                    {
                        if (stack.Contains(target))
                            Console.WriteLine(target + " is found in the stack.");
                        else
                            Console.WriteLine(target + " is not found in the stack.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid data. Please enter a number.");
                    }
                    break;

                case 4:
                    if (stack.Count == 0)
                        Console.WriteLine("The stack is empty.");
                    else
                        Console.WriteLine("Top of the stack: " + stack.Peek());
                    break;

                case 5:
                    if (stack.Count == 0)
                    {
                        Console.WriteLine("The stack is empty.");
                    }
                    else
                    {
                        Console.WriteLine("Stack elements (top to bottom):");
                        foreach (int item in stack)
                            Console.WriteLine(item);
                    }
                    break;

                case 6:
                    Console.WriteLine("Number of data in the stack: " + stack.Count);
                    break;

                case 7:
                    Console.WriteLine("Program ended. Goodbye!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid code. Please choose 1 to 7.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
