public class Quiz : Assignment
{
    //Private variables specific to this type
    private int _questionAmount;
    private Array _answers;

    //Constructor
    public Quiz(string name, int points, int dur, DateTime due, int questions)
    : base(name, points, dur, due)
    {
        _questionAmount = questions;
    }

    //Prints assignment info
    public override void PrintAssignmentInfo()
    {
        Console.WriteLine($"This Quiz Assignment has {_questionAmount} questions."+
        $"\nIt's due on {GetDueDate()} and it's worth {GetPoints()} points.");
    }

    //Completes assignment
    public override void CompleteAssignment()
    {
        Console.Write("Enter your string of answers, separated by commas: ");
        _answers = Console.ReadLine().Split(',');
    }
}