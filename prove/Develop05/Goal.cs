using System.Drawing;

public abstract class Goal
{
    //Initialize variables
    protected string _name;
    protected string _description;
    protected int _pointAmount;
    protected bool _isCompleted = false;

    //Constructor for all goal types
    public Goal(string name, string des, int points)
    {
        _name = name;
        _description = des;
        _pointAmount = points;
    }

    //Abstract methods that don't need implementation here
    public abstract void DisplayGoal();
    public abstract void MarkComplete(User user);
    public abstract string GoalAsString();

}