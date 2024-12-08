using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        // Course english = new Course("Eng 101", 12);

        // Console.WriteLine(english.GetType().ToString());

        // if (english.GetType().ToString() == "Course")
        // {
        //     Console.WriteLine("Hooray- you did it.");

        // }
        //Have student enter name, retrieve proper txt file

        //Student file will resave itself upon learner quitting,
        //ensuring any assignment updates will be saved

        Console.Clear();
        Console.WriteLine("Welcome to your account! Here you can view grades,"+
        " check assignment due dates, and turn in assignments! \nYou can also"+
        " see a list of all your assignments in order of which you should do first!");
        Thread.Sleep(3000);

        int userInput = 0;

        while (userInput != 9)
        {

            //Standard menu options
            Console.WriteLine("\nHere are the options you can choose from: ");
            Console.WriteLine("1. See courses");
            Console.WriteLine("2. See assignments for a certain course");
            Console.WriteLine("3. See all assignments (ordered by due date)");
            Console.WriteLine("4. See PRIORITIZED list of assignments");
            Console.WriteLine("5. See grades for a certain course");
            Console.WriteLine("6. See overall GPA");
            Console.WriteLine("7. Complete an assignment");
            Console.WriteLine("8. Create a new assignment");
            Console.WriteLine("9. Quit");

            Console.Write("What would you like to do? Enter a number 1-9: ");
            string input = Console.ReadLine();

            while(true)
            {
                if(int.TryParse(input, out userInput))
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid input. Try again! ");
                    input = Console.ReadLine();
                }
                {
                    switch(userInput)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                        case 7:
                            break;
                        case 8:
                            break;
                        case 9:
                            break;
                        default:
                            Console.WriteLine("Your entry was outside the indicated range. Try again!");
                            break;
                    }
                }
            }
        }
    }
}