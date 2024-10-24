using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverb", "3", "5", "6");
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart, and lean not unto thine own understanding. In all thy ways acknowledge Him, and He shall direct thy paths.");
        scripture.makeListofWords();

        //Runs until user enters quit or the scripture is completely hidden
        while (true)
        {
            Console.WriteLine(scripture);
            Console.Write("Press enter to continue erasing words or type 'quit' to finish: ");
            if(Console.ReadLine() == "quit" || scripture.IsScriptureHidden())
            {
                break;
            }
            Console.Clear();
        }

        Console.WriteLine("Thanks for logging on today! Hope this app helped you :)");

    }
}