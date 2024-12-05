public class Test : Assignment
{
    private int _timeLimit;
    private int _questionAmount;
    private string _response;

    public Test(string name, int points, int dur, DateTime due, int time, int questions, string res)
    : base(name, points, dur, due)
    {
        _timeLimit = time;
        _questionAmount = questions;
        _response = res;
    }

    public override void PrintAssignmentInfo()
    {
        Console.WriteLine($"This Test Assignment has {_questionAmount} and requires a response."+
        $"\nIt's due on {GetDate()} and it's worth {GetPoints()} points.");
    }
}