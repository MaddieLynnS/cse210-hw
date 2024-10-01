using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your favorite color: ");
        string color = Console.ReadLine();
        Console.WriteLine($"Here is your favorite color: {color}");

        List<string> animals = new List<string>();
        animals.Add("chicken");
        animals.Add("goat");
        animals.Add("sheep");
        animals.Add("cow");

        Console.WriteLine("Animals:");
        foreach (string animal in animals)
        {
            Console.WriteLine($" * {animal}");
        }
    }
}