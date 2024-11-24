public class EternalGoal : Goal
{
    //Constructor inherited from Goal
    public EternalGoal(string name, string des, int points) : base(name, des, points)
    {}

    //Adds points, since EternalGoals can never become completed
    public override void MarkComplete(User user)
    {
        user.AddPoints(_pointAmount);
        Console.WriteLine($"\nCongratulations! You have earned {_pointAmount} points!\n");
    }

    //Displays goal info as a string
    public override void DisplayGoal()
    {
        Console.WriteLine($"[{(_isCompleted ? "X" : " ")}] {_name} ({_description})");
    }

    //Returns a string containing all goal info to be stored in txt file
    public override string GoalAsString()
    {
        return $"EternalGoal:{_name},{_description},{_pointAmount}";
    }
}