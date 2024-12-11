public class Discussion : Assignment
{
    private string _description;
    private int _wordCount;
    private int _numRequiredResponses;

    public Discussion(string name, int points, int dur, DateTime due, string des, int count, int res)
    : base(name, points, dur, due)
    {
        _description = des;
        _wordCount = count;
        _numRequiredResponses = res;
    }

    public override void PrintAssignmentInfo()
    {
        Console.WriteLine($"This Discussion assignment is about {_description} "+
        $"and requires {_numRequiredResponses}.\n It is due on {GetDueDate()}"+
        $" and is worth {GetPoints()}.");
    }

    public override void CompleteAssignment()
    {
        throw new NotImplementedException();
    }
}