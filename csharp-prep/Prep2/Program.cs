using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);

        string letterGrade = "";

        if (percentage >= 90)
        {
            letterGrade = "A";
        }
        else if (percentage >= 80)
        {
            letterGrade = "B";
        }
        else if (percentage >= 70)
        {
            letterGrade = "C";
        }
        else if (percentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (percentage % 10 >= 7) 
        {
            if (letterGrade != "A" && letterGrade != "F")
            {
                letterGrade += "+";
            }
        }
        else if (percentage % 10 < 3)
        {
            if (letterGrade != "F")
            {
                letterGrade += "-";
            }
        }

        Console.WriteLine(letterGrade);
        Console.WriteLine(percentage >= 70 ? "Congratulations! You passed the class!" : "Sorry, your grade was too low. You can do better next time!");

    }
}