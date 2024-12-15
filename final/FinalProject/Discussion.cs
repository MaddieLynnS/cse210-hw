public class Discussion : Assignment
{
    //Private variables specific to this type
    private string _description;
    private int _wordCount;
    private int _numRequiredResponses;

    //Constructor
    public Discussion(string name, int points, int dur, DateTime due, string des, int count, int res)
    : base(name, points, dur, due)
    {
        _description = des;
        _wordCount = count;
        _numRequiredResponses = res;
    }

    //Prints assignment info
    public override void PrintAssignmentInfo()
    {
        Console.WriteLine($"This Discussion assignment is about {_description} "+
        $"and requires {_numRequiredResponses} responses.\n It is due on {GetDueDate()}"+
        $" and is worth {GetPoints()}.");
    }

    //Completes assignment
    public override void CompleteAssignment()
    {
        for(int i=1; i<=_numRequiredResponses; i++)
        {
            Console.Write("Enter your response: ");
            Console.ReadLine();

            Console.Write("Enter your word count for this response: ");
            _wordCount += int.Parse(Console.ReadLine());
        }
    }
}