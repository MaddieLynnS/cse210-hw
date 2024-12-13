using System.Runtime.CompilerServices;

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

    public int GetScore()
    {
        return _score;
    }
    public void SetScore(int score)
    {
        _score = score;
    }

    public int GetPriority()
    {
        return _priorty;
    }

    public DateTime GetDueDate()
    {
        return _dueDate.Date;
    }

    public bool IsComplete()
    {
        return _isCompleted;
    }


    public abstract void PrintAssignmentInfo();
    public abstract void CompleteAssignment();

    public void MarkComplete()
    {
        int input = 0;
        while(input < 1 || input > _pointValue)
        {
            Console.Write("Enter the score you got for this assignment (1-"+
            $"{_pointValue}): ");
            input = int.Parse(Console.ReadLine());
        }
        SetScore(input);
        _isCompleted = true;
    }

    
    //Order by a sorting value, increase points depending on
    //all applicable values
    //Is the same for all assignments
    public void CalculateInitialPriority(Assignment a)
    {
        a._priorty = 0;

        //if it is a Test assignment that is due within the next
        //two weeks, it gets 10 priority

        if(a.GetType().ToString() == "Test")
        {
            if((a._dueDate - DateTime.Now).Days < 14)
            {
                a._priorty += 10;
            }
        }

        //Due Date adds points
        if((a._dueDate - DateTime.Now).Days < 2)
        {
            a._priorty += 2;
        }
        else if((a._dueDate - DateTime.Now).Days < 5)
        {
            a._priorty++;
        }

        //Worth more points
        a._priorty += (int)Math.Floor((double)(a._pointValue / 100));

        //Time to complete
        if(a._timeToComplete >= 180)
        {
            a._priorty += 3;
        }
        else if (a._timeToComplete >= 120)
        {
            a._priorty += 2;
        }
        else if (a._timeToComplete >= 60)
        {
            a._priorty++;
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

    //--//initial step- order by due dates?
    //due dates- 2,7,9,3,5,6,8,1,4
    //--//tests move to top - 9,6,2,7,3,5,8,1,4
    //--//move up assignments on same day worth more points
    //6,9,2,7,5,3,8,1,4
    //--//if next day (or two days out) assignment is worth more, move it up
    //- 6,9,2,5,7,1,3,4,8
    //--//if assignment takes a lot longer to complete, move it up
    //- 6,9,2,5,7,1,4,3,8
    //if assignment comes from a course with a lower grade, it moves up

    //implement whether assignment has been completed in assignment info

    //COMPLETED ASSIGNMENTS SHOULDN"T SHOW UP ON LISTSSSSS


}