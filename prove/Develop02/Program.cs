using System;
using System.Linq.Expressions;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to My Journal, the program for logging a daily entries!");
        Console.WriteLine("Here goes nothing!");

        //Initialize variables that must live outside of main loop
        int userEntry = 0;
        Journal journal = new Journal();
        bool invalid;
        string prompt;
        string userInput;

        //this will run until the user enters '5', the quit option
        while (userEntry != 5)
        {
            //prints menu after every time a user completes an option
            Console.WriteLine("Here are the things you can do in this program:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Which action would you like to do? (Enter a number from 1-5) ");

            //could be better written but this ensures the user cant enter an invalid number or a letter
            try
            {
                do
                {
                    userEntry = int.Parse(Console.ReadLine());
                    invalid = userEntry < 1 || userEntry > 5;
                    if (invalid)
                    {
                        Console.WriteLine("Well this is awkward... your entry was invalid. Please try again.");
                    }
                } while (invalid);
            }
            catch (FormatException)
            {
                Console.WriteLine("Your entry was invalid. Please enter a number from 1-5");
            }

            //if and else ifs that run depending on what number the user entered//

            //ends program
            if (userEntry == 5)
            {
                Console.WriteLine("Thanks for logging on today! We hope you had a good experience!");
                continue;
            }
            //prompts the user, stores the input, and sends entry to Journal class for storing
            else if (userEntry == 1)
            {
                prompt = journal.PrintPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                userInput = Console.ReadLine();
                journal.AddEntry(new Entry(prompt, userInput, DateTime.Now.ToShortDateString()));
            }
            //prints all saved Entry objects in the Journal
            else if (userEntry == 2)
            {
                journal.PrintJournal();
            }
            //saves the Journal to a .txt file
            else if (userEntry == 3)
            {
                journal.SaveJournal();
            }
            //loads a previously saved .txt Journal file
            else if (userEntry == 4)
            {
                journal.LoadJournal();
            }
            Console.WriteLine("");
        }
    }
}