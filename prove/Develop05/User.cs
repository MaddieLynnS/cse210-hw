using System.IO;
public class User
{
    //Initialize variables
    private string _name;
    private int _points = 0;
    private Level level = new Level();

    //ADD LEVELS CLASS THAT HAS A NAME & DESCRIPTION
    //& UPDATES WHEN POINTS GET HIGHER
    private int _level = 0;
    private List<Goal> _goals = new List<Goal>();

    public User(string name)
    {
        _name = name;
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int GetPoints()
    {
        return _points;
    }

    //Updates point total of current user based on points
    //associated with that goal
    public void AddPoints(int points)
    {
        _points += points;
        LevelUp();
    }

    public void LevelUp()
    {
        if (level.GetLevel() < (_points / 100))
        {
            level.SetLevel((int)(_points / 100));
            Console.WriteLine("Congrats!! You levelled up!!");
            level.UpdateValues();
        }
    }

    //Displays current status of user
    public void DisplayStatus()
    {
        Console.WriteLine($"Welcome {_name}! You currently have {_points} points.\n");
        level.GetLevelStatus();
    }

    //Returns a goal from list so it can be marked complete

    public Goal GetGoal(int index)
    {
        return _goals[index];
    }

    //Returns length of goals list
    public int GetGoalsLength()
    {
        return _goals.Count();
    }

    //Displays all goals that have been logged by this user so far
    //by iterating through the List<Goal> from above
    public void DisplayAllGoals()
    {
        Console.WriteLine("\nHere are your goals!");

        foreach (Goal goal in _goals)
        {
            Console.Write($"{_goals.IndexOf(goal) + 1}. ");
            goal.DisplayGoal();
        }
        
        Console.WriteLine();
        Thread.Sleep(3000);
    }


    //Saves goals to a txt file for later retrieval
    public void SaveGoals()
    {
        Console.Write("Enter the name of the file you want to save this to: ");
        string _filename = Console.ReadLine() + ".txt";

        //creates file and saves each entry into the file
        using (StreamWriter _outputFile = new StreamWriter(_filename))
        {
            _outputFile.WriteLine($"{_points},{_level}");
            foreach (Goal goal in _goals)
            {
                _outputFile.WriteLine($"{goal.GoalAsString()}");
            }
        }
        Console.WriteLine("File saved successfully!");
    }


    //Loads goals that have been stored in a txt file
    //and puts them in the goal list
    public void LoadGoals()
    {
        Console.Write("Enter the name of the file you would like to load: ");
        string[] _allLines = File.ReadAllLines(Console.ReadLine() + ".txt");

        //Sets user info based on first line of file
        string[] _userLine = _allLines[0].Split(',');
        _points = int.Parse(_userLine[0]);
        _level = int.Parse(_userLine[1]);

        //Gets goal info from the rest of the file
        for (int i = 1; i < _allLines.Length; i++)
        {
            //Separates goal type from rest of goal details
            string[] _fullGoal = _allLines[i].Split(':');
            string[] _goalDetails = _fullGoal[1].Split(',');


            //Creates a SimpleGoal and adds it to the user List<Goal>
            if (_fullGoal[0].Contains("Simple"))
            {
                SimpleGoal simpleGoal = new SimpleGoal(_goalDetails[0],_goalDetails[1],int.Parse(_goalDetails[2]));
                AddGoal(simpleGoal);
                if (_goalDetails[3] == "true")
                {
                    simpleGoal.SetAsComplete();
                }
            }


            //Creates a EternalGoal and adds it to the user List<Goal>
            else if (_fullGoal[0].Contains("Eternal"))
            {
                EternalGoal eternalGoal = new EternalGoal(_goalDetails[0],_goalDetails[1],int.Parse(_goalDetails[2]));
                AddGoal(eternalGoal);
            }


            //Creates a ChecklistGoal and adds it to the user List<Goal>
            else if (_fullGoal[0].Contains("Checklist"))
            {
                ChecklistGoal check = new ChecklistGoal(_goalDetails[0],_goalDetails[1],int.Parse(_goalDetails[2]),
                int.Parse(_goalDetails[3]),int.Parse(_goalDetails[4]));
                AddGoal(check);
                check.SetTimesDone(int.Parse(_goalDetails[5]));
                if (int.Parse(_goalDetails[3]) == int.Parse(_goalDetails[5]))
                {
                    check.SetAsComplete();
                }
            }
        }
    }
}