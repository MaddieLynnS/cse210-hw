using System;

class Program
{
    static void Main(string[] args)
    {
        //Initialize variables
        User user = new User("Bob Thompson");
        bool _notQuit = true;

        //main program that lets learner pick activities to complete
        //until they enter 'quit'
        while(_notQuit)
        {
            //Menu options that show every time the user returns to main loop
            user.DisplayStatus();
            Console.WriteLine("Here are the menu options: ");
            Console.WriteLine("     1. Create New Goal");
            Console.WriteLine("     2. List All Goals");
            Console.WriteLine("     3. Save Goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Event");
            Console.Write("Enter a number to do that activity, or enter 'quit' if you are done for today: ");
            string entry = Console.ReadLine();

            //Ensure user has a valid entry
            while (entry != "quit")
            {
                if ((entry != "1") && (entry != "2") && (entry != "3") && (entry != "4") && (entry != "5"))
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
                //switch case that runs a different task based on what the user input
                switch(entry)
                {
                    //Create a new goal
                    //Maybe figure out how to make this implementation simpler?
                    case "1":

                        //Print goal types for user to choose from
                        Console.WriteLine("There are three types of goals: ");
                        Console.WriteLine(" 1. Simple Goals");
                        Console.WriteLine(" 2. Eternal Goals");
                        Console.WriteLine(" 3. Checklist Goals");
                        Console.Write("Which type of goal would you like to create? ");
                        string newGoal = Console.ReadLine();

                        //Error handling to ensure they can only make a real goal
                        while((newGoal != "1") && (newGoal != "2") && (newGoal != "3"))
                        {
                            Console.Write("Invalid entry. Try again! ");
                            newGoal = Console.ReadLine();
                        }

                        //Generic goal information to enter, applicable to all goal type

                        Console.Write("Enter the name of your goal: ");
                        string goalName = Console.ReadLine();
                        Console.Write("Enter a short description: ");
                        string description = Console.ReadLine();
                        Console.Write("How many points should this goal be worth? ");
                        int goalPoints = int.Parse(Console.ReadLine());

                        //Make new kind of goal based on what the user input

                        //SimpleGoal
                        if(newGoal == "1")
                        {
                            SimpleGoal simpleGoal = new SimpleGoal(goalName, description, goalPoints);
                            user.AddGoal(simpleGoal);
                        }

                        //EternalGoal
                        else if(newGoal == "2")
                        {
                            EternalGoal eternalGoal = new EternalGoal(goalName, description, goalPoints);
                            user.AddGoal(eternalGoal);
                        }

                        //ChecklistGoal
                        else if(newGoal == "3")
                        {
                            //Additional information needed for Checklist goals
                            Console.Write("How many times would you like to accomplish this goal? ");
                            int numTimes = int.Parse(Console.ReadLine());
                            Console.Write("How many bonus points should you get upon completion? ");
                            int bonusPoints = int.Parse(Console.ReadLine());

                            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, description, goalPoints, numTimes, bonusPoints);
                            user.AddGoal(checklistGoal);
                        }

                        //Incorrect input
                        else
                        {
                            Console.WriteLine("Sorry- there was an error");
                            break;
                        }
                        
                        //Finish statement
                        Console.WriteLine("\nGoal recorded successfully!\n");
                        Thread.Sleep(3000);
                        break;

                    //Show all goals entered thus far
                    case "2":
                        user.DisplayAllGoals();
                        break;
                    
                    //Saves goals to a txt file
                    case "3":
                        user.SaveGoals();
                        break;

                    //Loads goals from a previously saved txt file
                    case "4":
                        user.LoadGoals();
                        user.DisplayAllGoals();
                        break;
                    
                    //Records progress on a goal, awards points, and marks complete
                    //depending on user input
                    case "5":
                        user.DisplayAllGoals();
                        Console.Write("Enter the number of the goal you want to update: ");
                        int goalNum = int.Parse(Console.ReadLine());
                        
                        //error handlingggggg
                        while ((goalNum < 1) || (goalNum > user.GetGoalsLength()))
                        {
                            Console.Write("Invalid entry. Try again! ");
                            goalNum = int.Parse(Console.ReadLine());
                        }

                        //Updates goal based on user input
                        Goal goalToUpdate = user.GetGoal(goalNum-1);
                        goalToUpdate.MarkComplete(user);
                        Thread.Sleep(3000);
                        break;

                    //Default switch case that shouldn't ever run but just in case
                    default:
                        Console.WriteLine("There was an error. How are you here?");
                        break;
                }
                //End switch case statement
            }
            //End task execution, while loop runs again
        }
        //Termination of entire program
    }
}