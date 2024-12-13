public class WritingAssignment : Assignment
{
    private string _description;
    private string _submission;
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
        Console.Write("Enter your submission for this assignment below: ");
        _submission = Console.ReadLine();
        //If I had more time I'd actually count the words in the submission
        Console.Write("Enter the word count for this submission: ");
        _wordCount = int.Parse(Console.ReadLine());
        MarkComplete();
    }
}