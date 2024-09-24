using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int squared = SquareNumber(num);
        DisplayResults(name, squared);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program! Glad you're here.");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int num)
    {
        return num * num;
    }

    static void DisplayResults(string name, int number)
    {
        Console.WriteLine($"Hello {name}, your number squared is: {number}");
    }
}