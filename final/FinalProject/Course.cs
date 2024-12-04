public class Course
{
    private List<Assignment> _courseAssignments = new List<Assignment>();
    private string _courseName;
    private int _latePenalty;

    public Course (string name, int pointsOff)
    {
        _courseName = name;
        _latePenalty = pointsOff;
    }

    public string GetCourseName()
    {
        return _courseName;
    }

    public void AddAssignment(Assignment assignment)
    {
        _courseAssignments.Add(assignment);
    }

    public void PrintCourseAssignments()
    {
        foreach(Assignment a in _courseAssignments)
        {
            //a.AssignmentInfo() eventually
            Console.WriteLine(a);
        }
    }
}