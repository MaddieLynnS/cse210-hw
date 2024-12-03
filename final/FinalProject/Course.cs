public class Course
{
    private string _courseName;
    private int _latePenalty;

    public Course (string name, int pointsOff)
    {
        _courseName = name;
        _latePenalty = pointsOff;
    }
}