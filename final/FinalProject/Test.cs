public class Test : Assignment
{
    private int _timeLimit;
    private int _questionAmount;
    private string _response;
    private Array _answers;

    public Test(string name, int points, int dur, DateTime due, int time, int questions)
    : base(name, points, dur, due)
    {
        _timeLimit = time;
        _questionAmount = questions;
    }

    public override void PrintAssignmentInfo()
    {
        Console.WriteLine($"This Test Assignment has {_questionAmount} and requires a response."+
        $"\nYou have to complete it in {_timeLimit} minutes. It's due on {GetDueDate()} and it's"+
        $" worth {GetPoints()} points.");
    }

    public override void CompleteAssignment()
    {
        Console.Write("Enter your answers for the questions, separated by commas: ");
        _answers = Console.ReadLine().Split(',');
        Console.Write("Enter your response here: ");
        _response = Console.ReadLine();
        MarkComplete();
    }
}