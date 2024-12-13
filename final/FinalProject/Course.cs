public class Course
{
    private List<Assignment> _courseAssignments = new List<Assignment>();
    private string _courseName;
    private double _latePenalty;

    private double _courseGrade;

    public Course (string name)
    {
        _courseName = name;
        _latePenalty = .25;
    }

    public string GetCourseName()
    {
        return _courseName;
    }

    public double GetLatePenalty()
    {
        return _latePenalty;
    }

    public double GetCourseGrade()
    {
        return _courseGrade;
    }

    public List<Assignment> GetCourseAssignments()
    {
        return _courseAssignments;
    }

    //if i really wanted to be extra I could let user enter multiple and
    //split them up myself but I'm not there right now
    public void AddAssignment(Assignment assignment)
    {
        _courseAssignments.Add(assignment);
    }


    //gets scores of all completed assignments for a class, averages them,
    //updates _courseGrade variabe, and returns a letter grade
    public string CalculateCourseGrade()
    {
        int totalPointsPossible = 0;
        int totalActualPoints = 0;
        foreach(Assignment a in _courseAssignments)
        {
            if(a.IsComplete())
            {
                totalPointsPossible += a.GetPoints();
                totalActualPoints += a.GetScore();
            }
        }
        _courseGrade = Math.Round(((double)totalActualPoints / (double)totalPointsPossible) * 100);
        if(_courseGrade > 90) 
        {
            return $"{_courseGrade}% - A";
        } 
        else if(_courseGrade > 80) 
        {
            return $"{_courseGrade}% - B";
        } 
        else if(_courseGrade > 70) 
        {
            return $"{_courseGrade}% - C";
        } 
        else if(_courseGrade > 60) 
        {
            return $"{_courseGrade}% - D";
        } 
        else 
        {
            return $"{_courseGrade}% - F";
        }
    }
}