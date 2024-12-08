public class Quiz : Assignment
{
    private int _questionAmount;

    public Quiz(string name, int points, int dur, DateTime due, int questions)
    : base(name, points, dur, due)
    {
        _questionAmount = questions;
    }

    public override void PrintAssignmentInfo()
    {
        Console.WriteLine($"This Quiz Assignment has {_questionAmount} questions."+
        $"\nIt's due on {GetDate()} and it's worth {GetPoints()} points.");
    }

    public override void CompleteAssignment()
    {
        throw new NotImplementedException();
    }
}