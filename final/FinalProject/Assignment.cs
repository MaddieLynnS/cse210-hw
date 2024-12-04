public abstract class Assignment
{
    private string _name;
    private int _pointValue;
    private int _score = 0;
    
    //I'm not sure yet if I need this.
    //it's like a weight/urgency indicating
    //if it should be moved up in the priority list
    //private string _importance;

    //Potential duration to complete assignment in hours
    private int _timeToComplete;

    private DateTime _dueDate;
    private bool _isLate = false;
    private bool _isCompleted = false;


    //Constructor for all assignment types
    public Assignment(string name, int points, int duration, DateTime due)
    {
        _name = name;
        _pointValue = points;
        _timeToComplete = duration;
        _dueDate = due;
    }


}