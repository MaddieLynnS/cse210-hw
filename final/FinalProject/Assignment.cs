public abstract class Assignment
{
    private string _name;
    private int _pointValue;

    //Score student got on a past assignment
    //Only updates when a user completes an assignment
    private int _score = 0;
    
    //it's like a weight/urgency indicating
    //if it should be moved up in the priority list
    private int _priorty = 0;

    //Potential duration to complete assignment in minutes
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

    public string GetName()
    {
        return _name;
    }
    public int GetPoints()
    {
        return _pointValue;
    }

    public int GetPriority()
    {
        return _priorty;
    }

    public void SetPriority(int add)
    {
        _priorty += add;
    }

    public DateTime GetDueDate()
    {
        return _dueDate.Date;
    }


    public abstract void PrintAssignmentInfo();
    public abstract void CompleteAssignment();
    
    //Order by a sorting value, increase points depending on
    //all applicable values
    public virtual void CalculateInitialPriority()
    {
        //very clumsy first attempt but here goes nothing

        //Due Date adds points
        if((_dueDate - DateTime.Now).Days < 2)
        {
            _priorty += 2;
        }
        else if((_dueDate - DateTime.Now).Days < 5)
        {
            _priorty++;
        }

        //Worth more points
        _priorty += (int)Math.Floor((double)(_pointValue / 100));

        //Time to complete
        if(_timeToComplete >= 180)
        {
            _priorty += 3;
        }
        else if (_timeToComplete >= 120)
        {
            _priorty += 2;
        }
        else if (_timeToComplete >= 60)
        {
            _priorty++;
        }
    }

    //Example implementing the above logic
    //1- quiz due on 12/8 worth 40 points, takes 15 minutes
    //2- writing due on 12/5 worth 100 points, takes five hours
    //3- submit pic due on 12/6 worth 20 points, takes 5 minutes
    //4- writing due on 12/9 worth 50 points, takes 2 hours
    //5- discussion due on 12/6 worth 40 points, takes 30 minutes
    //6- test due 12/7 worth 100 points, takes an hour
    //7- submit doc due on 12/5 worth 30 points, takes 20 minutes
    //8- discussion due on 12/7 worth 20 points, takes 20 minutes
    //9- test due 12/5 worth 50 points, takes an hour

    //HOW TO SORT?

    //initial step- order by due dates?
    //due dates- 2,7,9,3,5,6,8,1,4
    //tests move to top - 9,6,2,7,3,5,8,1,4
    //move up assignments on same day worth more points
    //6,9,2,7,5,3,8,1,4
    //if next day (or two days out) assignment is worth more, move it up
    //- 6,9,2,5,7,1,3,4,8
    //if assignment takes a lot longer to complete, move it up
    //- 6,9,2,5,7,1,4,3,8
    //if assignment comes from a course with a lower grade, it moves up

    //implement whether assignment has been completed in assignment info


}