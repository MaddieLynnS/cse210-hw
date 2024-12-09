public class Course
{
    private List<Assignment> _courseAssignments = new List<Assignment>();
    private string _courseName;
    private double _latePenalty;

    public Course (string name)
    {
        _courseName = name;
        _latePenalty = .25;
    }

    public string GetCourseName()
    {
        return _courseName;
    }

    //if i really wanted to be extra I could let user enter multiple and
    //split them up myself but I'm not there right now
    public void AddAssignment(Assignment assignment)
    {
        _courseAssignments.Add(assignment);
    }

    public void PrintCourseAssignments()
    {
        int i = 1;
        foreach(Assignment a in _courseAssignments)
        {
            Console.Write($"\n{i}. ");
            a.PrintAssignmentInfo();
            i++;
        }
    }

    public void GetCourseGrade()
    {
        //gets scores of all assignments, averages them, and
        //returns a letter grade
    }
}