public class WritingAssignment : Assignment
{
    private string _description;
    private int _wordCount;

    public WritingAssignment(string name, int points, int dur, DateTime due, string des, int count)
    : base(name, points, dur, due)
    {
        _description = des;
        _wordCount = count;
    }

    public override void PrintAssignmentInfo()
    {
        Console.WriteLine($"This Writing Assignment is about {_description}."+
        $"\nIt's due on {GetDueDate()} and it's worth {GetPoints()} points.");
    }

    public override void CompleteAssignment()
    {
        throw new NotImplementedException();
    }
}