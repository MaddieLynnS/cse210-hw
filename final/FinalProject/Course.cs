public class Course
{
    //List holds all assignments associated with this course
    private List<Assignment> _courseAssignments = new List<Assignment>();
    private string _courseName;
    private double _latePenalty;
    private int _courseGrade;

    //Constructor
    public Course (string name)
    {
        _courseName = name;
        _latePenalty = .25;
    }

    //GETTERS
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

    //Lets a user add an assignment to the Assignment masterlist
    public void AddAssignment(Assignment assignment)
    {
        _courseAssignments.Add(assignment);
    }

    //gets scores of all completed assignments for a class, averages them,
    //updates _courseGrade variab'e, and returns it
    public int CalculateCourseGrade()
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
        _courseGrade = (int)Math.Round(((double)totalActualPoints / (double)totalPointsPossible) * 100);
        return _courseGrade;
    }
}