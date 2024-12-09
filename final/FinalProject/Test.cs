public class Test : Assignment
{
    private int _timeLimit;
    private int _questionAmount;
    private string _response;

    public Test(string name, int points, int dur, DateTime due, int time, int questions)
    : base(name, points, dur, due)
    {
        _timeLimit = time;
        _questionAmount = questions;
    }

    public override void PrintAssignmentInfo()
    {
        Console.WriteLine($"This Test Assignment has {_questionAmount} and requires a response."+
        $"\nIt's due on {GetDate()} and it's worth {GetPoints()} points.");
    }

    public override void CompleteAssignment()
    {
        Console.Write("Enter your response here: ");
        _response = Console.ReadLine();
    }
}