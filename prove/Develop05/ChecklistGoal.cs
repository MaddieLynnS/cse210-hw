public class ChecklistGoal : Goal
{
    //Initialize variables unique to Checklist goals
    private int _goalNumTimes;
    private int _timesDone = 0;
    private int _bonusPoints;

    //Constructor
    public ChecklistGoal(string name, string des, int points, int numTimes, int bonusPoints) : base(name, des, points)
    {
        _goalNumTimes = numTimes;
        _bonusPoints = bonusPoints;
    }

    //Manually update timesDone as needed
    public void SetTimesDone(int times)
    {
        _timesDone = times;
    }

    //Manually update isCompleted as needed
    public void SetAsComplete()
    {
        _isCompleted = true;
    }

    //Adds points for each time complete, also awards bonus points and
    //marks goal as complete if it's been done enough times
    public override void MarkComplete(User user)
    {
        _timesDone++;
        user.AddPoints(_pointAmount);
        Console.WriteLine($"\nYay! You got {_pointAmount} points!");

        //Checks to see if the goal has been completed the total number
        //the user indicated- makes _isCompleted true if so and
        //awards bonusPoints
        if(_timesDone == _goalNumTimes)
        {
            SetAsComplete();
            user.AddPoints(_bonusPoints);
            Console.WriteLine($"\nYAYYY you got {_bonusPoints} bonus points!!");
        }
    }

    //Displays complete goal information
    public override void DisplayGoal()
    {
        Console.WriteLine($"[{(_isCompleted ? "X" : " ")}] {_name} ({_description})" +
        $" -- Times completed: {_timesDone}/{_goalNumTimes}");
    }

    //Returns goal as a string so it can be stored in a txt file
    public override string GoalAsString()
    {
        return $"ChecklistGoal:{_name},{_description},{_pointAmount},{_goalNumTimes}," +
        $"{_bonusPoints},{_timesDone}";
    }
}