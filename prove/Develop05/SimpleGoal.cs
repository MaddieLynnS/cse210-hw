public class SimpleGoal : Goal
{
    //Constructor inherited from Goal
    public SimpleGoal(string name, string des, int points) : base(name, des, points)
    {}

    //Manually update isCompleted if needed
    public void SetAsComplete()
    {  
        _isCompleted = true;
    }

    //Updates isCompleted, adds user points
    public override void MarkComplete(User user)
    {
        SetAsComplete();
        Console.WriteLine("\nYay! You completed this goal!!");
        user.AddPoints(_pointAmount);
        Console.WriteLine($"{_pointAmount} points have been added!\n");
    }

    //Displays the goal info as a string
    public override void DisplayGoal()
    {
        Console.WriteLine($"[{(_isCompleted ? "X" : " ")}] {_name} ({_description})");
    }

    //Used for saving goal in a txt file as a string
    public override string GoalAsString()
    {
        return $"SimpleGoal:{_name},{_description},{_pointAmount},{_isCompleted}";
    }
}