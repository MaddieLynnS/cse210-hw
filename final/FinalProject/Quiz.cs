public class Quiz : Assignment
{
    private int _questionAmount;
    private Array _answers;

    public Quiz(string name, int points, int dur, DateTime due, int questions)
    : base(name, points, dur, due)
    {
        _questionAmount = questions;
    }

    public override void PrintAssignmentInfo()
    {
        Console.WriteLine($"This Quiz Assignment has {_questionAmount} questions."+
        $"\nIt's due on {GetDueDate()} and it's worth {GetPoints()} points.");
    }

    public override void CompleteAssignment()
    {
        Console.Write("Enter your string of answers, separated by commas: ");
        _answers = Console.ReadLine().Split(',');
        MarkComplete();
    }
}