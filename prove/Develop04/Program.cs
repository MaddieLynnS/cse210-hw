using System;

class Program
{
    static void Main(string[] args)
    {
        //Initializing activities and variables
        BreathingActivity breathing = new BreathingActivity();
        ReflectionActivity reflection = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();
        bool _notQuit = true;
        

        //main program that lets learner pick activities to complete
        //until they enter 'quit'
        while (_notQuit)
        {
            //Menu options that show every time the user returns to main loop
            Console.Clear();
            Console.WriteLine("Here are the menu options: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Activity Descriptions");
            Console.Write("Enter a number to do that activity, or enter 'quit' if you are done for today: ");
            string entry = Console.ReadLine();

            //Ensure user has a valid entry
            while (entry != "quit")
            {
                if ((entry != "1") && (entry != "2") && (entry != "3") && (entry != "4"))
                {
                    Console.Write("Invalid entry. Try again! ");
                    entry = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            //If user entered 'quit', update bool to end program. 
            if (entry == "quit")
            {
                _notQuit = false;
            }
            //Else run chosen activity based on input.
            else
            {
                int timeInSecs;
                Console.Clear();
                //Switch case for each of the menu activities!
                switch (entry)
                {
                    //Breathing activity
                    case "1":
                        Console.Write(breathing.StartMessage());
                        timeInSecs = int.Parse(Console.ReadLine());
                        breathing.SetDuration(timeInSecs);
                        breathing.Breathe();
                        Console.WriteLine(breathing.EndMessage());
                        Thread.Sleep(4000);
                        break;
                    //Reflection activity
                    case "2":
                        Console.Write(reflection.StartMessage());
                        timeInSecs = int.Parse(Console.ReadLine());
                        reflection.SetDuration(timeInSecs);
                        reflection.Reflect();
                        Console.WriteLine(reflection.EndMessage());
                        Thread.Sleep(4000);
                        break;
                    //Listing activity
                    case "3":
                        Console.Write(listing.StartMessage());
                        timeInSecs = int.Parse(Console.ReadLine());
                        listing.SetDuration(timeInSecs);
                        listing.MakeList();
                        Console.WriteLine(listing.EndMessage());
                        Thread.Sleep(4000);
                        break;
                    //All activities listed with name and description
                    case "4":
                        Console.WriteLine("Here are descriptions for each of the activities:");
                        Thread.Sleep(2000);
                        Console.WriteLine(breathing.ToString());
                        Thread.Sleep(2000);
                        Console.WriteLine(reflection.ToString());
                        Thread.Sleep(2000);
                        Console.WriteLine(listing.ToString());
                        Thread.Sleep(2000);
                        Console.Write("\nHit enter when you are ready to return to the menu.");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid input. How'd you even get here?");
                        break;
                }
            }
        }
    }
}