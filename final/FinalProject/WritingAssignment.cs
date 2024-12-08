public class WritingAssignment : Assignment
{
    private string _topic;
    private int _wordCount;

    public WritingAssignment(string name, int points, int dur, DateTime due, string topic, int count)
    : base(name, points, dur, due)
    {
        _topic = topic;
        _wordCount = count;
    }

    public override void PrintAssignmentInfo()
    {
        Console.WriteLine($"This Writing Assignment is about {_topic}."+
        $"\nIt's due on {GetDate()} and it's worth {GetPoints()} points.");
    }

    public override void CompleteAssignment()
    {
        throw new NotImplementedException();
    }
}