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


    public string CalculateCourseGrade()
    {
        string grade = "";
        //gets scores of all assignments, averages them,
        //updates _courseGrade variabe, and returns a letter grade
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
        _courseGrade = (double)totalActualPoints / (double)totalPointsPossible;
        Console.WriteLine(_courseGrade);
        if(_courseGrade > .90) 
        {
            grade = "A";
        } 
        else if(_courseGrade > .80) 
        {
            grade = "B";
        } 
        else if(_courseGrade > .70) 
        {
            grade = "C";
        } 
        else if(_courseGrade > .60) 
        {
            grade = "D";
        } 
        else 
        {
            grade = "F";
        }

        return grade;
    }
}