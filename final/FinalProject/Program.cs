using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        Course english = new Course("Eng 101", 12);

        Console.WriteLine(english.GetType().ToString());

        if (english.GetType().ToString() == "Course")
        {
            Console.WriteLine("Hooray- you did it.");

        }
    }
}